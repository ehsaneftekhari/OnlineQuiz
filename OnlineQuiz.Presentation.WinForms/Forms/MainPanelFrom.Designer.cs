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
            menuStrip1 = new MenuStrip();
            quizToolStripMenuItem = new ToolStripMenuItem();
            addQuizeToolStripMenuItem = new ToolStripMenuItem();
            quizesListToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            takeQuizToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quizToolStripMenuItem, userToolStripMenuItem, settingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2145, 49);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quizToolStripMenuItem
            // 
            quizToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addQuizeToolStripMenuItem, quizesListToolStripMenuItem, takeQuizToolStripMenuItem });
            quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            quizToolStripMenuItem.Size = new Size(103, 45);
            quizToolStripMenuItem.Text = "Quiz";
            // 
            // addQuizeToolStripMenuItem
            // 
            addQuizeToolStripMenuItem.Name = "addQuizeToolStripMenuItem";
            addQuizeToolStripMenuItem.Size = new Size(448, 54);
            addQuizeToolStripMenuItem.Text = "Add quiz";
            addQuizeToolStripMenuItem.Click += addQuizToolStripMenuItem_Click;
            // 
            // quizesListToolStripMenuItem
            // 
            quizesListToolStripMenuItem.Name = "quizesListToolStripMenuItem";
            quizesListToolStripMenuItem.Size = new Size(448, 54);
            quizesListToolStripMenuItem.Text = "Manage quizes";
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainPanelFrom";
            Text = "MainPanelFrom";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quizToolStripMenuItem;
        private ToolStripMenuItem quizesListToolStripMenuItem;
        private ToolStripMenuItem addQuizeToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem takeQuizToolStripMenuItem;
    }
}