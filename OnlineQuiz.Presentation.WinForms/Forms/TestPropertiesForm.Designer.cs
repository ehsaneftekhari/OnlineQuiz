﻿namespace OnlineQuiz.Presentation.WinForms.Forms
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
            RandomizeSectionsCKB = new CheckBox();
            PublishCKB = new CheckBox();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            SuspendLayout();
            // 
            // RandomizeSectionsCKB
            // 
            RandomizeSectionsCKB.AutoSize = true;
            RandomizeSectionsCKB.Location = new Point(172, 136);
            RandomizeSectionsCKB.Name = "RandomizeSectionsCKB";
            RandomizeSectionsCKB.Size = new Size(316, 45);
            RandomizeSectionsCKB.TabIndex = 5;
            RandomizeSectionsCKB.Text = "RandomizeSections";
            RandomizeSectionsCKB.UseVisualStyleBackColor = true;
            // 
            // PublishCKB
            // 
            PublishCKB.AutoSize = true;
            PublishCKB.Location = new Point(172, 85);
            PublishCKB.Name = "PublishCKB";
            PublishCKB.Size = new Size(152, 45);
            PublishCKB.TabIndex = 6;
            PublishCKB.Text = "Publish";
            PublishCKB.UseVisualStyleBackColor = true;
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(172, 32);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(781, 47);
            TitleTB.TabIndex = 4;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(25, 35);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 3;
            TitleLbl.Text = "Title";
            // 
            // TestPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 205);
            Controls.Add(RandomizeSectionsCKB);
            Controls.Add(PublishCKB);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Name = "TestPropertiesForm";
            Text = "Test Properties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox RandomizeSectionsCKB;
        private CheckBox PublishCKB;
        private TextBox TitleTB;
        private Label TitleLbl;
    }
}