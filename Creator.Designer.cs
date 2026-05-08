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
            label1 = new Label();
            goToMenu = new Button();
            puzzlePanel = new Panel();
            selectedWord = new Label();
            clueInput = new TextBox();
            clueLabel = new Label();
            saveBtn = new Button();
            saveAsBtn = new Button();
            loadBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Creator";
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
            // selectedWord
            // 
            selectedWord.AutoSize = true;
            selectedWord.Location = new Point(551, 52);
            selectedWord.Name = "selectedWord";
            selectedWord.Size = new Size(83, 15);
            selectedWord.TabIndex = 3;
            selectedWord.Text = "Selected Word";
            // 
            // clueInput
            // 
            clueInput.Location = new Point(591, 81);
            clueInput.Name = "clueInput";
            clueInput.Size = new Size(533, 23);
            clueInput.TabIndex = 4;
            clueInput.TextChanged += clueInput_TextChanged;
            // 
            // clueLabel
            // 
            clueLabel.AutoSize = true;
            clueLabel.Location = new Point(551, 84);
            clueLabel.Name = "clueLabel";
            clueLabel.Size = new Size(34, 15);
            clueLabel.TabIndex = 5;
            clueLabel.Text = "Clue:";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(89, 1);
            saveBtn.Margin = new Padding(2, 2, 2, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(78, 20);
            saveBtn.TabIndex = 6;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // saveAsBtn
            // 
            saveAsBtn.Location = new Point(172, 1);
            saveAsBtn.Margin = new Padding(2, 2, 2, 2);
            saveAsBtn.Name = "saveAsBtn";
            saveAsBtn.Size = new Size(78, 20);
            saveAsBtn.TabIndex = 7;
            saveAsBtn.Text = "Save As";
            saveAsBtn.UseVisualStyleBackColor = true;
            saveAsBtn.Click += saveAsBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(262, 2);
            loadBtn.Margin = new Padding(2, 2, 2, 2);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(78, 20);
            loadBtn.TabIndex = 8;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // Creator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(loadBtn);
            Controls.Add(saveAsBtn);
            Controls.Add(saveBtn);
            Controls.Add(clueLabel);
            Controls.Add(clueInput);
            Controls.Add(selectedWord);
            Controls.Add(puzzlePanel);
            Controls.Add(goToMenu);
            Controls.Add(label1);
            Name = "Creator";
            Size = new Size(1189, 719);
            ResumeLayout(false);
            PerformLayout();

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
