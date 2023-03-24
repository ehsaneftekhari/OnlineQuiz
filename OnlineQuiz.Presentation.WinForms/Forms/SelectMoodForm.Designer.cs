namespace OnlineQuiz.Presentation.WinForms
{
    partial class SelectMoodForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            UserSelectBtn = new Button();
            QuizSelectBtn = new Button();
            ExitBtn = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(119, 62);
            label.Name = "label";
            label.Size = new Size(455, 41);
            label.TabIndex = 0;
            label.Text = "Select the type of your operation";
            // 
            // UserSelectBtn
            // 
            UserSelectBtn.Location = new Point(119, 175);
            UserSelectBtn.Name = "UserSelectBtn";
            UserSelectBtn.Size = new Size(455, 95);
            UserSelectBtn.TabIndex = 1;
            UserSelectBtn.Text = "User";
            UserSelectBtn.UseVisualStyleBackColor = true;
            UserSelectBtn.Click += AdminSelectBtn_Click;
            // 
            // QuizSelectBtn
            // 
            QuizSelectBtn.Location = new Point(119, 342);
            QuizSelectBtn.Name = "QuizSelectBtn";
            QuizSelectBtn.Size = new Size(455, 95);
            QuizSelectBtn.TabIndex = 2;
            QuizSelectBtn.Text = "Take Quiz";
            QuizSelectBtn.UseVisualStyleBackColor = true;
            QuizSelectBtn.Click += QuizSelectBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(261, 510);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(170, 61);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // SelectMoodForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 661);
            Controls.Add(ExitBtn);
            Controls.Add(QuizSelectBtn);
            Controls.Add(UserSelectBtn);
            Controls.Add(label);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectMoodForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "select mood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Button UserSelectBtn;
        private Button QuizSelectBtn;
        private Button ExitBtn;
        private Label label2;
    }
}