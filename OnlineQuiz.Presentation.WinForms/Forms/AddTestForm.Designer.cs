namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class AddTestForm
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
            RandomizeSectionsCKB = new CheckBox();
            PublishCKB = new CheckBox();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            OpenTestExplorerCKB = new CheckBox();
            SuspendLayout();
            // 
            // RandomizeSectionsCKB
            // 
            RandomizeSectionsCKB.AutoSize = true;
            RandomizeSectionsCKB.Location = new Point(172, 136);
            RandomizeSectionsCKB.Name = "RandomizeSectionsCKB";
            RandomizeSectionsCKB.Size = new Size(316, 45);
            RandomizeSectionsCKB.TabIndex = 9;
            RandomizeSectionsCKB.Text = "RandomizeSections";
            RandomizeSectionsCKB.UseVisualStyleBackColor = true;
            // 
            // PublishCKB
            // 
            PublishCKB.AutoSize = true;
            PublishCKB.Location = new Point(172, 85);
            PublishCKB.Name = "PublishCKB";
            PublishCKB.Size = new Size(152, 45);
            PublishCKB.TabIndex = 10;
            PublishCKB.Text = "Publish";
            PublishCKB.UseVisualStyleBackColor = true;
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(172, 32);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(781, 47);
            TitleTB.TabIndex = 8;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(25, 35);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 7;
            TitleLbl.Text = "Title";
            // 
            // OpenTestExplorerCKB
            // 
            OpenTestExplorerCKB.AutoSize = true;
            OpenTestExplorerCKB.Location = new Point(172, 187);
            OpenTestExplorerCKB.Name = "OpenTestExplorerCKB";
            OpenTestExplorerCKB.Size = new Size(306, 45);
            OpenTestExplorerCKB.TabIndex = 9;
            OpenTestExplorerCKB.Text = "Open Test Explorer";
            OpenTestExplorerCKB.UseVisualStyleBackColor = true;
            // 
            // AddTestForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 260);
            Controls.Add(OpenTestExplorerCKB);
            Controls.Add(RandomizeSectionsCKB);
            Controls.Add(PublishCKB);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Name = "AddTestForm";
            Text = "Add Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox RandomizeSectionsCKB;
        private CheckBox PublishCKB;
        private TextBox TitleTB;
        private Label TitleLbl;
        private CheckBox OpenTestExplorerCKB;
    }
}