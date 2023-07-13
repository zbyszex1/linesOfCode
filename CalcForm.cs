using System;
using System.IO;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Reflection;

namespace LinesOfCode
{
    public partial class FormCalc : Form
    {
        protected RegistryKey LinesOfCode;
        protected RegistryKey Windows;
        protected RegistryKey Settings;
        protected ArrayList types;
        protected Boolean lvReady;
        protected Int32 _left;
        protected Int32 _top;
        protected Int32 _cbIndex;
        protected int _volume;
        protected int _lines;
        protected int _checked;
        protected int _unchecked;
        protected Boolean allChecks;
        protected Boolean checkLoop;

        public FormCalc()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDataDialog;
            folderDataDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderDataDialog.Description = "Katalog plików";
            folderDataDialog.ShowNewFolderButton = true;
            folderDataDialog.SelectedPath = txtDirSource.Text;
            if (folderDataDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDirSource.Text = folderDataDialog.SelectedPath;
                lvReady = false;
                progressBar.Value = 0;
                txtCount.Text = "";
                txtVolume.Text = "";
                txtLinesOfCode.Text = "";
                ShowList(txtDirSource.Text);
                lvReady = true;
            }
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
            lvReady = false;
            LinesOfCode = Registry.CurrentUser.OpenSubKey("Software\\LinesOfCode", true);
            if( LinesOfCode == null )
                LinesOfCode = Registry.CurrentUser.CreateSubKey("Software\\LinesOfCode");
            Windows = LinesOfCode.OpenSubKey("Windows", true);
            if (Windows == null)
                Windows = Registry.CurrentUser.CreateSubKey("Software\\LinesOfCode\\Windows");
            Settings = LinesOfCode.OpenSubKey("Settings", true);
            if (Settings == null)
                Settings = Registry.CurrentUser.CreateSubKey("Software\\LinesOfCode\\Settings");
            Int32.TryParse(Windows.GetValue("Left", "450").ToString(), out _left);
            Int32.TryParse(Windows.GetValue("Top", "350").ToString(), out _top);
            Left = _left;
            Top = _top;
            Int32.TryParse(Settings.GetValue("cbIndex", "0").ToString(), out _cbIndex);
            cbType.SelectedIndex = _cbIndex;
            txtDirSource.Text = Settings.GetValue("Path", Environment.CurrentDirectory).ToString();
            ShowList(txtDirSource.Text);
        }

        private void FormCalc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Windows.SetValue("Left", Left.ToString());
            Windows.SetValue("Top", Top.ToString());
            Settings.SetValue("Path", txtDirSource.Text);
            Settings.SetValue("cbIndex", cbType.SelectedIndex.ToString());
            Settings.Close();
            Windows.Close();
            LinesOfCode.Close();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvReady = false;
            progressBar.Value = 0;
            txtCount.Text = "";
            txtVolume.Text = "";
            txtLinesOfCode.Text = "";
            ShowList(txtDirSource.Text);
            lvReady = true;
        }

        private void ShowList(String dir)
        {
            lvSources.Items.Clear();
            types = new ArrayList();
            String _types = cbType.Text;
            while(_types.Contains(";"))
            {
                int lp = _types.IndexOf(';');
                String _type = _types.Substring(1, lp-1);
                types.Add(_type);
                _types = _types.Substring(++lp);
            }
            if(_types.Length > 0 )
                types.Add(_types.Substring(1));
            checkLoop = false;
            FillList(dir, "");
        }

        private void FillList(String dir, String prefdir)
        {
            Cursor current = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            String[] files;
            try
            {
                files = Directory.GetFiles(dir, "*.*");
            }
            catch(Exception)
            {
                this.Cursor = current;
                return;
            }
            foreach (String subfile in files)
            {
                String file = Path.GetFileName(subfile);
                Boolean match = false;
                foreach (String type in types)
                {
                    if (file.EndsWith(type))
                    {
                        match = true;
                        break;
                    }
                }
                if(!match)
                    continue;
                ListViewItem li = lvSources.Items.Add(prefdir);
                li.SubItems.Add(file);
                li.Checked = true;
            }
            String[] dirs = Directory.GetDirectories(dir);
            foreach (String subdir in dirs)
            {
                int lp = subdir.LastIndexOf("\\");
                if (lp < 0)
                    continue;
                String shortdir = subdir.Substring(++lp);
                if (shortdir == ".git" || 
                    shortdir == ".vs" ||
                    shortdir == ".vscode" ||
                    shortdir == "node_modules" ||
                    shortdir == "obj" ||
                    shortdir == "bin" ||
                    shortdir == "build")
                    continue;
                if (prefdir.Length != 0)
                    shortdir = prefdir + "\\" + shortdir;
        FillList(subdir, shortdir);
            }
            cbAll.Checked = lvSources.Items.Count > 0;
            this.Cursor = current;
        }

        private void lvSources_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            if (!lvReady || allChecks || checkLoop)
                return;
            checkLoop = true;
            int index = e.Index;
            String dir = lvSources.Items[index].SubItems[0].Text;
            //CheckState cs = e.NewValue;
            Boolean cs = e.NewValue == CheckState.Checked;
            if (cs)
            {
                _checked++;
                if (_unchecked > 0)
                    _unchecked--;
            }
            else
            {
                if (_checked > 0)
                    _checked--;
                _unchecked++;
            }
            while (++index < lvSources.Items.Count)
            {
                if (!lvSources.Items[index].SubItems[0].Text.StartsWith(dir))
                    break;
                int lp = dir.Length;
                if (lvSources.Items[index].SubItems[0].Text.Length > lp &&
                    lvSources.Items[index].SubItems[0].Text[lp] != '\\')
                    break;
                if (lvSources.Items[index].Checked != cs)
                {
                    lvSources.Items[index].Checked = cs;
                    if (cs)
                    {
                        _checked++;
                        if (_unchecked > 0)
                            _unchecked--;
                    }
                    else
                    {
                        if (_checked > 0)
                            _checked--;
                        _unchecked++;
                    }
                }
            }
            if (_checked != 0 && _unchecked != 0)
                cbAll.CheckState = CheckState.Indeterminate;
            else
                cbAll.CheckState = _checked > 0 ? CheckState.Checked : CheckState.Unchecked;
            checkLoop = false;
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            Boolean state = cbAll.Checked;
            _checked = 0;
            _unchecked = 0;
            allChecks = true;
            for (int i=0; i < lvSources.Items.Count; i++)
            {
                lvSources.Items[i].Checked = state;
                if (state)
                    _checked++;
                else
                    _unchecked++;
            }
            allChecks = false;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            Cursor oldCursor = Cursor.Current;
            Cursor = Cursors.WaitCursor;
            _volume = 0;
            _lines = 0;
            ArrayList files = new ArrayList();
            progressBar.Maximum = 1;
            progressBar.Minimum = 0;
            progressBar.Value = 0;
            foreach (ListViewItem lvi in lvSources.Items)
            {
                if (!lvi.Checked)
                    continue;
                string subdir = lvi.SubItems[0].Text;
                String file = lvi.SubItems[1].Text;
                String dir = Path.Combine(txtDirSource.Text, subdir);
                file = Path.Combine(dir, file);
                files.Add(file);
            }
            CalcClass.DoCalc(files, progressBar, out _lines, out _volume);
            CultureInfo ci = new CultureInfo("pl-PL");
            ci.NumberFormat.NumberDecimalDigits = 0;
            _volume /= 1024;
            txtCount.Text = files.Count.ToString();
            txtVolume.Text = _volume.ToString() + " kB";
            txtLinesOfCode.Text = _lines.ToString("N", ci);
            Cursor = oldCursor;
        }

    }

}
