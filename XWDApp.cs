using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO:
 * Make the solver show all clues in a scrollable field, with the selected clue displayed above in bold, and automatically scroll to the selected one
 * Add checks that run in the Creator whenever you save that warn you of empty letters and clues
 * Add feedback for buttons like save (i.e. save successful vs. no save location selected), possible error messages for other actions?
 */

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XWD File|*.xwd";
            openFileDialog.Title = "Load an XWD File";

            XWDObject xwdObj;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String[] fileContents;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContents = reader.ReadToEnd().Split("\r\n");
                }

                xwdObj = XWDObject.loadFromFile(fileContents);

                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(new Solver(this, xwdObj, openFileDialog.FileName));
            }
        }
        public void GoToMenu()
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new Menu(this));
        }
    }
}
