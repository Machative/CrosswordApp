using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrosswordApp
{
    public enum Tab
    {
        Menu=0,
        Creator,
        Solver
    }

    public partial class XWDApp : Form
    {
        public XWDApp()
        {
            InitializeComponent();
            Menu menu = new Menu(this);
            mainPanel.Controls.Add(menu);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void OpenCreator()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Creator(this));
        }
        public void OpenSolver()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Solver(this));
        }
        public void GoToMenu()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Menu(this));
        }
    }
}
