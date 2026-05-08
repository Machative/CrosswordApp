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
            saveBtn = new Button();
            saveAsBtn = new Button();
            loadBtn = new Button();
            selectedWord = new Label();
            selectedClue = new Label();
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
            // saveBtn
            // 
            saveBtn.Location = new Point(127, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(74, 21);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // saveAsBtn
            // 
            saveAsBtn.Location = new Point(207, 2);
            saveAsBtn.Name = "saveAsBtn";
            saveAsBtn.Size = new Size(76, 21);
            saveAsBtn.TabIndex = 7;
            saveAsBtn.Text = "Save As";
            saveAsBtn.UseVisualStyleBackColor = true;
            saveAsBtn.Click += saveAsBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(307, 1);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(60, 21);
            loadBtn.TabIndex = 8;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // selectedWord
            // 
            selectedWord.AutoSize = true;
            selectedWord.Location = new Point(548, 52);
            selectedWord.Name = "selectedWord";
            selectedWord.Size = new Size(83, 15);
            selectedWord.TabIndex = 10;
            selectedWord.Text = "Selected Word";
            // 
            // selectedClue
            // 
            selectedClue.AutoSize = true;
            selectedClue.Location = new Point(548, 77);
            selectedClue.Name = "selectedClue";
            selectedClue.Size = new Size(78, 15);
            selectedClue.TabIndex = 11;
            selectedClue.Text = "Selected Clue";
            // 
            // Solver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(selectedClue);
            Controls.Add(selectedWord);
            Controls.Add(puzzlePanel);
            Controls.Add(goToMenu);
            Controls.Add(loadBtn);
            Controls.Add(saveAsBtn);
            Controls.Add(saveBtn);
            Name = "Solver";
            Size = new Size(1189, 719);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goToMenu;
        private Panel puzzlePanel;
        private Button saveBtn;
        private Button saveAsBtn;
        private Button loadBtn;
        private Label selectedWord;
        private Label selectedClue;
    }
}
