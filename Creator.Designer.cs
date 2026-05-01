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
    partial class Creator
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
            this.label1 = new System.Windows.Forms.Label();
            this.goToMenu = new System.Windows.Forms.Button();
            this.puzzlePanel = new System.Windows.Forms.Panel();
            this.selectedWord = new System.Windows.Forms.Label();
            this.clueInput = new System.Windows.Forms.TextBox();
            this.clueLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.saveAsBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creator";
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
            this.goToMenu.Click += new System.EventHandler(this.goToMenu_Click);
            // 
            // puzzlePanel
            // 
            this.puzzlePanel.Location = new System.Drawing.Point(66, 87);
            this.puzzlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.puzzlePanel.Name = "puzzlePanel";
            this.puzzlePanel.Size = new System.Drawing.Size(643, 750);
            this.puzzlePanel.TabIndex = 2;
            // 
            // selectedWord
            // 
            this.selectedWord.AutoSize = true;
            this.selectedWord.Location = new System.Drawing.Point(787, 87);
            this.selectedWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedWord.Name = "selectedWord";
            this.selectedWord.Size = new System.Drawing.Size(104, 25);
            this.selectedWord.TabIndex = 3;
            this.selectedWord.Text = "placeholder";
            // 
            // clueInput
            // 
            this.clueInput.Location = new System.Drawing.Point(844, 135);
            this.clueInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clueInput.Name = "clueInput";
            this.clueInput.Size = new System.Drawing.Size(760, 31);
            this.clueInput.TabIndex = 4;
            // 
            // clueLabel
            // 
            this.clueLabel.AutoSize = true;
            this.clueLabel.Location = new System.Drawing.Point(787, 140);
            this.clueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clueLabel.Name = "clueLabel";
            this.clueLabel.Size = new System.Drawing.Size(50, 25);
            this.clueLabel.TabIndex = 5;
            this.clueLabel.Text = "Clue:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(127, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 34);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Location = new System.Drawing.Point(245, 2);
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(112, 34);
            this.saveAsBtn.TabIndex = 7;
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.UseVisualStyleBackColor = true;
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(374, 4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(112, 34);
            this.loadBtn.TabIndex = 8;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveAsBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.clueLabel);
            this.Controls.Add(this.clueInput);
            this.Controls.Add(this.selectedWord);
            this.Controls.Add(this.puzzlePanel);
            this.Controls.Add(this.goToMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Creator";
            this.Size = new System.Drawing.Size(1699, 1198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button goToMenu;
        private Panel puzzlePanel;
        private Label selectedWord;
        private TextBox clueInput;
        private Label clueLabel;
        private Button saveBtn;
        private Button saveAsBtn;
        private Button loadBtn;
    }
}
