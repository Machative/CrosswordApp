using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CrosswordApp
{
    public partial class Menu : UserControl
    {
        XWDApp app;
        public Menu(XWDApp app)
        {
            this.app = app;
            InitializeComponent();
        }

        private void openCreator_Click(object sender, EventArgs e)
        {
            app.OpenCreator();
        }

        private void openSolver_Click(object sender, EventArgs e)
        {
            app.OpenSolver();
        }
    }
}
