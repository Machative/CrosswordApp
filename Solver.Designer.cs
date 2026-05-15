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
            this.goToMenu = new System.Windows.Forms.Button();
            this.puzzlePanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.selectedWord = new System.Windows.Forms.Label();
            this.selectedClue = new System.Windows.Forms.Label();
            this.acrossClueBox = new System.Windows.Forms.ListBox();
            this.downClueBox = new System.Windows.Forms.ListBox();
            this.acrossBoxLabel = new System.Windows.Forms.Label();
            this.downBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goToMenu
            // 
            this.goToMenu.Location = new System.Drawing.Point(4, 0);
            this.goToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goToMenu.Name = "goToMenu";
            this.goToMenu.Size = new System.Drawing.Size(107, 38);
            this.goToMenu.TabIndex = 1;
            this.goToMenu.Text = "Exit";
            this.goToMenu.UseVisualStyleBackColor = true;
            // 
            // puzzlePanel
            // 
            this.puzzlePanel.Location = new System.Drawing.Point(66, 87);
            this.puzzlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.puzzlePanel.Name = "puzzlePanel";
            this.puzzlePanel.Size = new System.Drawing.Size(643, 750);
            this.puzzlePanel.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(181, 3);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 35);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Location = new System.Drawing.Point(296, 3);
            this.saveAsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(109, 35);
            this.saveAsBtn.TabIndex = 7;
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(439, 2);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(86, 35);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // selectedWord
            // 
            this.selectedWord.AutoSize = true;
            this.selectedWord.Location = new System.Drawing.Point(783, 87);
            this.selectedWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedWord.Name = "selectedWord";
            this.selectedWord.Size = new System.Drawing.Size(127, 25);
            this.selectedWord.TabIndex = 10;
            this.selectedWord.Text = "Selected Word";
            // 
            // selectedClue
            // 
            this.selectedClue.AutoSize = true;
            this.selectedClue.Location = new System.Drawing.Point(783, 128);
            this.selectedClue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedClue.Name = "selectedClue";
            this.selectedClue.Size = new System.Drawing.Size(117, 25);
            this.selectedClue.TabIndex = 11;
            this.selectedClue.Text = "Selected Clue";
            // 
            // acrossClueBox
            // 
            this.acrossClueBox.FormattingEnabled = true;
            this.acrossClueBox.ItemHeight = 25;
            this.acrossClueBox.Location = new System.Drawing.Point(783, 225);
            this.acrossClueBox.Name = "acrossClueBox";
            this.acrossClueBox.Size = new System.Drawing.Size(240, 504);
            this.acrossClueBox.TabIndex = 12;
            // 
            // downClueBox
            // 
            this.downClueBox.FormattingEnabled = true;
            this.downClueBox.ItemHeight = 25;
            this.downClueBox.Location = new System.Drawing.Point(1080, 225);
            this.downClueBox.Name = "downClueBox";
            this.downClueBox.Size = new System.Drawing.Size(257, 504);
            this.downClueBox.TabIndex = 13;
            // 
            // acrossBoxLabel
            // 
            this.acrossBoxLabel.AutoSize = true;
            this.acrossBoxLabel.Location = new System.Drawing.Point(783, 197);
            this.acrossBoxLabel.Name = "acrossBoxLabel";
            this.acrossBoxLabel.Size = new System.Drawing.Size(112, 25);
            this.acrossBoxLabel.TabIndex = 14;
            this.acrossBoxLabel.Text = "Across Clues";
            // 
            // downBoxLabel
            // 
            this.downBoxLabel.AutoSize = true;
            this.downBoxLabel.Location = new System.Drawing.Point(1080, 197);
            this.downBoxLabel.Name = "downBoxLabel";
            this.downBoxLabel.Size = new System.Drawing.Size(106, 25);
            this.downBoxLabel.TabIndex = 15;
            this.downBoxLabel.Text = "Down Clues";
            // 
            // Solver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.downBoxLabel);
            this.Controls.Add(this.acrossBoxLabel);
            this.Controls.Add(this.downClueBox);
            this.Controls.Add(this.acrossClueBox);
            this.Controls.Add(this.selectedClue);
            this.Controls.Add(this.selectedWord);
            this.Controls.Add(this.puzzlePanel);
            this.Controls.Add(this.goToMenu);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveAsBtn);
            this.Controls.Add(this.saveBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Solver";
            this.Size = new System.Drawing.Size(1699, 1198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button goToMenu;
        private Panel puzzlePanel;
        private Button saveBtn;
        private Button saveAsBtn;
        private Button loadBtn;
        private Label selectedWord;
        private Label selectedClue;
        private ListBox acrossClueBox;
        private ListBox downClueBox;
        private Label acrossBoxLabel;
        private Label downBoxLabel;
    }
}
