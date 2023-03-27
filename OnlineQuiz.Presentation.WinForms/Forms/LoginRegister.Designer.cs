namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class LoginRegister
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
            RegisterBaseUserBtn = new Button();
            RegisterFirstNameTB = new TextBox();
            RegisterFirstNameMessageLbl = new Label();
            RegisterLastNameMessageLbl = new Label();
            RegisterEmailMessageLbl = new Label();
            RegisterPhoneNumberMessageLbl = new Label();
            RegisterBaseUserMessageLbl = new Label();
            RegisterBaseUserTitleLabel = new Label();
            LoginGB = new GroupBox();
            RegisterGB = new GroupBox();
            RegisterUserMessageLbl = new Label();
            RegisterPasswordVerifyMessageLbl = new Label();
            RegisterPasswordMessageLbl = new Label();
            RegisterUsernameMessageLbl = new Label();
            RegisterUserBtn = new Button();
            RegisterUsernameTB = new TextBox();
            RegisterPasswordVerifyTB = new TextBox();
            RegisterPasswordTB = new TextBox();
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
            LoginTitleLb.Location = new Point(197, 148);
            LoginTitleLb.Name = "LoginTitleLb";
            LoginTitleLb.Size = new Size(143, 62);
            LoginTitleLb.TabIndex = 4;
            LoginTitleLb.Text = "Login";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(42, 424);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(464, 95);
            LoginBtn.TabIndex = 0;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginUsernameTB
            // 
            LoginUsernameTB.Location = new Point(42, 250);
            LoginUsernameTB.Name = "LoginUsernameTB";
            LoginUsernameTB.PlaceholderText = "Username";
            LoginUsernameTB.Size = new Size(464, 47);
            LoginUsernameTB.TabIndex = 1;
            // 
            // LoginPasswordTB
            // 
            LoginPasswordTB.Location = new Point(42, 337);
            LoginPasswordTB.Name = "LoginPasswordTB";
            LoginPasswordTB.PlaceholderText = "Password";
            LoginPasswordTB.Size = new Size(464, 47);
            LoginPasswordTB.TabIndex = 3;
            // 
            // LoginMessageLb
            // 
            LoginMessageLb.AutoSize = true;
            LoginMessageLb.ForeColor = Color.Red;
            LoginMessageLb.Location = new Point(42, 557);
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
            RegisterEmailTB.TabIndex = 2;
            // 
            // RegisterLastNameTB
            // 
            RegisterLastNameTB.Location = new Point(34, 243);
            RegisterLastNameTB.Name = "RegisterLastNameTB";
            RegisterLastNameTB.PlaceholderText = "Last Name";
            RegisterLastNameTB.Size = new Size(551, 47);
            RegisterLastNameTB.TabIndex = 1;
            // 
            // RegisterPhoneNumberTB
            // 
            RegisterPhoneNumberTB.Location = new Point(34, 481);
            RegisterPhoneNumberTB.Name = "RegisterPhoneNumberTB";
            RegisterPhoneNumberTB.PlaceholderText = "Phone Number";
            RegisterPhoneNumberTB.Size = new Size(551, 47);
            RegisterPhoneNumberTB.TabIndex = 3;
            // 
            // RegisterBaseUserBtn
            // 
            RegisterBaseUserBtn.Location = new Point(82, 600);
            RegisterBaseUserBtn.Name = "RegisterBaseUserBtn";
            RegisterBaseUserBtn.Size = new Size(455, 95);
            RegisterBaseUserBtn.TabIndex = 4;
            RegisterBaseUserBtn.Text = "Register";
            RegisterBaseUserBtn.UseVisualStyleBackColor = true;
            RegisterBaseUserBtn.Click += RegisterBaseUserBtn_Click;
            // 
            // RegisterFirstNameTB
            // 
            RegisterFirstNameTB.Location = new Point(34, 124);
            RegisterFirstNameTB.Name = "RegisterFirstNameTB";
            RegisterFirstNameTB.PlaceholderText = "First Name";
            RegisterFirstNameTB.Size = new Size(551, 47);
            RegisterFirstNameTB.TabIndex = 0;
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
            // RegisterBaseUserMessageLbl
            // 
            RegisterBaseUserMessageLbl.AutoSize = true;
            RegisterBaseUserMessageLbl.ForeColor = Color.Red;
            RegisterBaseUserMessageLbl.Location = new Point(34, 714);
            RegisterBaseUserMessageLbl.Name = "RegisterBaseUserMessageLbl";
            RegisterBaseUserMessageLbl.Size = new Size(136, 41);
            RegisterBaseUserMessageLbl.TabIndex = 8;
            RegisterBaseUserMessageLbl.Text = "Message";
            // 
            // RegisterBaseUserTitleLabel
            // 
            RegisterBaseUserTitleLabel.AutoSize = true;
            RegisterBaseUserTitleLabel.Location = new Point(139, 54);
            RegisterBaseUserTitleLabel.Name = "RegisterBaseUserTitleLabel";
            RegisterBaseUserTitleLabel.Size = new Size(323, 41);
            RegisterBaseUserTitleLabel.TabIndex = 0;
            RegisterBaseUserTitleLabel.Text = "Please enter asked info";
            // 
            // LoginGB
            // 
            LoginGB.Controls.Add(LoginMessageLb);
            LoginGB.Controls.Add(LoginPasswordTB);
            LoginGB.Controls.Add(LoginUsernameTB);
            LoginGB.Controls.Add(LoginBtn);
            LoginGB.Controls.Add(LoginTitleLb);
            LoginGB.Location = new Point(642, 8);
            LoginGB.Name = "LoginGB";
            LoginGB.Size = new Size(562, 759);
            LoginGB.TabIndex = 0;
            LoginGB.TabStop = false;
            LoginGB.Text = "Login";
            // 
            // RegisterGB
            // 
            RegisterGB.Controls.Add(RegisterBaseUserTitleLabel);
            RegisterGB.Controls.Add(RegisterUserMessageLbl);
            RegisterGB.Controls.Add(RegisterBaseUserMessageLbl);
            RegisterGB.Controls.Add(RegisterPasswordVerifyMessageLbl);
            RegisterGB.Controls.Add(RegisterPhoneNumberMessageLbl);
            RegisterGB.Controls.Add(RegisterPasswordMessageLbl);
            RegisterGB.Controls.Add(RegisterEmailMessageLbl);
            RegisterGB.Controls.Add(RegisterUsernameMessageLbl);
            RegisterGB.Controls.Add(RegisterLastNameMessageLbl);
            RegisterGB.Controls.Add(RegisterFirstNameMessageLbl);
            RegisterGB.Controls.Add(RegisterUserBtn);
            RegisterGB.Controls.Add(RegisterBaseUserBtn);
            RegisterGB.Controls.Add(RegisterFirstNameTB);
            RegisterGB.Controls.Add(RegisterUsernameTB);
            RegisterGB.Controls.Add(RegisterPasswordVerifyTB);
            RegisterGB.Controls.Add(RegisterLastNameTB);
            RegisterGB.Controls.Add(RegisterPasswordTB);
            RegisterGB.Controls.Add(RegisterPhoneNumberTB);
            RegisterGB.Controls.Add(RegisterEmailTB);
            RegisterGB.Location = new Point(6, 8);
            RegisterGB.Name = "RegisterGB";
            RegisterGB.Size = new Size(618, 1392);
            RegisterGB.TabIndex = 1;
            RegisterGB.TabStop = false;
            RegisterGB.Text = "Register";
            // 
            // RegisterUserMessageLbl
            // 
            RegisterUserMessageLbl.AutoSize = true;
            RegisterUserMessageLbl.ForeColor = Color.Red;
            RegisterUserMessageLbl.Location = new Point(34, 1326);
            RegisterUserMessageLbl.Name = "RegisterUserMessageLbl";
            RegisterUserMessageLbl.Size = new Size(136, 41);
            RegisterUserMessageLbl.TabIndex = 8;
            RegisterUserMessageLbl.Text = "Message";
            // 
            // RegisterPasswordVerifyMessageLbl
            // 
            RegisterPasswordVerifyMessageLbl.AutoSize = true;
            RegisterPasswordVerifyMessageLbl.ForeColor = Color.Red;
            RegisterPasswordVerifyMessageLbl.Location = new Point(34, 1143);
            RegisterPasswordVerifyMessageLbl.Name = "RegisterPasswordVerifyMessageLbl";
            RegisterPasswordVerifyMessageLbl.Size = new Size(136, 41);
            RegisterPasswordVerifyMessageLbl.TabIndex = 8;
            RegisterPasswordVerifyMessageLbl.Text = "Message";
            // 
            // RegisterPasswordMessageLbl
            // 
            RegisterPasswordMessageLbl.AutoSize = true;
            RegisterPasswordMessageLbl.ForeColor = Color.Red;
            RegisterPasswordMessageLbl.Location = new Point(34, 1024);
            RegisterPasswordMessageLbl.Name = "RegisterPasswordMessageLbl";
            RegisterPasswordMessageLbl.Size = new Size(136, 41);
            RegisterPasswordMessageLbl.TabIndex = 8;
            RegisterPasswordMessageLbl.Text = "Message";
            // 
            // RegisterUsernameMessageLbl
            // 
            RegisterUsernameMessageLbl.AutoSize = true;
            RegisterUsernameMessageLbl.ForeColor = Color.Red;
            RegisterUsernameMessageLbl.Location = new Point(34, 905);
            RegisterUsernameMessageLbl.Name = "RegisterUsernameMessageLbl";
            RegisterUsernameMessageLbl.Size = new Size(136, 41);
            RegisterUsernameMessageLbl.TabIndex = 8;
            RegisterUsernameMessageLbl.Text = "Message";
            // 
            // RegisterUserBtn
            // 
            RegisterUserBtn.Location = new Point(82, 1212);
            RegisterUserBtn.Name = "RegisterUserBtn";
            RegisterUserBtn.Size = new Size(455, 95);
            RegisterUserBtn.TabIndex = 8;
            RegisterUserBtn.Text = "Register";
            RegisterUserBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterUsernameTB
            // 
            RegisterUsernameTB.Location = new Point(34, 855);
            RegisterUsernameTB.Name = "RegisterUsernameTB";
            RegisterUsernameTB.PlaceholderText = "Username";
            RegisterUsernameTB.Size = new Size(551, 47);
            RegisterUsernameTB.TabIndex = 5;
            // 
            // RegisterPasswordVerifyTB
            // 
            RegisterPasswordVerifyTB.Location = new Point(34, 1093);
            RegisterPasswordVerifyTB.Name = "RegisterPasswordVerifyTB";
            RegisterPasswordVerifyTB.PlaceholderText = "Password Verify";
            RegisterPasswordVerifyTB.Size = new Size(551, 47);
            RegisterPasswordVerifyTB.TabIndex = 7;
            // 
            // RegisterPasswordTB
            // 
            RegisterPasswordTB.Location = new Point(34, 974);
            RegisterPasswordTB.Name = "RegisterPasswordTB";
            RegisterPasswordTB.PlaceholderText = "Password";
            RegisterPasswordTB.Size = new Size(551, 47);
            RegisterPasswordTB.TabIndex = 6;
            // 
            // panel
            // 
            panel.Controls.Add(LoginGB);
            panel.Controls.Add(RegisterGB);
            panel.Location = new Point(3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1210, 1405);
            panel.TabIndex = 1;
            // 
            // LoginRegister
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 1410);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login or Register";
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
        private Button RegisterBaseUserBtn;
        private Label RegisterFirstNameMessageLbl;
        private Label RegisterLastNameMessageLbl;
        private Label RegisterEmailMessageLbl;
        private Label RegisterPhoneNumberMessageLbl;
        private Label RegisterBaseUserMessageLbl;
        private Label RegisterBaseUserTitleLabel;


        private GroupBox LoginGB;
        private GroupBox RegisterGB;
        private Panel panel;
        private Label RegisterUserMessageLbl;
        private Label RegisterPasswordVerifyMessageLbl;
        private Label RegisterPasswordMessageLbl;
        private Label RegisterUsernameMessageLbl;
        private Button RegisterUserBtn;
        private TextBox RegisterUsernameTB;
        private TextBox RegisterPasswordVerifyTB;
        private TextBox RegisterPasswordTB;
    }
}