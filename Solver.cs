using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CrosswordApp
{
    public partial class Solver : UserControl
    {
        XWDApp app;
        Puzzle puzzle;
        XWDObject xwdObj;

        String saveFileName = "";

        //<clue number, box index>
        Dictionary<int, int> acrossClueMap;
        Dictionary<int, int> downClueMap;
        public Solver(XWDApp app, XWDObject obj, string savefile)
        {
            this.app = app;
            saveFileName = savefile;

            InitializeComponent();

            puzzle = new Puzzle();
            loadXWD(obj);

            puzzle.MouseUp += puzzle_Click;
            puzzle.OnUpdateSelection += new Puzzle.SelectionUpdateHandler(onSelectionUpdate);
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
        }

        private void puzzle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue >= 65 && e.KeyValue <= 90)
            {
                puzzle.EnterGuessChar((char)e.KeyValue);
            }
        }

        private void onSelectionUpdate(object sender, EventArgs e)
        {
            selectedClue.Text = puzzle.getSelectedClue();
            selectedWord.Text = puzzle.getSelectedWord();

            (int clueNum, Puzzle.selection.direction selectionDir) = puzzle.getSelectedClueNum();
            if(selectionDir == Puzzle.selection.direction.ACROSS)
            {
                acrossClueBox.SelectedIndex = acrossClueMap[clueNum];
                downClueBox.SelectedIndex = -1; //TODO: how to deselect/defocus the other box?
            }
            else
            {
                downClueBox.SelectedIndex = downClueMap[clueNum];
                acrossClueBox.SelectedIndex = -1;
            }
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XWD File|*.xwd";
            saveFileDialog.Title = "Save an XWD File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
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
            if (filepath != "")
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
        }
        private void loadXWD(XWDObject obj)
        {
            xwdObj = obj;
            puzzle.loadXWD(xwdObj);

            selectedClue.Text = puzzle.getSelectedClue();
            selectedWord.Text = puzzle.getSelectedWord();

            acrossClueMap = new Dictionary<int, int>();
            downClueMap = new Dictionary<int, int>();

            //Create naturally indexed clue dictionaries and fill boxes
            Dictionary<int, string> acrossClues = xwdObj.getAcrossClues();
            int ind = 0;
            foreach(int i in acrossClues.Keys)
            {
                acrossClueMap[i] = ind;
                ind++;
                acrossClueBox.Items.Add(i + ". " + acrossClues[i]);
            }
            Dictionary<int, string> downClues = xwdObj.getDownClues();
            ind = 0;
            foreach (int i in downClues.Keys)
            {
                downClueMap[i] = ind;
                ind++;
                downClueBox.Items.Add(i + ". " + downClues[i]);
            }
        }
        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XWD File|*.xwd";
            openFileDialog.Title = "Load an XWD File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String[] fileContents;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContents = reader.ReadToEnd().Split("\r\n");
                }

                loadXWD(XWDObject.loadFromFile(fileContents));

                saveFileName = openFileDialog.FileName;
            }

        }
        private void goToMenu_Click(object sender, EventArgs e)
        {
            app.GoToMenu();
        }

    }
}
