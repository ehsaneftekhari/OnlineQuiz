namespace OnlineQuiz.Presentation.WinForms
{
    partial class MainPanelFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainMenuStrip = new MenuStrip();
            quizToolStripMenuItem = new ToolStripMenuItem();
            addQuizToolStripMenuItem = new ToolStripMenuItem();
            quizzesListToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            takeQuizToolStripMenuItem = new ToolStripMenuItem();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(40, 40);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { quizToolStripMenuItem, userToolStripMenuItem, settingToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(2145, 49);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "mainMenuStrip";
            // 
            // quizToolStripMenuItem
            // 
            quizToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addQuizToolStripMenuItem, quizzesListToolStripMenuItem, takeQuizToolStripMenuItem });
            quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            quizToolStripMenuItem.Size = new Size(103, 45);
            quizToolStripMenuItem.Text = "Quiz";
            // 
            // addQuizToolStripMenuItem
            // 
            addQuizToolStripMenuItem.Name = "addQuizToolStripMenuItem";
            addQuizToolStripMenuItem.Size = new Size(448, 54);
            addQuizToolStripMenuItem.Text = "Add quiz";
            addQuizToolStripMenuItem.Click += addQuizToolStripMenuItem_Click;
            // 
            // quizzesListToolStripMenuItem
            // 
            quizzesListToolStripMenuItem.Name = "quizzesListToolStripMenuItem";
            quizzesListToolStripMenuItem.Size = new Size(448, 54);
            quizzesListToolStripMenuItem.Text = "Manage quizzes";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(102, 45);
            userToolStripMenuItem.Text = "User";
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(136, 48);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(448, 54);
            languageToolStripMenuItem.Text = "Language";
            // 
            // takeQuizToolStripMenuItem
            // 
            takeQuizToolStripMenuItem.Name = "takeQuizToolStripMenuItem";
            takeQuizToolStripMenuItem.Size = new Size(448, 54);
            takeQuizToolStripMenuItem.Text = "Take quiz";
            // 
            // MainPanelFrom
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2145, 1253);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "MainPanelFrom";
            Text = "MainPanelFrom";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem quizToolStripMenuItem;
        private ToolStripMenuItem quizzesListToolStripMenuItem;
        private ToolStripMenuItem addQuizToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem takeQuizToolStripMenuItem;
    }
}