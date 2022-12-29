using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace LinesOfCode
{
    public class CalcClass
    {
        public static void DoCalc(ArrayList files, ProgressBar progress, out int lines, out int volume)
        {
            Form form = (Form)progress.Parent;
            Cursor current = form.Cursor;
            form.Cursor = Cursors.WaitCursor;
            volume = 0;
            lines = 0;
            progress.Maximum = files.Count;
            foreach (string file in files)
            {
                Boolean comment = false;
                StreamReader sr = File.OpenText(file);
                while (sr.Peek() >= 0)
                {
                    String line = sr.ReadLine();
                    volume += line.Length;
                    line = line.Trim();
                    if (line.Length == 0)
                        continue;
                    if (line.StartsWith("//") || line.StartsWith("#"))
                        continue;
                    if (line.Contains("<!--") && line.Contains("-->"))
                        continue;
                    if (line.Contains("/*") && line.Contains("*/"))
                    {
                        lines++;
                        continue;
                    }
                    if (line.StartsWith("/*") || line.StartsWith("<!--"))
                        comment = true;
                    if (comment && (line.Contains("*/") || line.Contains("-->")))
                    {
                        comment = false;
                        continue;
                    }
                    if (comment)
                        continue;
                    lines++;
                }
                sr.Close();
                progress.Value++;
            }
            form.Cursor = current;
        }
    }
}
