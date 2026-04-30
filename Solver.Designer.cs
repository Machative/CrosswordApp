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
            label1 = new Label();
            goToMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Solver";
            // 
            // goToMenu
            // 
            goToMenu.Location = new Point(3, 3);
            goToMenu.Name = "goToMenu";
            goToMenu.Size = new Size(75, 23);
            goToMenu.TabIndex = 1;
            goToMenu.Text = "Exit";
            goToMenu.UseVisualStyleBackColor = true;
            goToMenu.Click += goToMenu_Click;
            // 
            // Solver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(goToMenu);
            Controls.Add(label1);
            Name = "Solver";
            Size = new Size(1189, 719);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button goToMenu;
    }
}
