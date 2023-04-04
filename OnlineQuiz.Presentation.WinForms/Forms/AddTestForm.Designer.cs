

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
            PublishCkB = new CheckBox();
            TitleTB = new TextBox();
            TitleLbl = new Label();
            AddBtn = new Button();
            CancelBtn = new Button();
            TitleMessageLbl = new Label();
            RandomizeTypeLbl = new Label();
            RandomizeTypeCB = new ComboBox();
            StartDateDTP = new DateTimePicker();
            StartDateLbl = new Label();
            EndDateDTP = new DateTimePicker();
            EndDateLbl = new Label();
            RandomizeTypeMessageLbl = new Label();
            StartDateTimeMessageLbl = new Label();
            EndDateTimeMessageLbl = new Label();
            AfterAddLbl = new Label();
            CloseFormCkB = new CheckBox();
            OpenInTestExplorerCkB = new CheckBox();
            DateTimeGB = new GroupBox();
            StartTimeDTP = new DateTimePicker();
            StartTimeLbl = new Label();
            EndTimeDTP = new DateTimePicker();
            EndTimeLbl = new Label();
            PickDateTimeCkB = new CheckBox();
            ClearFormBtn = new Button();
            DateTimeGB.SuspendLayout();
            SuspendLayout();
            // 
            // PublishCkB
            // 
            PublishCkB.AutoSize = true;
            PublishCkB.Location = new Point(303, 735);
            PublishCkB.Name = "PublishCkB";
            PublishCkB.Size = new Size(152, 45);
            PublishCkB.TabIndex = 10;
            PublishCkB.Text = "Publish";
            PublishCkB.UseVisualStyleBackColor = true;
            // 
            // TitleTB
            // 
            TitleTB.Location = new Point(303, 58);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(569, 47);
            TitleTB.TabIndex = 8;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Location = new Point(74, 61);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(74, 41);
            TitleLbl.TabIndex = 7;
            TitleLbl.Text = "Title";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(797, 874);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(188, 58);
            AddBtn.TabIndex = 11;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(603, 874);
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
            TitleMessageLbl.Location = new Point(303, 108);
            TitleMessageLbl.Name = "TitleMessageLbl";
            TitleMessageLbl.Size = new Size(90, 41);
            TitleMessageLbl.TabIndex = 13;
            TitleMessageLbl.Text = "blank";
            // 
            // RandomizeTypeLbl
            // 
            RandomizeTypeLbl.AutoSize = true;
            RandomizeTypeLbl.Location = new Point(67, 166);
            RandomizeTypeLbl.Name = "RandomizeTypeLbl";
            RandomizeTypeLbl.Size = new Size(230, 41);
            RandomizeTypeLbl.TabIndex = 14;
            RandomizeTypeLbl.Text = "RandomizeType";
            // 
            // RandomizeTypeCB
            // 
            RandomizeTypeCB.FormattingEnabled = true;
            RandomizeTypeCB.Items.AddRange(new object[] { "Follow sections setting", "Random all sections", "Random when  time is compatible" });
            RandomizeTypeCB.Location = new Point(303, 163);
            RandomizeTypeCB.Name = "RandomizeTypeCB";
            RandomizeTypeCB.Size = new Size(569, 49);
            RandomizeTypeCB.TabIndex = 15;
            RandomizeTypeCB.SelectedIndexChanged += RandomizeTypeCB_SelectedIndexChanged;
            // 
            // StartDateDTP
            // 
            StartDateDTP.Location = new Point(236, 61);
            StartDateDTP.Name = "StartDateDTP";
            StartDateDTP.Size = new Size(500, 47);
            StartDateDTP.TabIndex = 16;
            StartDateDTP.Value = new DateTime(2023, 4, 4, 1, 12, 0, 0);
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
            // EndDateDTP
            // 
            EndDateDTP.Location = new Point(236, 225);
            EndDateDTP.Name = "EndDateDTP";
            EndDateDTP.Size = new Size(500, 47);
            EndDateDTP.TabIndex = 16;
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
            // RandomizeTypeMessageLbl
            // 
            RandomizeTypeMessageLbl.AutoSize = true;
            RandomizeTypeMessageLbl.Location = new Point(74, 219);
            RandomizeTypeMessageLbl.Name = "RandomizeTypeMessageLbl";
            RandomizeTypeMessageLbl.Size = new Size(90, 41);
            RandomizeTypeMessageLbl.TabIndex = 13;
            RandomizeTypeMessageLbl.Text = "blank";
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
            // AfterAddLbl
            // 
            AfterAddLbl.AutoSize = true;
            AfterAddLbl.Location = new Point(74, 797);
            AfterAddLbl.Name = "AfterAddLbl";
            AfterAddLbl.Size = new Size(152, 41);
            AfterAddLbl.TabIndex = 19;
            AfterAddLbl.Text = "After Add:";
            // 
            // CloseFormCkB
            // 
            CloseFormCkB.AutoSize = true;
            CloseFormCkB.Checked = true;
            CloseFormCkB.CheckState = CheckState.Checked;
            CloseFormCkB.Location = new Point(303, 797);
            CloseFormCkB.Name = "CloseFormCkB";
            CloseFormCkB.Size = new Size(206, 45);
            CloseFormCkB.TabIndex = 20;
            CloseFormCkB.Text = "Close Form";
            CloseFormCkB.UseVisualStyleBackColor = true;
            // 
            // OpenInTestExplorerCkB
            // 
            OpenInTestExplorerCkB.AutoSize = true;
            OpenInTestExplorerCkB.Location = new Point(534, 796);
            OpenInTestExplorerCkB.Name = "OpenInTestExplorerCkB";
            OpenInTestExplorerCkB.Size = new Size(338, 45);
            OpenInTestExplorerCkB.TabIndex = 21;
            OpenInTestExplorerCkB.Text = "Open in Test Explorer";
            OpenInTestExplorerCkB.UseVisualStyleBackColor = true;
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
            DateTimeGB.Location = new Point(67, 332);
            DateTimeGB.Name = "DateTimeGB";
            DateTimeGB.Size = new Size(835, 389);
            DateTimeGB.TabIndex = 22;
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
            // EndTimeLbl
            // 
            EndTimeLbl.AutoSize = true;
            EndTimeLbl.Location = new Point(79, 283);
            EndTimeLbl.Name = "EndTimeLbl";
            EndTimeLbl.Size = new Size(141, 41);
            EndTimeLbl.TabIndex = 17;
            EndTimeLbl.Text = "End Time";
            // 
            // PickDateTimeCkB
            // 
            PickDateTimeCkB.AutoSize = true;
            PickDateTimeCkB.Location = new Point(303, 281);
            PickDateTimeCkB.Name = "PickDateTimeCkB";
            PickDateTimeCkB.Size = new Size(310, 45);
            PickDateTimeCkB.TabIndex = 21;
            PickDateTimeCkB.Text = "Pick Date and Time";
            PickDateTimeCkB.UseVisualStyleBackColor = true;
            PickDateTimeCkB.CheckStateChanged += PickDateTimeCkB_CheckStateChanged;
            // 
            // ClearFormBtn
            // 
            ClearFormBtn.Location = new Point(409, 874);
            ClearFormBtn.Name = "ClearFormBtn";
            ClearFormBtn.Size = new Size(188, 58);
            ClearFormBtn.TabIndex = 12;
            ClearFormBtn.Text = "Clear Form";
            ClearFormBtn.UseVisualStyleBackColor = true;
            ClearFormBtn.Click += ClearFormBtn_Click;
            // 
            // AddTestForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 945);
            Controls.Add(DateTimeGB);
            Controls.Add(PickDateTimeCkB);
            Controls.Add(OpenInTestExplorerCkB);
            Controls.Add(CloseFormCkB);
            Controls.Add(AfterAddLbl);
            Controls.Add(RandomizeTypeCB);
            Controls.Add(RandomizeTypeLbl);
            Controls.Add(RandomizeTypeMessageLbl);
            Controls.Add(TitleMessageLbl);
            Controls.Add(ClearFormBtn);
            Controls.Add(CancelBtn);
            Controls.Add(AddBtn);
            Controls.Add(PublishCkB);
            Controls.Add(TitleTB);
            Controls.Add(TitleLbl);
            Name = "AddTestForm";
            Text = "Add Test";
            DateTimeGB.ResumeLayout(false);
            DateTimeGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox PublishCkB;
        private TextBox TitleTB;
        private Label TitleLbl;
        private Button AddBtn;
        private Button CancelBtn;
        private Label TitleMessageLbl;
        private Label RandomizeTypeLbl;
        private ComboBox RandomizeTypeCB;
        private DateTimePicker StartDateDTP;
        private Label StartDateLbl;
        private DateTimePicker EndDateDTP;
        private Label EndDateLbl;
        private Label RandomizeTypeMessageLbl;
        private Label StartDateTimeMessageLbl;
        private Label EndDateTimeMessageLbl;
        private Label AfterAddLbl;
        private CheckBox OpenInTestExplorerCkB;
        private CheckBox CloseFormCkB;
        private GroupBox DateTimeGB;
        private CheckBox PickDateTimeCkB;
        private Button ClearFormBtn;
        private DateTimePicker StartTimeDTP;
        private Label StartTimeLbl;
        private DateTimePicker EndTimeDTP;
        private Label EndTimeLbl;
    }
}