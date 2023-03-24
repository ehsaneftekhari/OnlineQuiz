namespace OnlineQuiz.Presentation.WinForms
{
    partial class AddQuizForm
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
            TabControl = new TabControl();
            SettingTab = new TabPage();
            textBox1 = new TextBox();
            TitleLbl = new Label();
            QuestionsTab = new TabPage();
            TabControl.SuspendLayout();
            SettingTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(SettingTab);
            TabControl.Controls.Add(QuestionsTab);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1754, 1383);
            TabControl.TabIndex = 0;
            // 
            // SettingTab
            // 
            SettingTab.Controls.Add(textBox1);
            SettingTab.Controls.Add(TitleLbl);
            SettingTab.Location = new Point(10, 58);
            SettingTab.Name = "SettingTab";
            SettingTab.Padding = new Padding(3);
            SettingTab.Size = new Size(1734, 1315);
            SettingTab.TabIndex = 0;
            SettingTab.Text = "Setting";
            SettingTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(684, 47);
            textBox1.TabIndex = 1;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(32, 48);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Title";
            // 
            // QuestionsTab
            // 
            QuestionsTab.Location = new Point(10, 58);
            QuestionsTab.Name = "QuestionsTab";
            QuestionsTab.Padding = new Padding(3);
            QuestionsTab.Size = new Size(1734, 1315);
            QuestionsTab.TabIndex = 1;
            QuestionsTab.Text = "Questions";
            QuestionsTab.UseVisualStyleBackColor = true;
            // 
            // AddQuizForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1754, 1383);
            Controls.Add(TabControl);
            Name = "AddQuizForm";
            Text = "AddQuiz";
            TabControl.ResumeLayout(false);
            SettingTab.ResumeLayout(false);
            SettingTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage SettingTab;
        private TabPage QuestionsTab;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Label TitleLbl;
        private TextBox textBox1;
    }
}