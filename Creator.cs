using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrosswordApp
{
    public partial class Creator : UserControl
    {
        XWDApp app;
        Puzzle puzzle;
        XWDObject xwdObj;

        String saveFileName;
        public Creator(XWDApp app)
        {
            this.app = app;
            InitializeComponent();

            //TODO: Add code to load from cache if available
            //Otherwise, load with default 15x15
            xwdObj = new XWDObject(15, 15);
            puzzle = new Puzzle(xwdObj);
            puzzle.MouseUp += puzzle_Click;
            puzzlePanel.Controls.Add(puzzle);
            puzzlePanel.KeyUp += puzzle_KeyUp;
        }

        private void puzzle_Click(object sender, MouseEventArgs e)
        {
            puzzlePanel.Focus();
            if (e.Button == MouseButtons.Left)
            {
                puzzle.Select(e.Location.X, e.Location.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                puzzle.Blackout(e.Location.X, e.Location.Y);
            }
        }

        private void puzzle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 65 && e.KeyValue <= 90)
            {
                puzzle.EnterChar((char)e.KeyValue);
            }
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XWD File|*.xwd";
            saveFileDialog.Title = "Save an XWD File";
            saveFileDialog.ShowDialog();

            
            if(saveFileDialog.FileName != "")
            {
                saveFileName = saveFileDialog.FileName;
                saveToFile(saveFileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveToFile(saveFileName);
        }

        private void saveToFile(string filepath)
        {
            string[] fileContents = xwdObj.toXWDFile();
            File.WriteAllText(filepath, String.Empty);
            using (StreamWriter sw = File.AppendText(saveFileName))
            {
                for (int i = 0; i < fileContents.Length; i++)
                {
                    sw.WriteLine(fileContents[i]);
                }
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XWD File|*.xwd";
            openFileDialog.Title = "Load an XWD File";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String[] fileContents;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContents = reader.ReadToEnd().Split("\r\n");
                }

                xwdObj = XWDObject.loadFromFile(fileContents);
                puzzle.loadXWD(xwdObj);

                saveFileName = openFileDialog.FileName;
            }
            
        }

        private void goToMenu_Click(object sender, EventArgs e)
        {
            app.GoToMenu();
        }
    }
}
