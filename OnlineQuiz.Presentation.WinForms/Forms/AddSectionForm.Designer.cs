namespace OnlineQuiz.Presentation.WinForms
{
    partial class AddSectionForm
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
            TestGB = new GroupBox();
            TestRandomizeTypeValueLbl = new Label();
            TestPublishedValueLbl = new Label();
            TestRandomizeTypeLbl = new Label();
            TestPublishedLbl = new Label();
            TestEndDateTimeValueLbl = new Label();
            TestEndDateTimeLbl = new Label();
            TestStartDateTimeValueLbl = new Label();
            TestStartDateTimeLbl = new Label();
            TestTittleValueLbl = new Label();
            TestTitleLbl = new Label();
            SectionGB = new GroupBox();
            DurationGB = new GroupBox();
            DurationHoursNUD = new NumericUpDown();
            DurationSecondsLbl = new Label();
            DurationLbl = new Label();
            DurationMinutesLbl = new Label();
            DurationMessageLbl = new Label();
            DurationSecondsNUD = new NumericUpDown();
            DurationHoursLbl = new Label();
            RemainingTimeLbl = new Label();
            RemainingTimeValuePB = new ProgressBar();
            DurationMinutesNUD = new NumericUpDown();
            AttemptLimitNUD = new NumericUpDown();
            OrderNUD = new NumericUpDown();
            AllowEditCkB = new CheckBox();
            DisplayResultCkB = new CheckBox();
            TitleMessageLbl = new Label();
            RandomizeQuestionsCkB = new CheckBox();
            OrderMessageLbl = new Label();
            TitleTB = new TextBox();
            AttemptLimitLbl = new Label();
            OrderLbl = new Label();
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
            TitleLbl = new Label();
            ClearFormBtn = new Button();
            CancelBtn = new Button();
            AddBtn = new Button();
            AfterAddLbl = new Label();
            AfterAddCB = new ComboBox();
            RemainingTimeValueLbl = new Label();
            TestGB.SuspendLayout();
            SectionGB.SuspendLayout();
            DurationGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DurationHoursNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationSecondsNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DurationMinutesNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttemptLimitNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderNUD).BeginInit();
            DateTimeGB.SuspendLayout();
            SuspendLayout();
            // 
            // TestGB
            // 
            TestGB.Controls.Add(TestRandomizeTypeValueLbl);
            TestGB.Controls.Add(TestPublishedValueLbl);
            TestGB.Controls.Add(TestRandomizeTypeLbl);
            TestGB.Controls.Add(TestPublishedLbl);
            TestGB.Controls.Add(TestEndDateTimeValueLbl);
            TestGB.Controls.Add(TestEndDateTimeLbl);
            TestGB.Controls.Add(TestStartDateTimeValueLbl);
            TestGB.Controls.Add(TestStartDateTimeLbl);
            TestGB.Controls.Add(TestTittleValueLbl);
            TestGB.Controls.Add(TestTitleLbl);
            TestGB.Location = new Point(12, 12);
            TestGB.Name = "TestGB";
            TestGB.Size = new Size(948, 260);
            TestGB.TabIndex = 0;
            TestGB.TabStop = false;
            TestGB.Text = "Test info";
            // 
            // TestRandomizeTypeValueLbl
            // 
            TestRandomizeTypeValueLbl.AutoSize = true;
            TestRandomizeTypeValueLbl.Location = new Point(257, 207);
            TestRandomizeTypeValueLbl.Name = "TestRandomizeTypeValueLbl";
            TestRandomizeTypeValueLbl.Size = new Size(393, 41);
            TestRandomizeTypeValueLbl.TabIndex = 4;
            TestRandomizeTypeValueLbl.Text = "TestRandomizeTypeValueLbl";
            // 
            // TestPublishedValueLbl
            // 
            TestPublishedValueLbl.AutoSize = true;
            TestPublishedValueLbl.Location = new Point(257, 166);
            TestPublishedValueLbl.Name = "TestPublishedValueLbl";
            TestPublishedValueLbl.Size = new Size(311, 41);
            TestPublishedValueLbl.TabIndex = 4;
            TestPublishedValueLbl.Text = "TestPublishedValueLbl";
            // 
            // TestRandomizeTypeLbl
            // 
            TestRandomizeTypeLbl.AutoSize = true;
            TestRandomizeTypeLbl.Location = new Point(6, 207);
            TestRandomizeTypeLbl.Name = "TestRandomizeTypeLbl";
            TestRandomizeTypeLbl.Size = new Size(245, 41);
            TestRandomizeTypeLbl.TabIndex = 3;
            TestRandomizeTypeLbl.Text = "Randomize Type:";
            // 
            // TestPublishedLbl
            // 
            TestPublishedLbl.AutoSize = true;
            TestPublishedLbl.Location = new Point(6, 166);
            TestPublishedLbl.Name = "TestPublishedLbl";
            TestPublishedLbl.Size = new Size(155, 41);
            TestPublishedLbl.TabIndex = 3;
            TestPublishedLbl.Text = "Published:";
            // 
            // TestEndDateTimeValueLbl
            // 
            TestEndDateTimeValueLbl.AutoSize = true;
            TestEndDateTimeValueLbl.Location = new Point(257, 125);
            TestEndDateTimeValueLbl.Name = "TestEndDateTimeValueLbl";
            TestEndDateTimeValueLbl.Size = new Size(358, 41);
            TestEndDateTimeValueLbl.TabIndex = 2;
            TestEndDateTimeValueLbl.Text = "TestEndDateTimeValueLbl";
            // 
            // TestEndDateTimeLbl
            // 
            TestEndDateTimeLbl.AutoSize = true;
            TestEndDateTimeLbl.Location = new Point(6, 125);
            TestEndDateTimeLbl.Name = "TestEndDateTimeLbl";
            TestEndDateTimeLbl.Size = new Size(209, 41);
            TestEndDateTimeLbl.TabIndex = 2;
            TestEndDateTimeLbl.Text = "End date time:";
            // 
            // TestStartDateTimeValueLbl
            // 
            TestStartDateTimeValueLbl.AutoSize = true;
            TestStartDateTimeValueLbl.Location = new Point(257, 84);
            TestStartDateTimeValueLbl.Name = "TestStartDateTimeValueLbl";
            TestStartDateTimeValueLbl.Size = new Size(368, 41);
            TestStartDateTimeValueLbl.TabIndex = 2;
            TestStartDateTimeValueLbl.Text = "TestStartDateTimeValueLbl";
            // 
            // TestStartDateTimeLbl
            // 
            TestStartDateTimeLbl.AutoSize = true;
            TestStartDateTimeLbl.Location = new Point(6, 84);
            TestStartDateTimeLbl.Name = "TestStartDateTimeLbl";
            TestStartDateTimeLbl.Size = new Size(219, 41);
            TestStartDateTimeLbl.TabIndex = 2;
            TestStartDateTimeLbl.Text = "Start date time:";
            // 
            // TestTittleValueLbl
            // 
            TestTittleValueLbl.AutoSize = true;
            TestTittleValueLbl.Location = new Point(257, 43);
            TestTittleValueLbl.Name = "TestTittleValueLbl";
            TestTittleValueLbl.Size = new Size(247, 41);
            TestTittleValueLbl.TabIndex = 1;
            TestTittleValueLbl.Text = "TestTittleValueLbl";
            // 
            // TestTitleLbl
            // 
            TestTitleLbl.AutoSize = true;
            TestTitleLbl.Location = new Point(6, 43);
            TestTitleLbl.Name = "TestTitleLbl";
            TestTitleLbl.Size = new Size(81, 41);
            TestTitleLbl.TabIndex = 0;
            TestTitleLbl.Text = "Title:";
            // 
            // SectionGB
            // 
            SectionGB.Controls.Add(DurationGB);
            SectionGB.Controls.Add(AttemptLimitNUD);
            SectionGB.Controls.Add(OrderNUD);
            SectionGB.Controls.Add(AllowEditCkB);
            SectionGB.Controls.Add(DisplayResultCkB);
            SectionGB.Controls.Add(TitleMessageLbl);
            SectionGB.Controls.Add(RandomizeQuestionsCkB);
            SectionGB.Controls.Add(OrderMessageLbl);
            SectionGB.Controls.Add(TitleTB);
            SectionGB.Controls.Add(AttemptLimitLbl);
            SectionGB.Controls.Add(OrderLbl);
            SectionGB.Controls.Add(DateTimeGB);
            SectionGB.Controls.Add(TitleLbl);
            SectionGB.Location = new Point(12, 278);
            SectionGB.Name = "SectionGB";
            SectionGB.Size = new Size(948, 953);
            SectionGB.TabIndex = 1;
            SectionGB.TabStop = false;
            SectionGB.Text = "Section";
            // 
            // DurationGB
            // 
            DurationGB.Controls.Add(RemainingTimeValueLbl);
            DurationGB.Controls.Add(DurationHoursNUD);
            DurationGB.Controls.Add(DurationSecondsLbl);
            DurationGB.Controls.Add(DurationLbl);
            DurationGB.Controls.Add(DurationMinutesLbl);
            DurationGB.Controls.Add(DurationMessageLbl);
            DurationGB.Controls.Add(DurationSecondsNUD);
            DurationGB.Controls.Add(DurationHoursLbl);
            DurationGB.Controls.Add(RemainingTimeLbl);
            DurationGB.Controls.Add(RemainingTimeValuePB);
            DurationGB.Controls.Add(DurationMinutesNUD);
            DurationGB.Location = new Point(6, 492);
            DurationGB.Name = "DurationGB";
            DurationGB.Size = new Size(936, 198);
            DurationGB.TabIndex = 36;
            DurationGB.TabStop = false;
            DurationGB.Text = "Duration";
            // 
            // DurationHoursNUD
            // 
            DurationHoursNUD.Location = new Point(257, 44);
            DurationHoursNUD.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            DurationHoursNUD.Name = "DurationHoursNUD";
            DurationHoursNUD.Size = new Size(81, 47);
            DurationHoursNUD.TabIndex = 34;
            DurationHoursNUD.ValueChanged += Duration_ValueChanged;
            // 
            // DurationSecondsLbl
            // 
            DurationSecondsLbl.AutoSize = true;
            DurationSecondsLbl.Location = new Point(614, 46);
            DurationSecondsLbl.Name = "DurationSecondsLbl";
            DurationSecondsLbl.Size = new Size(34, 41);
            DurationSecondsLbl.TabIndex = 18;
            DurationSecondsLbl.Text = "S";
            // 
            // DurationLbl
            // 
            DurationLbl.AutoSize = true;
            DurationLbl.Location = new Point(87, 43);
            DurationLbl.Name = "DurationLbl";
            DurationLbl.Size = new Size(133, 41);
            DurationLbl.TabIndex = 24;
            DurationLbl.Text = "Duration";
            // 
            // DurationMinutesLbl
            // 
            DurationMinutesLbl.AutoSize = true;
            DurationMinutesLbl.Location = new Point(476, 46);
            DurationMinutesLbl.Name = "DurationMinutesLbl";
            DurationMinutesLbl.Size = new Size(45, 41);
            DurationMinutesLbl.TabIndex = 18;
            DurationMinutesLbl.Text = "M";
            // 
            // DurationMessageLbl
            // 
            DurationMessageLbl.AutoSize = true;
            DurationMessageLbl.Location = new Point(257, 144);
            DurationMessageLbl.Name = "DurationMessageLbl";
            DurationMessageLbl.Size = new Size(290, 41);
            DurationMessageLbl.TabIndex = 13;
            DurationMessageLbl.Text = "DurationMessageLbl";
            // 
            // DurationSecondsNUD
            // 
            DurationSecondsNUD.Location = new Point(527, 44);
            DurationSecondsNUD.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            DurationSecondsNUD.Name = "DurationSecondsNUD";
            DurationSecondsNUD.Size = new Size(81, 47);
            DurationSecondsNUD.TabIndex = 34;
            DurationSecondsNUD.ValueChanged += Duration_ValueChanged;
            // 
            // DurationHoursLbl
            // 
            DurationHoursLbl.AutoSize = true;
            DurationHoursLbl.Location = new Point(344, 46);
            DurationHoursLbl.Name = "DurationHoursLbl";
            DurationHoursLbl.Size = new Size(39, 41);
            DurationHoursLbl.TabIndex = 18;
            DurationHoursLbl.Text = "H";
            // 
            // RemainingTimeLbl
            // 
            RemainingTimeLbl.AutoSize = true;
            RemainingTimeLbl.Location = new Point(6, 100);
            RemainingTimeLbl.Name = "RemainingTimeLbl";
            RemainingTimeLbl.Size = new Size(238, 41);
            RemainingTimeLbl.TabIndex = 13;
            RemainingTimeLbl.Text = "Remaining Time:";
            // 
            // RemainingTimeValuePB
            // 
            RemainingTimeValuePB.Location = new Point(257, 94);
            RemainingTimeValuePB.Name = "RemainingTimeValuePB";
            RemainingTimeValuePB.Size = new Size(266, 47);
            RemainingTimeValuePB.TabIndex = 35;
            // 
            // DurationMinutesNUD
            // 
            DurationMinutesNUD.Location = new Point(389, 44);
            DurationMinutesNUD.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            DurationMinutesNUD.Name = "DurationMinutesNUD";
            DurationMinutesNUD.Size = new Size(81, 47);
            DurationMinutesNUD.TabIndex = 34;
            DurationMinutesNUD.ValueChanged += Duration_ValueChanged;
            // 
            // AttemptLimitNUD
            // 
            AttemptLimitNUD.Location = new Point(263, 749);
            AttemptLimitNUD.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            AttemptLimitNUD.Name = "AttemptLimitNUD";
            AttemptLimitNUD.Size = new Size(266, 47);
            AttemptLimitNUD.TabIndex = 34;
            // 
            // OrderNUD
            // 
            OrderNUD.Location = new Point(263, 696);
            OrderNUD.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            OrderNUD.Name = "OrderNUD";
            OrderNUD.Size = new Size(266, 47);
            OrderNUD.TabIndex = 34;
            // 
            // AllowEditCkB
            // 
            AllowEditCkB.AutoSize = true;
            AllowEditCkB.Location = new Point(263, 904);
            AllowEditCkB.Name = "AllowEditCkB";
            AllowEditCkB.Size = new Size(179, 45);
            AllowEditCkB.TabIndex = 33;
            AllowEditCkB.Text = "AllowEdit";
            AllowEditCkB.UseVisualStyleBackColor = true;
            // 
            // DisplayResultCkB
            // 
            DisplayResultCkB.AutoSize = true;
            DisplayResultCkB.Location = new Point(263, 853);
            DisplayResultCkB.Name = "DisplayResultCkB";
            DisplayResultCkB.Size = new Size(240, 45);
            DisplayResultCkB.TabIndex = 33;
            DisplayResultCkB.Text = "Display Result";
            DisplayResultCkB.UseVisualStyleBackColor = true;
            // 
            // TitleMessageLbl
            // 
            TitleMessageLbl.AutoSize = true;
            TitleMessageLbl.Location = new Point(257, 93);
            TitleMessageLbl.Name = "TitleMessageLbl";
            TitleMessageLbl.Size = new Size(231, 41);
            TitleMessageLbl.TabIndex = 13;
            TitleMessageLbl.Text = "TitleMessageLbl";
            // 
            // RandomizeQuestionsCkB
            // 
            RandomizeQuestionsCkB.AutoSize = true;
            RandomizeQuestionsCkB.Location = new Point(263, 802);
            RandomizeQuestionsCkB.Name = "RandomizeQuestionsCkB";
            RandomizeQuestionsCkB.Size = new Size(347, 45);
            RandomizeQuestionsCkB.TabIndex = 32;
            RandomizeQuestionsCkB.Text = "Randomize Questions";
            RandomizeQuestionsCkB.UseVisualStyleBackColor = true;
            // 
            // OrderMessageLbl
            // 
            OrderMessageLbl.AutoSize = true;
            OrderMessageLbl.Location = new Point(535, 702);
            OrderMessageLbl.Name = "OrderMessageLbl";
            OrderMessageLbl.Size = new Size(252, 41);
            OrderMessageLbl.TabIndex = 13;
            OrderMessageLbl.Text = "OrderMessageLbl";
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(257, 43);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(583, 47);
            TitleTB.TabIndex = 30;
            // 
            // AttemptLimitLbl
            // 
            AttemptLimitLbl.AutoSize = true;
            AttemptLimitLbl.Location = new Point(12, 746);
            AttemptLimitLbl.Name = "AttemptLimitLbl";
            AttemptLimitLbl.Size = new Size(192, 41);
            AttemptLimitLbl.TabIndex = 26;
            AttemptLimitLbl.Text = "Attempt limit";
            // 
            // OrderLbl
            // 
            OrderLbl.AutoSize = true;
            OrderLbl.Location = new Point(12, 699);
            OrderLbl.Name = "OrderLbl";
            OrderLbl.Size = new Size(95, 41);
            OrderLbl.TabIndex = 25;
            OrderLbl.Text = "Order";
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
            DateTimeGB.Location = new Point(6, 134);
            DateTimeGB.Name = "DateTimeGB";
            DateTimeGB.Size = new Size(936, 352);
            DateTimeGB.TabIndex = 23;
            DateTimeGB.TabStop = false;
            DateTimeGB.Text = "Date and Time";
            // 
            // StartTimeDTP
            // 
            StartTimeDTP.Format = DateTimePickerFormat.Time;
            StartTimeDTP.Location = new Point(251, 90);
            StartTimeDTP.Name = "StartTimeDTP";
            StartTimeDTP.ShowUpDown = true;
            StartTimeDTP.Size = new Size(266, 47);
            StartTimeDTP.TabIndex = 16;
            StartTimeDTP.Value = new DateTime(2023, 4, 4, 16, 57, 17, 0);
            // 
            // StartDateDTP
            // 
            StartDateDTP.Location = new Point(251, 38);
            StartDateDTP.Name = "StartDateDTP";
            StartDateDTP.Size = new Size(500, 47);
            StartDateDTP.TabIndex = 16;
            StartDateDTP.Value = new DateTime(2023, 4, 10, 0, 0, 0, 0);
            // 
            // StartDateTimeMessageLbl
            // 
            StartDateTimeMessageLbl.AutoSize = true;
            StartDateTimeMessageLbl.Location = new Point(251, 140);
            StartDateTimeMessageLbl.Name = "StartDateTimeMessageLbl";
            StartDateTimeMessageLbl.Size = new Size(362, 41);
            StartDateTimeMessageLbl.TabIndex = 13;
            StartDateTimeMessageLbl.Text = "StartDateTimeMessageLbl";
            // 
            // EndDateTimeMessageLbl
            // 
            EndDateTimeMessageLbl.AutoSize = true;
            EndDateTimeMessageLbl.Location = new Point(251, 301);
            EndDateTimeMessageLbl.Name = "EndDateTimeMessageLbl";
            EndDateTimeMessageLbl.Size = new Size(352, 41);
            EndDateTimeMessageLbl.TabIndex = 13;
            EndDateTimeMessageLbl.Text = "EndDateTimeMessageLbl";
            // 
            // StartTimeLbl
            // 
            StartTimeLbl.AutoSize = true;
            StartTimeLbl.Location = new Point(93, 96);
            StartTimeLbl.Name = "StartTimeLbl";
            StartTimeLbl.Size = new Size(151, 41);
            StartTimeLbl.TabIndex = 17;
            StartTimeLbl.Text = "Start Time";
            // 
            // EndTimeDTP
            // 
            EndTimeDTP.Format = DateTimePickerFormat.Time;
            EndTimeDTP.Location = new Point(251, 251);
            EndTimeDTP.Name = "EndTimeDTP";
            EndTimeDTP.ShowUpDown = true;
            EndTimeDTP.Size = new Size(266, 47);
            EndTimeDTP.TabIndex = 16;
            EndTimeDTP.Value = new DateTime(2023, 4, 4, 16, 57, 11, 0);
            // 
            // EndDateDTP
            // 
            EndDateDTP.Location = new Point(251, 198);
            EndDateDTP.Name = "EndDateDTP";
            EndDateDTP.Size = new Size(500, 47);
            EndDateDTP.TabIndex = 16;
            // 
            // EndTimeLbl
            // 
            EndTimeLbl.AutoSize = true;
            EndTimeLbl.Location = new Point(87, 257);
            EndTimeLbl.Name = "EndTimeLbl";
            EndTimeLbl.Size = new Size(141, 41);
            EndTimeLbl.TabIndex = 17;
            EndTimeLbl.Text = "End Time";
            // 
            // StartDateLbl
            // 
            StartDateLbl.AutoSize = true;
            StartDateLbl.Location = new Point(93, 43);
            StartDateLbl.Name = "StartDateLbl";
            StartDateLbl.Size = new Size(148, 41);
            StartDateLbl.TabIndex = 17;
            StartDateLbl.Text = "Start Date";
            // 
            // EndDateLbl
            // 
            EndDateLbl.AutoSize = true;
            EndDateLbl.Location = new Point(87, 204);
            EndDateLbl.Name = "EndDateLbl";
            EndDateLbl.Size = new Size(138, 41);
            EndDateLbl.TabIndex = 17;
            EndDateLbl.Text = "End Date";
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(6, 43);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "Title";
            // 
            // ClearFormBtn
            // 
            ClearFormBtn.Location = new Point(387, 1336);
            ClearFormBtn.Name = "ClearFormBtn";
            ClearFormBtn.Size = new Size(188, 58);
            ClearFormBtn.TabIndex = 15;
            ClearFormBtn.Text = "Clear Form";
            ClearFormBtn.UseVisualStyleBackColor = true;
            ClearFormBtn.Click += ClearFormBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(581, 1336);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(188, 58);
            CancelBtn.TabIndex = 14;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(775, 1336);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(188, 58);
            AddBtn.TabIndex = 13;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // AfterAddLbl
            // 
            AfterAddLbl.AutoSize = true;
            AfterAddLbl.Location = new Point(40, 1251);
            AfterAddLbl.Name = "AfterAddLbl";
            AfterAddLbl.Size = new Size(152, 41);
            AfterAddLbl.TabIndex = 21;
            AfterAddLbl.Text = "After Add:";
            // 
            // AfterAddCB
            // 
            AfterAddCB.FormattingEnabled = true;
            AfterAddCB.Location = new Point(263, 1248);
            AfterAddCB.Name = "AfterAddCB";
            AfterAddCB.Size = new Size(302, 49);
            AfterAddCB.TabIndex = 22;
            // 
            // RemainingTimeValueLbl
            // 
            RemainingTimeValueLbl.AutoSize = true;
            RemainingTimeValueLbl.Location = new Point(529, 100);
            RemainingTimeValueLbl.Name = "RemainingTimeValueLbl";
            RemainingTimeValueLbl.Size = new Size(334, 41);
            RemainingTimeValueLbl.TabIndex = 37;
            RemainingTimeValueLbl.Text = "RemainingTimeValueLbl";
            // 
            // AddSectionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 1406);
            Controls.Add(AfterAddCB);
            Controls.Add(AfterAddLbl);
            Controls.Add(ClearFormBtn);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(SectionGB);
            Controls.Add(TestGB);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddSectionForm";
            Text = "AddSectionForm";
            TestGB.ResumeLayout(false);
            TestGB.PerformLayout();
            SectionGB.ResumeLayout(false);
            SectionGB.PerformLayout();
            DurationGB.ResumeLayout(false);
            DurationGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DurationHoursNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationSecondsNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)DurationMinutesNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttemptLimitNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderNUD).EndInit();
            DateTimeGB.ResumeLayout(false);
            DateTimeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox TestGB;
        private Label TestTitleLbl;
        private Label TestPublishedValueLbl;
        private Label TestPublishedLbl;
        private Label TestEndDateTimeValueLbl;
        private Label TestEndDateTimeLbl;
        private Label TestStartDateTimeValueLbl;
        private Label TestStartDateTimeLbl;
        private Label TestTittleValueLbl;
        private GroupBox SectionGB;
        private Label TitleLbl;
        private Label DurationLbl;
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
        private Label AttemptLimitLbl;
        private Label OrderLbl;
        private CheckBox AllowEditCkB;
        private CheckBox DisplayResultCkB;
        private CheckBox RandomizeQuestionsCkB;
        private Label OrderMessageLbl;
        private Label DurationMessageLbl;
        private TextBox TitleTB;
        private Label TitleMessageLbl;
        private Button ClearFormBtn;
        private Button CancelBtn;
        private Button AddBtn;
        private NumericUpDown AttemptLimitNUD;
        private NumericUpDown OrderNUD;
        private Label DurationSecondsLbl;
        private Label DurationMinutesLbl;
        private NumericUpDown DurationSecondsNUD;
        private Label DurationHoursLbl;
        private ProgressBar RemainingTimeValuePB;
        private NumericUpDown DurationHoursNUD;
        private NumericUpDown DurationMinutesNUD;
        private Label TestRandomizeTypeValueLbl;
        private Label TestRandomizeTypeLbl;
        private Label RemainingTimeLbl;
        private GroupBox DurationGB;
        private Label AfterAddLbl;
        private ComboBox AfterAddCB;
        private Label RemainingTimeValueLbl;
    }
}