namespace OnlineQuiz.Presentation.WinForms
{
    partial class BaseUserRegisterInfoForm
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
            BackBtn = new Button();
            ExitBtn = new Button();
            EmailTB = new TextBox();
            LastNameTB = new TextBox();
            PhoneNumberTB = new TextBox();
            RegisterBtn = new Button();
            FirstNameTB = new TextBox();
            FirstNameMessageLbl = new Label();
            LastNameMessageLbl = new Label();
            EmailMessageLbl = new Label();
            PhoneNumberMessageLbl = new Label();
            MessageLbl = new Label();
            label = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(274, 775);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(170, 61);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(450, 775);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(170, 61);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // EmailTB
            // 
            EmailTB.Location = new Point(69, 357);
            EmailTB.Name = "EmailTB";
            EmailTB.PlaceholderText = "Email";
            EmailTB.Size = new Size(551, 47);
            EmailTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            LastNameTB.Location = new Point(69, 238);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.PlaceholderText = "Last Name";
            LastNameTB.Size = new Size(551, 47);
            LastNameTB.TabIndex = 1;
            // 
            // PhoneNumberTB
            // 
            PhoneNumberTB.Location = new Point(69, 476);
            PhoneNumberTB.Name = "PhoneNumberTB";
            PhoneNumberTB.PlaceholderText = "Phone Number";
            PhoneNumberTB.Size = new Size(551, 47);
            PhoneNumberTB.TabIndex = 1;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(117, 595);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(455, 95);
            RegisterBtn.TabIndex = 7;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Location = new Point(69, 119);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.PlaceholderText = "First Name";
            FirstNameTB.Size = new Size(551, 47);
            FirstNameTB.TabIndex = 1;
            // 
            // FirstNameMessageLbl
            // 
            FirstNameMessageLbl.AutoSize = true;
            FirstNameMessageLbl.ForeColor = Color.Red;
            FirstNameMessageLbl.Location = new Point(69, 169);
            FirstNameMessageLbl.Name = "FirstNameMessageLbl";
            FirstNameMessageLbl.Size = new Size(144, 41);
            FirstNameMessageLbl.TabIndex = 8;
            //FirstNameMessageLbl.Text = "<_blank>";
            // 
            // LastNameMessageLbl
            // 
            LastNameMessageLbl.AutoSize = true;
            LastNameMessageLbl.ForeColor = Color.Red;
            LastNameMessageLbl.Location = new Point(69, 288);
            LastNameMessageLbl.Name = "LastNameMessageLbl";
            LastNameMessageLbl.Size = new Size(144, 41);
            LastNameMessageLbl.TabIndex = 8;
            //LastNameMessageLbl.Text = "<_blank>";
            // 
            // EmailMessageLbl
            // 
            EmailMessageLbl.AutoSize = true;
            EmailMessageLbl.ForeColor = Color.Red;
            EmailMessageLbl.Location = new Point(69, 407);
            EmailMessageLbl.Name = "EmailMessageLbl";
            EmailMessageLbl.Size = new Size(144, 41);
            EmailMessageLbl.TabIndex = 8;
            //EmailMessageLbl.Text = "<_blank>";
            // 
            // PhoneNumberMessageLbl
            // 
            PhoneNumberMessageLbl.AutoSize = true;
            PhoneNumberMessageLbl.ForeColor = Color.Red;
            PhoneNumberMessageLbl.Location = new Point(69, 526);
            PhoneNumberMessageLbl.Name = "PhoneNumberMessageLbl";
            PhoneNumberMessageLbl.Size = new Size(144, 41);
            PhoneNumberMessageLbl.TabIndex = 8;
            //PhoneNumberMessageLbl.Text = "<_blank>";
            // 
            // MessageLbl
            // 
            MessageLbl.AutoSize = true;
            MessageLbl.ForeColor = Color.Red;
            MessageLbl.Location = new Point(272, 708);
            MessageLbl.Name = "MessageLbl";
            MessageLbl.Size = new Size(144, 41);
            MessageLbl.TabIndex = 8;
            //MessageLbl.Text = "<_blank>";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(183, 43);
            label.Name = "label";
            label.Size = new Size(323, 41);
            label.TabIndex = 9;
            label.Text = "Please enter asked info";
            // 
            // BaseUserRegisterInfoForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 865);
            Controls.Add(label);
            Controls.Add(MessageLbl);
            Controls.Add(PhoneNumberMessageLbl);
            Controls.Add(EmailMessageLbl);
            Controls.Add(LastNameMessageLbl);
            Controls.Add(FirstNameMessageLbl);
            Controls.Add(RegisterBtn);
            Controls.Add(FirstNameTB);
            Controls.Add(LastNameTB);
            Controls.Add(PhoneNumberTB);
            Controls.Add(EmailTB);
            Controls.Add(BackBtn);
            Controls.Add(ExitBtn);
            Name = "BaseUserRegisterInfoForm";
            Text = "BaseUserRegisterInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameTB;
        private TextBox LastNameTB;
        private TextBox EmailTB;
        private TextBox PhoneNumberTB;
        private Button RegisterBtn;
        private Label FirstNameMessageLbl;
        private Label LastNameMessageLbl;
        private Label EmailMessageLbl;
        private Label PhoneNumberMessageLbl;
        private Label MessageLbl;
        private Button BackBtn;
        private Button ExitBtn;
        private Label label;
    }
}