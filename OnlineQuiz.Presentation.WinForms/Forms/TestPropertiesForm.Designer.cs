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
            CancelBtn = new Button();
            ApplyBtn = new Button();
            SaveBtn = new Button();
            DateTimeGB = new GroupBox();
            StartTimeDTP = new DateTimePicker();
            StartDateDTP = new DateTimePicker();
            StartDateTimeMessageLbl = new Label();
            EndDateTimeMessageLbl = new Label();
            StartTimeLbl = new Label();
            EndTimeDTP = new DateTimePicker();
            EndDateDTP = new DateTimePicker();
            EndTimeLbl = new Label();
            StartDateLbl = new Label();
            EndDateLbl = new Label();
            PickDateTimeCkB = new CheckBox();
            RandomizeTypeCB = new ComboBox();
            RandomizeTypeLbl = new Label();
            RandomizeTypeMessageLbl = new Label();
            TitleMessageLbl = new Label();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            PublishCkB = new CheckBox();
            DateTimeGB.SuspendLayout();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(361, 820);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(188, 58);
            CancelBtn.TabIndex = 20;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Location = new Point(555, 820);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(188, 58);
            ApplyBtn.TabIndex = 19;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(749, 820);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(188, 58);
            SaveBtn.TabIndex = 22;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // DateTimeGB
            // 
            DateTimeGB.Controls.Add(StartTimeDTP);
            DateTimeGB.Controls.Add(StartDateDTP);
            DateTimeGB.Controls.Add(StartDateTimeMessageLbl);
            DateTimeGB.Controls.Add(EndDateTimeMessageLbl);
            DateTimeGB.Controls.Add(StartTimeLbl);
            DateTimeGB.Controls.Add(EndTimeDTP);
            DateTimeGB.Controls.Add(EndDateDTP);
            DateTimeGB.Controls.Add(EndTimeLbl);
            DateTimeGB.Controls.Add(StartDateLbl);
            DateTimeGB.Controls.Add(EndDateLbl);
            DateTimeGB.Enabled = false;
            DateTimeGB.Location = new Point(57, 325);
            DateTimeGB.Name = "DateTimeGB";
            DateTimeGB.Size = new Size(835, 389);
            DateTimeGB.TabIndex = 33;
            DateTimeGB.TabStop = false;
            DateTimeGB.Text = "Date and Time";
            // 
            // StartTimeDTP
            // 
            StartTimeDTP.Format = DateTimePickerFormat.Time;
            StartTimeDTP.Location = new Point(236, 114);
            StartTimeDTP.Name = "StartTimeDTP";
            StartTimeDTP.ShowUpDown = true;
            StartTimeDTP.Size = new Size(266, 47);
            StartTimeDTP.TabIndex = 16;
            StartTimeDTP.Value = new DateTime(2023, 4, 4, 16, 57, 17, 0);
            // 
            // StartDateDTP
            // 
            StartDateDTP.Location = new Point(236, 61);
            StartDateDTP.Name = "StartDateDTP";
            StartDateDTP.Size = new Size(500, 47);
            StartDateDTP.TabIndex = 16;
            StartDateDTP.Value = new DateTime(2023, 4, 4, 1, 12, 0, 0);
            // 
            // StartDateTimeMessageLbl
            // 
            StartDateTimeMessageLbl.AutoSize = true;
            StartDateTimeMessageLbl.Location = new Point(236, 164);
            StartDateTimeMessageLbl.Name = "StartDateTimeMessageLbl";
            StartDateTimeMessageLbl.Size = new Size(90, 41);
            StartDateTimeMessageLbl.TabIndex = 13;
            StartDateTimeMessageLbl.Text = "blank";
            // 
            // EndDateTimeMessageLbl
            // 
            EndDateTimeMessageLbl.AutoSize = true;
            EndDateTimeMessageLbl.Location = new Point(236, 328);
            EndDateTimeMessageLbl.Name = "EndDateTimeMessageLbl";
            EndDateTimeMessageLbl.Size = new Size(90, 41);
            EndDateTimeMessageLbl.TabIndex = 13;
            EndDateTimeMessageLbl.Text = "blank";
            // 
            // StartTimeLbl
            // 
            StartTimeLbl.AutoSize = true;
            StartTimeLbl.Location = new Point(79, 119);
            StartTimeLbl.Name = "StartTimeLbl";
            StartTimeLbl.Size = new Size(151, 41);
            StartTimeLbl.TabIndex = 17;
            StartTimeLbl.Text = "Start Time";
            // 
            // EndTimeDTP
            // 
            EndTimeDTP.Format = DateTimePickerFormat.Time;
            EndTimeDTP.Location = new Point(236, 278);
            EndTimeDTP.Name = "EndTimeDTP";
            EndTimeDTP.ShowUpDown = true;
            EndTimeDTP.Size = new Size(266, 47);
            EndTimeDTP.TabIndex = 16;
            EndTimeDTP.Value = new DateTime(2023, 4, 4, 16, 57, 11, 0);
            // 
            // EndDateDTP
            // 
            EndDateDTP.Location = new Point(236, 225);
            EndDateDTP.Name = "EndDateDTP";
            EndDateDTP.Size = new Size(500, 47);
            EndDateDTP.TabIndex = 16;
            // 
            // EndTimeLbl
            // 
            EndTimeLbl.AutoSize = true;
            EndTimeLbl.Location = new Point(79, 283);
            EndTimeLbl.Name = "EndTimeLbl";
            EndTimeLbl.Size = new Size(141, 41);
            EndTimeLbl.TabIndex = 17;
            EndTimeLbl.Text = "End Time";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Location = new Point(79, 61);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Size = new Size(148, 41);
            StartDateLbl.TabIndex = 17;
            StartDateLbl.Text = "Start Date";
            // 
            // EndDateLbl
            // 
            EndDateLbl.AutoSize = true;
            EndDateLbl.Location = new Point(79, 230);
            EndDateLbl.Name = "EndDateLbl";
            EndDateLbl.Size = new Size(138, 41);
            EndDateLbl.TabIndex = 17;
            EndDateLbl.Text = "End Date";
            // 
            // PickDateTimeCkB
            // 
            PickDateTimeCkB.AutoSize = true;
            PickDateTimeCkB.Location = new Point(293, 274);
            PickDateTimeCkB.Name = "PickDateTimeCkB";
            PickDateTimeCkB.Size = new Size(310, 45);
            PickDateTimeCkB.TabIndex = 32;
            PickDateTimeCkB.Text = "Pick Date and Time";
            PickDateTimeCkB.UseVisualStyleBackColor = true;
            PickDateTimeCkB.CheckStateChanged += PickDateTimeCkB_CheckStateChanged;
            // 
            // RandomizeTypeCB
            // 
            RandomizeTypeCB.FormattingEnabled = true;
            RandomizeTypeCB.Items.AddRange(new object[] { "Follow sections setting", "Random all sections", "Random when  time is compatible" });
            RandomizeTypeCB.Location = new Point(293, 156);
            RandomizeTypeCB.Name = "RandomizeTypeCB";
            RandomizeTypeCB.Size = new Size(569, 49);
            RandomizeTypeCB.TabIndex = 29;
            RandomizeTypeCB.SelectedIndexChanged += RandomizeTypeCB_SelectedIndexChanged;
            // 
            // RandomizeTypeLbl
            // 
            RandomizeTypeLbl.AutoSize = true;
            RandomizeTypeLbl.Location = new Point(57, 159);
            RandomizeTypeLbl.Name = "RandomizeTypeLbl";
            RandomizeTypeLbl.Size = new Size(230, 41);
            RandomizeTypeLbl.TabIndex = 28;
            RandomizeTypeLbl.Text = "RandomizeType";
            // 
            // RandomizeTypeMessageLbl
            // 
            RandomizeTypeMessageLbl.AutoSize = true;
            RandomizeTypeMessageLbl.Location = new Point(64, 212);
            RandomizeTypeMessageLbl.Name = "RandomizeTypeMessageLbl";
            RandomizeTypeMessageLbl.Size = new Size(90, 41);
            RandomizeTypeMessageLbl.TabIndex = 26;
            RandomizeTypeMessageLbl.Text = "blank";
            // 
            // TitleMessageLbl
            // 
            TitleMessageLbl.AutoSize = true;
            TitleMessageLbl.Location = new Point(293, 101);
            TitleMessageLbl.Name = "TitleMessageLbl";
            TitleMessageLbl.Size = new Size(90, 41);
            TitleMessageLbl.TabIndex = 27;
            TitleMessageLbl.Text = "blank";
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(293, 51);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(569, 47);
            TitleTB.TabIndex = 24;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(64, 54);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 23;
            TitleLbl.Text = "Title";
            // 
            // PublishCkB
            // 
            PublishCkB.AutoSize = true;
            PublishCkB.Location = new Point(293, 728);
            PublishCkB.Name = "PublishCkB";
            PublishCkB.Size = new Size(152, 45);
            PublishCkB.TabIndex = 25;
            PublishCkB.Text = "Publish";
            PublishCkB.UseVisualStyleBackColor = true;
            // 
            // TestPropertiesForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 892);
            Controls.Add(DateTimeGB);
            Controls.Add(PickDateTimeCkB);
            Controls.Add(RandomizeTypeCB);
            Controls.Add(RandomizeTypeLbl);
            Controls.Add(RandomizeTypeMessageLbl);
            Controls.Add(TitleMessageLbl);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Controls.Add(PublishCkB);
            Controls.Add(SaveBtn);
            Controls.Add(CancelBtn);
            Controls.Add(ApplyBtn);
            Name = "TestPropertiesForm";
            Text = "Test Properties";
            DateTimeGB.ResumeLayout(false);
            DateTimeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelBtn;
        private Button ApplyBtn;
        private Button SaveBtn;
        private GroupBox DateTimeGB;
        private DateTimePicker StartTimeDTP;
        private DateTimePicker StartDateDTP;
        private Label StartDateTimeMessageLbl;
        private Label EndDateTimeMessageLbl;
        private Label StartTimeLbl;
        private DateTimePicker EndTimeDTP;
        private DateTimePicker EndDateDTP;
        private Label EndTimeLbl;
        private Label StartDateLbl;
        private Label EndDateLbl;
        private CheckBox PickDateTimeCkB;
        private ComboBox RandomizeTypeCB;
        private Label RandomizeTypeLbl;
        private Label RandomizeTypeMessageLbl;
        private Label TitleMessageLbl;
        private TextBox TitleTB;
        private Label TitleLbl;
        private CheckBox PublishCkB;
    }
}