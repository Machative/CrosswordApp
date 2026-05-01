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
        public Solver(XWDApp app)
        {
            this.app = app;
            InitializeComponent();

            //TODO: Add code to load from cache if available
            //Otherwise, load with null (default empty crossword)
            puzzlePanel.Controls.Add(new Puzzle());
        }

        private void goToMenu_Click(object sender, EventArgs e)
        {
            app.GoToMenu();
        }

    }
}
