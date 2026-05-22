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

        String saveFileName = "";
        public Creator(XWDApp app)
        {
            this.app = app;
            InitializeComponent();

            //TODO: Add code to load from cache if available
            //Otherwise, load with default 15x15
            xwdObj = new XWDObject(15, 15);
            puzzle = new Puzzle(xwdObj,true);
            puzzle.MouseUp += puzzle_Click;
            puzzle.OnUpdateSelection += new Puzzle.SelectionUpdateHandler(onSelectionUpdate);
            puzzlePanel.Controls.Add(puzzle);
            puzzlePanel.KeyUp += puzzle_KeyUp;

            clueInput.Text = puzzle.getSelectedClue();
            selectedWord.Text = puzzle.getSelectedWord();
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
                puzzle.EnterSolutionChar((char)e.KeyValue);
            }
        }

        //Random Blank Crossword Generator
        //Make some simplifying choices:
        //1. Generate top left or bottom left quadrant, then copy-rotate to other corner
        //2. Split the first row into n words each separated by a black box (a word can be blank, i.e. two consecutive black boxes)
        //Need to conform to rules - no words of length < 3, so a black box within 3 spaces of an edge must be adjacent to another black box nearer the edge
        private void generateRandomTemplate(int size)
        {
            //Some knobs to affect the nature of generations
            const int WORD_SIZE = 5;
            const int MAX_WORD_SIZE = 10;

            XWDObject randXWD = new XWDObject(size, size);
            Random rand = new Random();
            if (rand.Next(2) == 0) //Generate top left half and copy-rotate to bottom right
            {
                int row1words = rand.Next(size / WORD_SIZE);
                //generate row1words random lengths which add up to size (can be zero, but otherwise min 3)
                int offset = 0;
                for (int i = 0; i < row1words; i++)
                {
                    int wordlength = rand.Next(MAX_WORD_SIZE + 1 - 3) + 3;
                    if (wordlength == MAX_WORD_SIZE + 1) wordlength = 0; //include 0 without getting 1 and 2
                    if (offset + wordlength > size) wordlength = size - offset; //make sure word doesn't go past the edge
                    if (wordlength < 3) //if on the last word in the row and it's too small, black out the rest of the row and stop
                    {
                        for (int j = offset; j < size; j++) randXWD.getCell(0, j).blackOut();
                        break;
                    }
                    //otherwise blackout after the current word space
                    randXWD.getCell(0, offset + wordlength).blackOut();
                    offset += wordlength + 1;
                }
            }
            else //Generate bottom left half and copy-rotate to top right
            {

            }
        }
        private void onSelectionUpdate(object sender, EventArgs e)
        {
            clueInput.Text = puzzle.getSelectedClue();
            selectedWord.Text = puzzle.getSelectedWord();
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
            if (saveFileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XWD File|*.xwd";
                saveFileDialog.Title = "Save an XWD File";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    saveFileName = saveFileDialog.FileName;
                }
            }
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

        private void clueInput_TextChanged(object sender, EventArgs e)
        {
            puzzle.updateClue(clueInput.Text);
        }
    }
}
