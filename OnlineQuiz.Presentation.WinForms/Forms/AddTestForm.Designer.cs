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
            RandomizeSectionsCkB = new CheckBox();
            PublishCkB = new CheckBox();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            OpenTestExplorerCkB = new CheckBox();
            AddBtn = new Button();
            CancelBtn = new Button();
            TitleMessageLbl = new Label();
            SuspendLayout();
            // 
            // RandomizeSectionsCkB
            // 
            RandomizeSectionsCkB.AutoSize = true;
            RandomizeSectionsCkB.Location = new Point(172, 193);
            RandomizeSectionsCkB.Name = "RandomizeSectionsCkB";
            RandomizeSectionsCkB.Size = new Size(316, 45);
            RandomizeSectionsCkB.TabIndex = 9;
            RandomizeSectionsCkB.Text = "RandomizeSections";
            RandomizeSectionsCkB.UseVisualStyleBackColor = true;
            // 
            // PublishCkB
            // 
            PublishCkB.AutoSize = true;
            PublishCkB.Location = new Point(172, 142);
            PublishCkB.Name = "PublishCkB";
            PublishCkB.Size = new Size(152, 45);
            PublishCkB.TabIndex = 10;
            PublishCkB.Text = "Publish";
            PublishCkB.UseVisualStyleBackColor = true;
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
            // OpenTestExplorerCkB
            // 
            OpenTestExplorerCkB.AutoSize = true;
            OpenTestExplorerCkB.Checked = true;
            OpenTestExplorerCkB.CheckState = CheckState.Checked;
            OpenTestExplorerCkB.Location = new Point(172, 244);
            OpenTestExplorerCkB.Name = "OpenTestExplorerCkB";
            OpenTestExplorerCkB.Size = new Size(306, 45);
            OpenTestExplorerCkB.TabIndex = 9;
            OpenTestExplorerCkB.Text = "Open Test Explorer";
            OpenTestExplorerCkB.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(776, 340);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(188, 58);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(582, 340);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(188, 58);
            CancelBtn.TabIndex = 12;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // TitleMessageLbl
            // 
            TitleMessageLbl.AutoSize = true;
            TitleMessageLbl.Location = new Point(172, 82);
            TitleMessageLbl.Name = "TitleMessageLbl";
            TitleMessageLbl.Size = new Size(90, 41);
            TitleMessageLbl.TabIndex = 13;
            TitleMessageLbl.Text = "blank";
            // 
            // AddTestForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 410);
            Controls.Add(TitleMessageLbl);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(OpenTestExplorerCkB);
            Controls.Add(RandomizeSectionsCkB);
            Controls.Add(PublishCkB);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Name = "AddTestForm";
            Text = "Add Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox RandomizeSectionsCkB;
        private CheckBox PublishCkB;
        private TextBox TitleTB;
        private Label TitleLbl;
        private CheckBox OpenTestExplorerCkB;
        private Button AddBtn;
        private Button CancelBtn;
        private Label TitleMessageLbl;
    }
}