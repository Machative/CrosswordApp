using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrosswordApp
{
    public partial class Creator : UserControl
    {
        XWDApp app;
        Puzzle puzzle;
        public Creator(XWDApp app)
        {
            this.app = app;
            InitializeComponent();

            //TODO: Add code to load from cache if available
            //Otherwise, load with default null
            puzzle = new Puzzle();
            puzzle.MouseUp += puzzle_Click;
            puzzlePanel.Controls.Add(puzzle);
        }

        private void goToMenu_Click(object sender, EventArgs e)
        {
            app.GoToMenu();
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
    }
}
