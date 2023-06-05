namespace OnlineQuiz.Presentation.WinForms.UserControls.QuestionUserControls
{
    partial class AddQuestionUserControl
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            TextRTB = new RichTextBox();
            TextLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel5 = new Panel();
            RemainingTimeValueLbl = new Label();
            DurationLbl = new Label();
            DurationHoursNUD = new NumericUpDown();
            RemainingTimeValuePB = new ProgressBar();
            RemainingTimeLbl = new Label();
            DurationSecondsNUD = new NumericUpDown();
            DurationSecondsLbl = new Label();
            DurationMinutesNUD = new NumericUpDown();
            DurationMinutesLbl = new Label();
            DurationHoursLbl = new Label();
            panel4 = new Panel();
            TypeLbl = new Label();
            TypeCB = new ComboBox();
            panel7 = new Panel();
            OrderNUD = new NumericUpDown();
            OrderLbl = new Label();
            panel6 = new Panel();
            ScoreNUD = new NumericUpDown();
            ScoreLbl = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            ImageAddressLbl = new Label();
            ImageBrowseBtn = new Button();
            ImageAddressTB = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel9 = new Panel();
            ClearAfterAddRBtn = new RadioButton();
            CloseAfterAddRBtn = new RadioButton();
            AddBtn = new Button();
            CancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DurationHoursNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationSecondsNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationMinutesNUD).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderNUD).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreNUD).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(2537, 1485);
            splitContainer1.SplitterDistance = 1352;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(TextRTB);
            splitContainer2.Panel1.Controls.Add(TextLbl);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(1181, 1485);
            splitContainer2.SplitterDistance = 225;
            splitContainer2.TabIndex = 0;
            // 
            // TextRTB
            // 
            TextRTB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRTB.Location = new Point(3, 44);
            TextRTB.Name = "TextRTB";
            TextRTB.Size = new Size(1171, 174);
            TextRTB.TabIndex = 3;
            TextRTB.Text = "";
            // 
            // TextLbl
            // 
            TextLbl.AutoSize = true;
            TextLbl.Location = new Point(3, 0);
            TextLbl.Name = "TextLbl";
            TextLbl.Size = new Size(71, 41);
            TextLbl.TabIndex = 2;
            TextLbl.Text = "Text";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(panel6, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1177, 1252);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(RemainingTimeValueLbl);
            panel5.Controls.Add(DurationLbl);
            panel5.Controls.Add(DurationHoursNUD);
            panel5.Controls.Add(RemainingTimeValuePB);
            panel5.Controls.Add(RemainingTimeLbl);
            panel5.Controls.Add(DurationSecondsNUD);
            panel5.Controls.Add(DurationSecondsLbl);
            panel5.Controls.Add(DurationMinutesNUD);
            panel5.Controls.Add(DurationMinutesLbl);
            panel5.Controls.Add(DurationHoursLbl);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(1171, 247);
            panel5.TabIndex = 39;
            // 
            // RemainingTimeValueLbl
            // 
            RemainingTimeValueLbl.AutoSize = true;
            RemainingTimeValueLbl.Location = new Point(3, 203);
            RemainingTimeValueLbl.Margin = new Padding(3);
            RemainingTimeValueLbl.Name = "RemainingTimeValueLbl";
            RemainingTimeValueLbl.Size = new Size(110, 41);
            RemainingTimeValueLbl.TabIndex = 37;
            RemainingTimeValueLbl.Text = "RTVLbl";
            // 
            // DurationLbl
            // 
            DurationLbl.AutoSize = true;
            DurationLbl.Location = new Point(3, 3);
            DurationLbl.Margin = new Padding(3);
            DurationLbl.Name = "DurationLbl";
            DurationLbl.Size = new Size(133, 41);
            DurationLbl.TabIndex = 24;
            DurationLbl.Text = "Duration";
            // 
            // DurationHoursNUD
            // 
            DurationHoursNUD.Location = new Point(3, 50);
            DurationHoursNUD.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            DurationHoursNUD.Name = "DurationHoursNUD";
            DurationHoursNUD.Size = new Size(81, 47);
            DurationHoursNUD.TabIndex = 34;
            DurationHoursNUD.ValueChanged += DurationNUD_ValueChanged;
            // 
            // RemainingTimeValuePB
            // 
            RemainingTimeValuePB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemainingTimeValuePB.Location = new Point(3, 144);
            RemainingTimeValuePB.Name = "RemainingTimeValuePB";
            RemainingTimeValuePB.Size = new Size(1165, 47);
            RemainingTimeValuePB.TabIndex = 35;
            // 
            // RemainingTimeLbl
            // 
            RemainingTimeLbl.AutoSize = true;
            RemainingTimeLbl.Location = new Point(3, 100);
            RemainingTimeLbl.Name = "RemainingTimeLbl";
            RemainingTimeLbl.Size = new Size(238, 41);
            RemainingTimeLbl.TabIndex = 13;
            RemainingTimeLbl.Text = "Remaining Time:";
            // 
            // DurationSecondsNUD
            // 
            DurationSecondsNUD.Location = new Point(273, 50);
            DurationSecondsNUD.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            DurationSecondsNUD.Name = "DurationSecondsNUD";
            DurationSecondsNUD.Size = new Size(81, 47);
            DurationSecondsNUD.TabIndex = 34;
            DurationSecondsNUD.ValueChanged += DurationNUD_ValueChanged;
            // 
            // DurationSecondsLbl
            // 
            DurationSecondsLbl.AutoSize = true;
            DurationSecondsLbl.Location = new Point(360, 52);
            DurationSecondsLbl.Name = "DurationSecondsLbl";
            DurationSecondsLbl.Size = new Size(34, 41);
            DurationSecondsLbl.TabIndex = 18;
            DurationSecondsLbl.Text = "S";
            // 
            // DurationMinutesNUD
            // 
            DurationMinutesNUD.Location = new Point(135, 50);
            DurationMinutesNUD.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            DurationMinutesNUD.Name = "DurationMinutesNUD";
            DurationMinutesNUD.Size = new Size(81, 47);
            DurationMinutesNUD.TabIndex = 34;
            DurationMinutesNUD.ValueChanged += DurationNUD_ValueChanged;
            // 
            // DurationMinutesLbl
            // 
            DurationMinutesLbl.AutoSize = true;
            DurationMinutesLbl.Location = new Point(222, 52);
            DurationMinutesLbl.Name = "DurationMinutesLbl";
            DurationMinutesLbl.Size = new Size(45, 41);
            DurationMinutesLbl.TabIndex = 18;
            DurationMinutesLbl.Text = "M";
            // 
            // DurationHoursLbl
            // 
            DurationHoursLbl.AutoSize = true;
            DurationHoursLbl.Location = new Point(90, 52);
            DurationHoursLbl.Name = "DurationHoursLbl";
            DurationHoursLbl.Size = new Size(39, 41);
            DurationHoursLbl.TabIndex = 18;
            DurationHoursLbl.Text = "H";
            // 
            // panel4
            // 
            panel4.Controls.Add(TypeLbl);
            panel4.Controls.Add(TypeCB);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 171);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1177, 56);
            panel4.TabIndex = 3;
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.Location = new Point(3, 6);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(81, 41);
            TypeLbl.TabIndex = 1;
            TypeLbl.Text = "Type";
            // 
            // TypeCB
            // 
            TypeCB.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TypeCB.FormattingEnabled = true;
            TypeCB.Location = new Point(107, 3);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(1067, 49);
            TypeCB.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(OrderNUD);
            panel7.Controls.Add(OrderLbl);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 118);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1177, 53);
            panel7.TabIndex = 3;
            // 
            // OrderNUD
            // 
            OrderNUD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderNUD.Location = new Point(107, 3);
            OrderNUD.Name = "OrderNUD";
            OrderNUD.Size = new Size(1067, 47);
            OrderNUD.TabIndex = 2;
            // 
            // OrderLbl
            // 
            OrderLbl.AutoSize = true;
            OrderLbl.Location = new Point(3, 5);
            OrderLbl.Name = "OrderLbl";
            OrderLbl.Size = new Size(95, 41);
            OrderLbl.TabIndex = 1;
            OrderLbl.Text = "Order";
            // 
            // panel6
            // 
            panel6.Controls.Add(ScoreNUD);
            panel6.Controls.Add(ScoreLbl);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 65);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1177, 53);
            panel6.TabIndex = 3;
            // 
            // ScoreNUD
            // 
            ScoreNUD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ScoreNUD.Location = new Point(107, 3);
            ScoreNUD.Name = "ScoreNUD";
            ScoreNUD.Size = new Size(1067, 47);
            ScoreNUD.TabIndex = 2;
            // 
            // ScoreLbl
            // 
            ScoreLbl.AutoSize = true;
            ScoreLbl.Location = new Point(3, 5);
            ScoreLbl.Name = "ScoreLbl";
            ScoreLbl.Size = new Size(92, 41);
            ScoreLbl.TabIndex = 1;
            ScoreLbl.Text = "Score";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(ImageAddressLbl, 0, 0);
            tableLayoutPanel5.Controls.Add(ImageBrowseBtn, 2, 0);
            tableLayoutPanel5.Controls.Add(ImageAddressTB, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1177, 65);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // ImageAddressLbl
            // 
            ImageAddressLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ImageAddressLbl.AutoSize = true;
            ImageAddressLbl.Location = new Point(3, 12);
            ImageAddressLbl.Name = "ImageAddressLbl";
            ImageAddressLbl.Size = new Size(101, 41);
            ImageAddressLbl.TabIndex = 3;
            ImageAddressLbl.Text = "Image";
            // 
            // ImageBrowseBtn
            // 
            ImageBrowseBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ImageBrowseBtn.Location = new Point(1052, 3);
            ImageBrowseBtn.MaximumSize = new Size(122, 58);
            ImageBrowseBtn.MinimumSize = new Size(122, 58);
            ImageBrowseBtn.Name = "ImageBrowseBtn";
            ImageBrowseBtn.Size = new Size(122, 58);
            ImageBrowseBtn.TabIndex = 5;
            ImageBrowseBtn.Text = "Browse";
            ImageBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // ImageAddressTB
            // 
            ImageAddressTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ImageAddressTB.Location = new Point(110, 9);
            ImageAddressTB.Name = "ImageAddressTB";
            ImageAddressTB.Size = new Size(936, 47);
            ImageAddressTB.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel9, 0, 1);
            tableLayoutPanel2.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(2537, 1549);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BorderStyle = BorderStyle.Fixed3D;
            panel9.Controls.Add(ClearAfterAddRBtn);
            panel9.Controls.Add(CloseAfterAddRBtn);
            panel9.Controls.Add(AddBtn);
            panel9.Controls.Add(CancelBtn);
            panel9.Location = new Point(0, 1485);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(2537, 64);
            panel9.TabIndex = 3;
            // 
            // ClearAfterAddRBtn
            // 
            ClearAfterAddRBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearAfterAddRBtn.AutoSize = true;
            ClearAfterAddRBtn.Location = new Point(1632, 10);
            ClearAfterAddRBtn.Name = "ClearAfterAddRBtn";
            ClearAfterAddRBtn.RightToLeft = RightToLeft.Yes;
            ClearAfterAddRBtn.Size = new Size(249, 45);
            ClearAfterAddRBtn.TabIndex = 2;
            ClearAfterAddRBtn.TabStop = true;
            ClearAfterAddRBtn.Text = "Clear after add";
            ClearAfterAddRBtn.UseVisualStyleBackColor = true;
            ClearAfterAddRBtn.CheckedChanged += ClearAfterAddRBtn_CheckedChanged;
            // 
            // CloseAfterAddRBtn
            // 
            CloseAfterAddRBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseAfterAddRBtn.AutoSize = true;
            CloseAfterAddRBtn.Location = new Point(1887, 10);
            CloseAfterAddRBtn.Name = "CloseAfterAddRBtn";
            CloseAfterAddRBtn.RightToLeft = RightToLeft.Yes;
            CloseAfterAddRBtn.Size = new Size(255, 45);
            CloseAfterAddRBtn.TabIndex = 2;
            CloseAfterAddRBtn.TabStop = true;
            CloseAfterAddRBtn.Text = "Close after add";
            CloseAfterAddRBtn.UseVisualStyleBackColor = true;
            CloseAfterAddRBtn.CheckedChanged += CloseAfterAddRBtn_CheckedChanged;
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddBtn.Location = new Point(2342, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(188, 58);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CancelBtn.Location = new Point(2148, 3);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(188, 58);
            CancelBtn.TabIndex = 0;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AddQuestionUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "AddQuestionUserControl";
            Size = new Size(2537, 1549);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DurationHoursNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationSecondsNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationMinutesNUD).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderNUD).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ScoreNUD).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private RichTextBox TextRTB;
        private Label TextLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label ImageAddressLbl;
        private Button ImageBrowseBtn;
        private TextBox ImageAddressTB;
        private Panel panel6;
        private NumericUpDown ScoreNUD;
        private Label ScoreLbl;
        private Panel panel7;
        private NumericUpDown OrderNUD;
        private Label OrderLbl;
        private Panel panel4;
        private Label TypeLbl;
        private ComboBox TypeCB;
        private Panel panel5;
        private Label RemainingTimeValueLbl;
        private Label DurationLbl;
        private NumericUpDown DurationHoursNUD;
        private ProgressBar RemainingTimeValuePB;
        private Label RemainingTimeLbl;
        private NumericUpDown DurationSecondsNUD;
        private Label DurationSecondsLbl;
        private NumericUpDown DurationMinutesNUD;
        private Label DurationMinutesLbl;
        private Label DurationHoursLbl;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel9;
        private Button AddBtn;
        private Button CancelBtn;
        private RadioButton ClearAfterAddRBtn;
        private RadioButton CloseAfterAddRBtn;
    }
}
