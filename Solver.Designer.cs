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
    partial class Solver
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goToMenu = new Button();
            puzzlePanel = new Panel();
            SuspendLayout();
            // 
            // goToMenu
            // 
            goToMenu.Location = new Point(3, 0);
            goToMenu.Name = "goToMenu";
            goToMenu.Size = new Size(75, 23);
            goToMenu.TabIndex = 1;
            goToMenu.Text = "Exit";
            goToMenu.UseVisualStyleBackColor = true;
            goToMenu.Click += goToMenu_Click;
            // 
            // puzzlePanel
            // 
            puzzlePanel.Location = new Point(46, 52);
            puzzlePanel.Name = "puzzlePanel";
            puzzlePanel.Size = new Size(450, 450);
            puzzlePanel.TabIndex = 2;
            // 
            // Solver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(puzzlePanel);
            Controls.Add(goToMenu);
            Name = "Solver";
            Size = new Size(1189, 719);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goToMenu;
        private Panel puzzlePanel;
    }
}
