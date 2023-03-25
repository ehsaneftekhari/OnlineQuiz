namespace OnlineQuiz.Presentation.WinForms
{
    partial class LogInForm
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
            label = new Label();
            LoginBtn = new Button();
            UsernameTB = new TextBox();
            PasswordTB = new TextBox();
            ExitBtn = new Button();
            BackBtn = new Button();
            messageLb = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(99, 112);
            label.Name = "label";
            label.Size = new Size(510, 41);
            label.TabIndex = 0;
            label.Text = "Please enter username and password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(127, 439);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(455, 95);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameTB
            // 
            UsernameTB.Location = new Point(122, 219);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.PlaceholderText = "Username";
            UsernameTB.Size = new Size(464, 47);
            UsernameTB.TabIndex = 3;
            UsernameTB.UseWaitCursor = true;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(122, 329);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PlaceholderText = "Password";
            PasswordTB.Size = new Size(464, 47);
            PasswordTB.TabIndex = 3;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(236, 636);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(170, 61);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(412, 636);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(170, 61);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // messageLb
            // 
            messageLb.AutoSize = true;
            messageLb.ForeColor = Color.Red;
            messageLb.Location = new Point(122, 564);
            messageLb.Name = "messageLb";
            messageLb.Size = new Size(144, 41);
            messageLb.TabIndex = 5;
            messageLb.Text = "<_blank>";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 791);
            Controls.Add(messageLb);
            Controls.Add(BackBtn);
            Controls.Add(ExitBtn);
            Controls.Add(PasswordTB);
            Controls.Add(UsernameTB);
            Controls.Add(LoginBtn);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button LoginBtn;
        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private Button ExitBtn;
        private Button BackBtn;
        private Label messageLb;
    }
}