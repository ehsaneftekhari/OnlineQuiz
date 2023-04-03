namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class TestPropertiesForm
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
            TitleMessageLbl = new Label();
            CancelBtn = new Button();
            ApplyBtn = new Button();
            RandomizeSectionsCkB = new CheckBox();
            PublishCkB = new CheckBox();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // TitleMessageLbl
            // 
            TitleMessageLbl.AutoSize = true;
            TitleMessageLbl.Location = new Point(172, 82);
            TitleMessageLbl.Name = "TitleMessageLbl";
            TitleMessageLbl.Size = new Size(90, 41);
            TitleMessageLbl.TabIndex = 21;
            TitleMessageLbl.Text = "blank";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(388, 340);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(188, 58);
            CancelBtn.TabIndex = 20;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(582, 340);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(188, 58);
            ApplyBtn.TabIndex = 19;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // RandomizeSectionsCkB
            // 
            RandomizeSectionsCkB.AutoSize = true;
            RandomizeSectionsCkB.Location = new Point(172, 193);
            RandomizeSectionsCkB.Name = "RandomizeSectionsCkB";
            RandomizeSectionsCkB.Size = new Size(316, 45);
            RandomizeSectionsCkB.TabIndex = 17;
            RandomizeSectionsCkB.Text = "RandomizeSections";
            RandomizeSectionsCkB.UseVisualStyleBackColor = true;
            // 
            // PublishCkB
            // 
            PublishCkB.AutoSize = true;
            PublishCkB.Location = new Point(172, 142);
            PublishCkB.Name = "PublishCkB";
            PublishCkB.Size = new Size(152, 45);
            PublishCkB.TabIndex = 18;
            PublishCkB.Text = "Publish";
            PublishCkB.UseVisualStyleBackColor = true;
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(172, 32);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(781, 47);
            TitleTB.TabIndex = 15;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(25, 35);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 14;
            TitleLbl.Text = "Title";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(776, 340);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(188, 58);
            SaveBtn.TabIndex = 22;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // TestPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 410);
            Controls.Add(SaveBtn);
            Controls.Add(TitleMessageLbl);
            Controls.Add(CancelBtn);
            Controls.Add(ApplyBtn);
            Controls.Add(RandomizeSectionsCkB);
            Controls.Add(PublishCkB);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Name = "TestPropertiesForm";
            Text = "Test Properties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleMessageLbl;
        private Button CancelBtn;
        private Button ApplyBtn;
        private CheckBox RandomizeSectionsCkB;
        private CheckBox PublishCkB;
        private TextBox TitleTB;
        private Label TitleLbl;
        private Button SaveBtn;
    }
}