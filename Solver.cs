using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Solver(XWDApp app)
        {
            this.app = app;
            InitializeComponent();

            xwdObj = new XWDObject(15, 15);
            puzzle = new Puzzle(xwdObj,false);
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
            //clueDisplay.Text = puzzle.getSelectedClue();
        }

        private void goToMenu_Click(object sender, EventArgs e)
        {
            app.GoToMenu();
        }

    }
}
