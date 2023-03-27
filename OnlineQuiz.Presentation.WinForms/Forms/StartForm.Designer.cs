namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class StartForm
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
            LoginTitleLb = new Label();
            LoginBtn = new Button();
            LoginUsernameTB = new TextBox();
            LoginPasswordTB = new TextBox();
            LoginMessageLb = new Label();
            RegisterEmailTB = new TextBox();
            RegisterLastNameTB = new TextBox();
            RegisterPhoneNumberTB = new TextBox();
            RegisterBtn = new Button();
            RegisterFirstNameTB = new TextBox();
            RegisterFirstNameMessageLbl = new Label();
            RegisterLastNameMessageLbl = new Label();
            RegisterEmailMessageLbl = new Label();
            RegisterPhoneNumberMessageLbl = new Label();
            RegisterMessageLbl = new Label();
            RegisterTitleLabel = new Label();
            LoginGB = new GroupBox();
            RegisterGB = new GroupBox();
            panel = new Panel();
            LoginGB.SuspendLayout();
            RegisterGB.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTitleLb
            // 
            LoginTitleLb.AutoSize = true;
            LoginTitleLb.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTitleLb.Location = new Point(204, 50);
            LoginTitleLb.Name = "LoginTitleLb";
            LoginTitleLb.Size = new Size(143, 62);
            LoginTitleLb.TabIndex = 4;
            LoginTitleLb.Text = "Login";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(49, 326);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(464, 95);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginUsernameTB
            // 
            LoginUsernameTB.Location = new Point(49, 152);
            LoginUsernameTB.Name = "LoginUsernameTB";
            LoginUsernameTB.PlaceholderText = "Username";
            LoginUsernameTB.Size = new Size(464, 47);
            LoginUsernameTB.TabIndex = 1;
            // 
            // LoginPasswordTB
            // 
            LoginPasswordTB.Location = new Point(49, 239);
            LoginPasswordTB.Name = "LoginPasswordTB";
            LoginPasswordTB.PlaceholderText = "Password";
            LoginPasswordTB.Size = new Size(464, 47);
            LoginPasswordTB.TabIndex = 3;
            // 
            // LoginMessageLb
            // 
            LoginMessageLb.AutoSize = true;
            LoginMessageLb.ForeColor = Color.Red;
            LoginMessageLb.Location = new Point(49, 459);
            LoginMessageLb.Name = "LoginMessageLb";
            LoginMessageLb.Size = new Size(136, 41);
            LoginMessageLb.TabIndex = 0;
            LoginMessageLb.Text = "Message";
            // 
            // RegisterEmailTB
            // 
            RegisterEmailTB.Location = new Point(34, 362);
            RegisterEmailTB.Name = "RegisterEmailTB";
            RegisterEmailTB.PlaceholderText = "Email";
            RegisterEmailTB.Size = new Size(551, 47);
            RegisterEmailTB.TabIndex = 3;
            // 
            // RegisterLastNameTB
            // 
            RegisterLastNameTB.Location = new Point(34, 243);
            RegisterLastNameTB.Name = "RegisterLastNameTB";
            RegisterLastNameTB.PlaceholderText = "Last Name";
            RegisterLastNameTB.Size = new Size(551, 47);
            RegisterLastNameTB.TabIndex = 2;
            // 
            // RegisterPhoneNumberTB
            // 
            RegisterPhoneNumberTB.Location = new Point(34, 481);
            RegisterPhoneNumberTB.Name = "RegisterPhoneNumberTB";
            RegisterPhoneNumberTB.PlaceholderText = "Phone Number";
            RegisterPhoneNumberTB.Size = new Size(551, 47);
            RegisterPhoneNumberTB.TabIndex = 4;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(82, 600);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(455, 95);
            RegisterBtn.TabIndex = 0;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegisterFirstNameTB
            // 
            RegisterFirstNameTB.Location = new Point(34, 124);
            RegisterFirstNameTB.Name = "RegisterFirstNameTB";
            RegisterFirstNameTB.PlaceholderText = "First Name";
            RegisterFirstNameTB.Size = new Size(551, 47);
            RegisterFirstNameTB.TabIndex = 1;
            // 
            // RegisterFirstNameMessageLbl
            // 
            RegisterFirstNameMessageLbl.AutoSize = true;
            RegisterFirstNameMessageLbl.ForeColor = Color.Red;
            RegisterFirstNameMessageLbl.Location = new Point(34, 174);
            RegisterFirstNameMessageLbl.Name = "RegisterFirstNameMessageLbl";
            RegisterFirstNameMessageLbl.Size = new Size(136, 41);
            RegisterFirstNameMessageLbl.TabIndex = 8;
            RegisterFirstNameMessageLbl.Text = "Message";
            // 
            // RegisterLastNameMessageLbl
            // 
            RegisterLastNameMessageLbl.AutoSize = true;
            RegisterLastNameMessageLbl.ForeColor = Color.Red;
            RegisterLastNameMessageLbl.Location = new Point(34, 293);
            RegisterLastNameMessageLbl.Name = "RegisterLastNameMessageLbl";
            RegisterLastNameMessageLbl.Size = new Size(136, 41);
            RegisterLastNameMessageLbl.TabIndex = 8;
            RegisterLastNameMessageLbl.Text = "Message";
            // 
            // RegisterEmailMessageLbl
            // 
            RegisterEmailMessageLbl.AutoSize = true;
            RegisterEmailMessageLbl.ForeColor = Color.Red;
            RegisterEmailMessageLbl.Location = new Point(34, 412);
            RegisterEmailMessageLbl.Name = "RegisterEmailMessageLbl";
            RegisterEmailMessageLbl.Size = new Size(136, 41);
            RegisterEmailMessageLbl.TabIndex = 8;
            RegisterEmailMessageLbl.Text = "Message";
            // 
            // RegisterPhoneNumberMessageLbl
            // 
            RegisterPhoneNumberMessageLbl.AutoSize = true;
            RegisterPhoneNumberMessageLbl.ForeColor = Color.Red;
            RegisterPhoneNumberMessageLbl.Location = new Point(34, 531);
            RegisterPhoneNumberMessageLbl.Name = "RegisterPhoneNumberMessageLbl";
            RegisterPhoneNumberMessageLbl.Size = new Size(136, 41);
            RegisterPhoneNumberMessageLbl.TabIndex = 8;
            RegisterPhoneNumberMessageLbl.Text = "Message";
            // 
            // RegisterMessageLbl
            // 
            RegisterMessageLbl.AutoSize = true;
            RegisterMessageLbl.ForeColor = Color.Red;
            RegisterMessageLbl.Location = new Point(34, 714);
            RegisterMessageLbl.Name = "RegisterMessageLbl";
            RegisterMessageLbl.Size = new Size(136, 41);
            RegisterMessageLbl.TabIndex = 8;
            RegisterMessageLbl.Text = "Message";
            // 
            // RegisterTitleLabel
            // 
            RegisterTitleLabel.AutoSize = true;
            RegisterTitleLabel.Location = new Point(139, 54);
            RegisterTitleLabel.Name = "RegisterTitleLabel";
            RegisterTitleLabel.Size = new Size(323, 41);
            RegisterTitleLabel.TabIndex = 0;
            RegisterTitleLabel.Text = "Please enter asked info";
            // 
            // LoginGB
            // 
            LoginGB.Controls.Add(LoginMessageLb);
            LoginGB.Controls.Add(LoginPasswordTB);
            LoginGB.Controls.Add(LoginUsernameTB);
            LoginGB.Controls.Add(LoginBtn);
            LoginGB.Controls.Add(LoginTitleLb);
            LoginGB.Location = new Point(640, 5);
            LoginGB.Name = "LoginGB";
            LoginGB.Size = new Size(562, 528);
            LoginGB.TabIndex = 0;
            LoginGB.TabStop = false;
            LoginGB.Text = "Login";
            // 
            // RegisterGB
            // 
            RegisterGB.Controls.Add(RegisterTitleLabel);
            RegisterGB.Controls.Add(RegisterMessageLbl);
            RegisterGB.Controls.Add(RegisterPhoneNumberMessageLbl);
            RegisterGB.Controls.Add(RegisterEmailMessageLbl);
            RegisterGB.Controls.Add(RegisterLastNameMessageLbl);
            RegisterGB.Controls.Add(RegisterFirstNameMessageLbl);
            RegisterGB.Controls.Add(RegisterBtn);
            RegisterGB.Controls.Add(RegisterFirstNameTB);
            RegisterGB.Controls.Add(RegisterLastNameTB);
            RegisterGB.Controls.Add(RegisterPhoneNumberTB);
            RegisterGB.Controls.Add(RegisterEmailTB);
            RegisterGB.Location = new Point(7, 5);
            RegisterGB.Name = "RegisterGB";
            RegisterGB.Size = new Size(618, 1095);
            RegisterGB.TabIndex = 1;
            RegisterGB.TabStop = false;
            RegisterGB.Text = "Register";
            // 
            // panel
            // 
            panel.Controls.Add(LoginGB);
            panel.Controls.Add(RegisterGB);
            panel.Location = new Point(3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1210, 1117);
            panel.TabIndex = 1;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 1125);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            LoginGB.ResumeLayout(false);
            LoginGB.PerformLayout();
            RegisterGB.ResumeLayout(false);
            RegisterGB.PerformLayout();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label LoginTitleLb;
        private Button LoginBtn;
        private TextBox LoginUsernameTB;
        private TextBox LoginPasswordTB;
        private Label LoginMessageLb;


        private TextBox RegisterFirstNameTB;
        private TextBox RegisterLastNameTB;
        private TextBox RegisterEmailTB;
        private TextBox RegisterPhoneNumberTB;
        private Button RegisterBtn;
        private Label RegisterFirstNameMessageLbl;
        private Label RegisterLastNameMessageLbl;
        private Label RegisterEmailMessageLbl;
        private Label RegisterPhoneNumberMessageLbl;
        private Label RegisterMessageLbl;
        private Label RegisterTitleLabel;


        private GroupBox LoginGB;
        private GroupBox RegisterGB;
        private Panel panel;
    }
}