namespace LinesOfCode
{
  partial class FormCalc
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtDirSource = new System.Windows.Forms.TextBox();
            this.xmlLbl = new System.Windows.Forms.Label();
            this.binaryLbl = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.txtLinesOfCode = new System.Windows.Forms.TextBox();
            this.linesLbl = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lvSources = new System.Windows.Forms.ListView();
            this.chDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCount = new System.Windows.Forms.TextBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(333, 336);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "&Count";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.Location = new System.Drawing.Point(333, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtDirSource
            // 
            this.txtDirSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirSource.Location = new System.Drawing.Point(140, 38);
            this.txtDirSource.Name = "txtDirSource";
            this.txtDirSource.Size = new System.Drawing.Size(268, 20);
            this.txtDirSource.TabIndex = 13;
            this.txtDirSource.Text = "C:\\sources";
            // 
            // xmlLbl
            // 
            this.xmlLbl.AutoSize = true;
            this.xmlLbl.Location = new System.Drawing.Point(9, 41);
            this.xmlLbl.Name = "xmlLbl";
            this.xmlLbl.Size = new System.Drawing.Size(78, 13);
            this.xmlLbl.TabIndex = 12;
            this.xmlLbl.Text = "Sorce directory";
            // 
            // binaryLbl
            // 
            this.binaryLbl.AutoSize = true;
            this.binaryLbl.Location = new System.Drawing.Point(9, 15);
            this.binaryLbl.Name = "binaryLbl";
            this.binaryLbl.Size = new System.Drawing.Size(83, 13);
            this.binaryLbl.TabIndex = 9;
            this.binaryLbl.Text = "Type of sources";
            // 
            // txtVolume
            // 
            this.txtVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVolume.Location = new System.Drawing.Point(140, 365);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(268, 20);
            this.txtVolume.TabIndex = 18;
            // 
            // volumeLbl
            // 
            this.volumeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.volumeLbl.AutoSize = true;
            this.volumeLbl.Location = new System.Drawing.Point(9, 368);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(100, 13);
            this.volumeLbl.TabIndex = 17;
            this.volumeLbl.Text = "Capacity of sources";
            // 
            // txtLinesOfCode
            // 
            this.txtLinesOfCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinesOfCode.Location = new System.Drawing.Point(140, 391);
            this.txtLinesOfCode.Name = "txtLinesOfCode";
            this.txtLinesOfCode.ReadOnly = true;
            this.txtLinesOfCode.Size = new System.Drawing.Size(268, 20);
            this.txtLinesOfCode.TabIndex = 20;
            // 
            // linesLbl
            // 
            this.linesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesLbl.AutoSize = true;
            this.linesLbl.Location = new System.Drawing.Point(9, 394);
            this.linesLbl.Name = "linesLbl";
            this.linesLbl.Size = new System.Drawing.Size(71, 13);
            this.linesLbl.TabIndex = 19;
            this.linesLbl.Text = "Lines of code";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "*.cpp;*.h;*.c;*.hpp;*.cs",
            "*.cpp;*.h;*.c;*.hpp",
            "*.cs",
            "*.sql",
            "*.php",
            "*.js;*.ts",
            "*.xml;*.xsd;*.xslt",
            "*.html;*.htm;*.php;*.css"});
            this.cbType.Location = new System.Drawing.Point(140, 12);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(268, 21);
            this.cbType.TabIndex = 21;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lvSources
            // 
            this.lvSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSources.CheckBoxes = true;
            this.lvSources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDir,
            this.chFile});
            this.lvSources.HideSelection = false;
            this.lvSources.Location = new System.Drawing.Point(12, 93);
            this.lvSources.Name = "lvSources";
            this.lvSources.Size = new System.Drawing.Size(396, 223);
            this.lvSources.TabIndex = 22;
            this.lvSources.UseCompatibleStateImageBehavior = false;
            this.lvSources.View = System.Windows.Forms.View.Details;
            this.lvSources.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvSources_ItemCheck);
            // 
            // chDir
            // 
            this.chDir.Text = "Katalog";
            this.chDir.Width = 161;
            // 
            // chFile
            // 
            this.chFile.Text = "Plik";
            this.chFile.Width = 193;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.Location = new System.Drawing.Point(140, 336);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(88, 20);
            this.txtCount.TabIndex = 24;
            // 
            // countLbl
            // 
            this.countLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(9, 339);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(68, 13);
            this.countLbl.TabIndex = 23;
            this.countLbl.Text = "Count of files";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 322);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(396, 8);
            this.progressBar.TabIndex = 25;
            this.progressBar.Value = 33;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(18, 70);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(15, 14);
            this.cbAll.TabIndex = 26;
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 418);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.lvSources);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.txtLinesOfCode);
            this.Controls.Add(this.linesLbl);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDirSource);
            this.Controls.Add(this.xmlLbl);
            this.Controls.Add(this.binaryLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCalc";
            this.Text = "Statistics of sources";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCalc_FormClosed);
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnProcess;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.TextBox txtDirSource;
    private System.Windows.Forms.Label xmlLbl;
    private System.Windows.Forms.Label binaryLbl;
    private System.Windows.Forms.TextBox txtVolume;
    private System.Windows.Forms.Label volumeLbl;
    private System.Windows.Forms.TextBox txtLinesOfCode;
    private System.Windows.Forms.Label linesLbl;
    private System.Windows.Forms.ComboBox cbType;
    private System.Windows.Forms.ListView lvSources;
    private System.Windows.Forms.ColumnHeader chDir;
    private System.Windows.Forms.ColumnHeader chFile;
    private System.Windows.Forms.TextBox txtCount;
    private System.Windows.Forms.Label countLbl;
    private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox cbAll;
    }
}

