using System.Windows.Forms;

namespace OnlineQuiz.Presentation.WinForms.Forms.Controls
{
    partial class LogInUserControl
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
            label = new Label();
            LoginBtn = new Button();
            UsernameTB = new TextBox();
            PasswordTB = new TextBox();
            messageLb = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(182, 0);
            label.Name = "label";
            label.Size = new Size(143, 62);
            label.TabIndex = 0;
            label.Text = "Login";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(27, 276);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(464, 95);
            LoginBtn.TabIndex = 3;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UsernameTB
            // 
            UsernameTB.Location = new Point(27, 102);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.PlaceholderText = "Username";
            UsernameTB.Size = new Size(464, 47);
            UsernameTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(27, 189);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PlaceholderText = "Password";
            PasswordTB.Size = new Size(464, 47);
            PasswordTB.TabIndex = 2;
            // 
            // messageLb
            // 
            messageLb.AutoSize = true;
            messageLb.ForeColor = Color.Red;
            messageLb.Location = new Point(27, 413);
            messageLb.Name = "messageLb";
            messageLb.Size = new Size(144, 41);
            messageLb.TabIndex = 6;
            messageLb.Text = "<_blank>";
            // 
            // LogInUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(messageLb);
            Controls.Add(PasswordTB);
            Controls.Add(UsernameTB);
            Controls.Add(LoginBtn);
            Controls.Add(label);
            Name = "LogInUserControl";
            Size = new Size(518, 469);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button LoginBtn;
        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private Label messageLb;
    }
}
