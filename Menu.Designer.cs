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
    partial class Menu
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
            openCreator = new Button();
            openSolver = new Button();
            SuspendLayout();
            // 
            // openCreator
            // 
            openCreator.Location = new Point(309, 162);
            openCreator.Name = "openCreator";
            openCreator.Size = new Size(75, 23);
            openCreator.TabIndex = 0;
            openCreator.Text = "Create";
            openCreator.UseVisualStyleBackColor = true;
            openCreator.Click += openCreator_Click;
            // 
            // openSolver
            // 
            openSolver.Location = new Point(417, 164);
            openSolver.Name = "openSolver";
            openSolver.Size = new Size(75, 23);
            openSolver.TabIndex = 1;
            openSolver.Text = "Solve";
            openSolver.UseVisualStyleBackColor = true;
            openSolver.Click += openSolver_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(openSolver);
            Controls.Add(openCreator);
            Name = "Menu";
            Size = new Size(1189, 719);
            ResumeLayout(false);
        }

        #endregion

        private Button openCreator;
        private Button openSolver;
    }
}
