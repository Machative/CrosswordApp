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
            selectedWord.Size = new Size(69, 15);
            selectedWord.TabIndex = 3;
            selectedWord.Text = "placeholder";
            // 
            // clueInput
            // 
            clueInput.Location = new Point(591, 81);
            clueInput.Name = "clueInput";
            clueInput.Size = new Size(533, 23);
            clueInput.TabIndex = 4;
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
            // Creator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
