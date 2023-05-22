namespace OnlineQuiz.Presentation.WinForms.UserControls.CheckFieldUserControls
{
    partial class CheckOptionDesignerUserControl
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
            ScoreLbl = new Label();
            ScorePanel = new Panel();
            ScoreNUD = new NumericUpDown();
            TextPanel = new Panel();
            TextLbl = new Label();
            TextRTB = new RichTextBox();
            ImageAddressPanel = new Panel();
            BrowseBTN = new Button();
            ImageAddressTB = new TextBox();
            ImageLbl = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreNUD).BeginInit();
            TextPanel.SuspendLayout();
            ImageAddressPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ScoreLbl
            // 
            ScoreLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ScoreLbl.AutoSize = true;
            ScoreLbl.Location = new Point(3, 8);
            ScoreLbl.Name = "ScoreLbl";
            ScoreLbl.Size = new Size(92, 41);
            ScoreLbl.TabIndex = 0;
            ScoreLbl.Text = "Score";
            // 
            // ScorePanel
            // 
            ScorePanel.Controls.Add(ScoreNUD);
            ScorePanel.Controls.Add(ScoreLbl);
            ScorePanel.Dock = DockStyle.Fill;
            ScorePanel.Location = new Point(3, 3);
            ScorePanel.Name = "ScorePanel";
            ScorePanel.Size = new Size(778, 64);
            ScorePanel.TabIndex = 2;
            // 
            // ScoreNUD
            // 
            ScoreNUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ScoreNUD.Location = new Point(152, 6);
            ScoreNUD.Name = "ScoreNUD";
            ScoreNUD.Size = new Size(611, 47);
            ScoreNUD.TabIndex = 1;
            ScoreNUD.ValueChanged += ScoreNUD_ValueChanged;
            // 
            // TextPanel
            // 
            TextPanel.Controls.Add(TextLbl);
            TextPanel.Controls.Add(TextRTB);
            TextPanel.Dock = DockStyle.Fill;
            TextPanel.Location = new Point(3, 73);
            TextPanel.Name = "TextPanel";
            TextPanel.Size = new Size(778, 156);
            TextPanel.TabIndex = 4;
            // 
            // TextLbl
            // 
            TextLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextLbl.AutoSize = true;
            TextLbl.Location = new Point(3, 0);
            TextLbl.Name = "TextLbl";
            TextLbl.Size = new Size(71, 41);
            TextLbl.TabIndex = 4;
            TextLbl.Text = "Text";
            // 
            // TextRTB
            // 
            TextRTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRTB.Location = new Point(0, 44);
            TextRTB.Name = "TextRTB";
            TextRTB.Size = new Size(766, 109);
            TextRTB.TabIndex = 3;
            TextRTB.Text = "";
            // 
            // ImageAddressPanel
            // 
            ImageAddressPanel.Controls.Add(BrowseBTN);
            ImageAddressPanel.Controls.Add(ImageAddressTB);
            ImageAddressPanel.Controls.Add(ImageLbl);
            ImageAddressPanel.Dock = DockStyle.Fill;
            ImageAddressPanel.Location = new Point(3, 235);
            ImageAddressPanel.Name = "ImageAddressPanel";
            ImageAddressPanel.Size = new Size(778, 64);
            ImageAddressPanel.TabIndex = 5;
            // 
            // BrowseBTN
            // 
            BrowseBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BrowseBTN.Location = new Point(577, 6);
            BrowseBTN.Name = "BrowseBTN";
            BrowseBTN.Size = new Size(198, 58);
            BrowseBTN.TabIndex = 2;
            BrowseBTN.Text = "Browse";
            BrowseBTN.UseVisualStyleBackColor = true;
            BrowseBTN.Click += BrowseBTN_Click;
            // 
            // ImageAddressTB
            // 
            ImageAddressTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImageAddressTB.Location = new Point(113, 12);
            ImageAddressTB.Name = "ImageAddressTB";
            ImageAddressTB.Size = new Size(458, 47);
            ImageAddressTB.TabIndex = 1;
            // 
            // ImageLbl
            // 
            ImageLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImageLbl.AutoSize = true;
            ImageLbl.Location = new Point(3, 15);
            ImageLbl.Name = "ImageLbl";
            ImageLbl.Size = new Size(101, 41);
            ImageLbl.TabIndex = 0;
            ImageLbl.Text = "Image";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(ScorePanel, 0, 0);
            tableLayoutPanel.Controls.Add(ImageAddressPanel, 0, 2);
            tableLayoutPanel.Controls.Add(TextPanel, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel.Size = new Size(784, 302);
            tableLayoutPanel.TabIndex = 6;
            // 
            // CheckOptionDesignerUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "CheckOptionDesignerUserControl";
            Size = new Size(784, 302);
            ScorePanel.ResumeLayout(false);
            ScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreNUD).EndInit();
            TextPanel.ResumeLayout(false);
            TextPanel.PerformLayout();
            ImageAddressPanel.ResumeLayout(false);
            ImageAddressPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label ScoreLbl;
        private Panel ScorePanel;
        private NumericUpDown ScoreNUD;
        private Panel ImageAddressPanel;
        private Label TextLbl;
        private RichTextBox TextRTB;
        private Panel TextPanel;
        private TextBox ImageAddressTB;
        private Label ImageLbl;
        private TableLayoutPanel tableLayoutPanel;
        private Button BrowseBTN;
    }
}
