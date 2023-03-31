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
            PropertiesTP_RandomizeSectionsCKB = new CheckBox();
            PropertiesTP_PublisheCKB = new CheckBox();
            PropertiesTP_TitleTB = new TextBox();
            PropertiesTP_TitleLbl = new Label();
            SuspendLayout();
            // 
            // PropertiesTP_RandomizeSectionsCKB
            // 
            PropertiesTP_RandomizeSectionsCKB.AutoSize = true;
            PropertiesTP_RandomizeSectionsCKB.Location = new Point(172, 136);
            PropertiesTP_RandomizeSectionsCKB.Name = "PropertiesTP_RandomizeSectionsCKB";
            PropertiesTP_RandomizeSectionsCKB.Size = new Size(316, 45);
            PropertiesTP_RandomizeSectionsCKB.TabIndex = 5;
            PropertiesTP_RandomizeSectionsCKB.Text = "RandomizeSections";
            PropertiesTP_RandomizeSectionsCKB.UseVisualStyleBackColor = true;
            // 
            // PropertiesTP_PublisheCKB
            // 
            PropertiesTP_PublisheCKB.AutoSize = true;
            PropertiesTP_PublisheCKB.Location = new Point(172, 85);
            PropertiesTP_PublisheCKB.Name = "PropertiesTP_PublisheCKB";
            PropertiesTP_PublisheCKB.Size = new Size(168, 45);
            PropertiesTP_PublisheCKB.TabIndex = 6;
            PropertiesTP_PublisheCKB.Text = "Publishe";
            PropertiesTP_PublisheCKB.UseVisualStyleBackColor = true;
            // 
            // PropertiesTP_TitleTB
            // 
            PropertiesTP_TitleTB.Location = new Point(172, 32);
            PropertiesTP_TitleTB.Name = "PropertiesTP_TitleTB";
            PropertiesTP_TitleTB.Size = new Size(781, 47);
            PropertiesTP_TitleTB.TabIndex = 4;
            // 
            // PropertiesTP_TitleLbl
            // 
            PropertiesTP_TitleLbl.AutoSize = true;
            PropertiesTP_TitleLbl.Location = new Point(25, 35);
            PropertiesTP_TitleLbl.Name = "PropertiesTP_TitleLbl";
            PropertiesTP_TitleLbl.Size = new Size(74, 41);
            PropertiesTP_TitleLbl.TabIndex = 3;
            PropertiesTP_TitleLbl.Text = "Title";
            // 
            // TestPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 205);
            Controls.Add(PropertiesTP_RandomizeSectionsCKB);
            Controls.Add(PropertiesTP_PublisheCKB);
            Controls.Add(PropertiesTP_TitleTB);
            Controls.Add(PropertiesTP_TitleLbl);
            Name = "TestPropertiesForm";
            Text = "TestPropertiesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox PropertiesTP_RandomizeSectionsCKB;
        private CheckBox PropertiesTP_PublisheCKB;
        private TextBox PropertiesTP_TitleTB;
        private Label PropertiesTP_TitleLbl;
    }
}