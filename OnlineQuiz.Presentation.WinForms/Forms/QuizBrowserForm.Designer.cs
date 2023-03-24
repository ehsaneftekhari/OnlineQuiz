namespace OnlineQuiz.Presentation.WinForms
{
    partial class QuizBrowserForm
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
            QuizDGV = new DataGridView();
            QuizBrowserGB = new GroupBox();
            SearchByLbl = new Label();
            NameOrIdCB = new ComboBox();
            NameIdTB = new TextBox();
            BackBtn = new Button();
            ExitBtn = new Button();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)QuizDGV).BeginInit();
            QuizBrowserGB.SuspendLayout();
            SuspendLayout();
            // 
            // QuizDGV
            // 
            QuizDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuizDGV.Dock = DockStyle.Bottom;
            QuizDGV.Location = new Point(3, 122);
            QuizDGV.Name = "QuizDGV";
            QuizDGV.RowHeadersWidth = 102;
            QuizDGV.RowTemplate.Height = 49;
            QuizDGV.Size = new Size(1141, 1360);
            QuizDGV.TabIndex = 2;
            // 
            // QuizBrowserGB
            // 
            QuizBrowserGB.Controls.Add(SearchBtn);
            QuizBrowserGB.Controls.Add(SearchByLbl);
            QuizBrowserGB.Controls.Add(NameOrIdCB);
            QuizBrowserGB.Controls.Add(NameIdTB);
            QuizBrowserGB.Controls.Add(QuizDGV);
            QuizBrowserGB.Dock = DockStyle.Top;
            QuizBrowserGB.Location = new Point(0, 0);
            QuizBrowserGB.Name = "QuizBrowserGB";
            QuizBrowserGB.Size = new Size(1147, 1485);
            QuizBrowserGB.TabIndex = 3;
            QuizBrowserGB.TabStop = false;
            QuizBrowserGB.Text = "Quiz Browser";
            // 
            // SearchByLbl
            // 
            SearchByLbl.AutoSize = true;
            SearchByLbl.Location = new Point(12, 55);
            SearchByLbl.Name = "SearchByLbl";
            SearchByLbl.Size = new Size(155, 41);
            SearchByLbl.TabIndex = 5;
            SearchByLbl.Text = "Search by ";
            // 
            // NameOrIdCB
            // 
            NameOrIdCB.DropDownStyle = ComboBoxStyle.DropDownList;
            NameOrIdCB.FormattingEnabled = true;
            NameOrIdCB.Items.AddRange(new object[] { "Name", "ID" });
            NameOrIdCB.SelectedIndex = 0;
            NameOrIdCB.Location = new Point(173, 52);
            NameOrIdCB.Name = "NameOrIdCB";
            NameOrIdCB.Size = new Size(170, 49);
            NameOrIdCB.TabIndex = 4;
            // 
            // NameIdTB
            // 
            NameIdTB.Location = new Point(349, 55);
            NameIdTB.Name = "NameIdTB";
            NameIdTB.Size = new Size(610, 47);
            NameIdTB.TabIndex = 3;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(965, 1498);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(170, 61);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(789, 1498);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(170, 61);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(965, 55);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(170, 50);
            SearchBtn.TabIndex = 6;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // QuizBrowserForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 1571);
            Controls.Add(QuizBrowserGB);
            Controls.Add(BackBtn);
            Controls.Add(ExitBtn);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuizBrowserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuizBrowserForm";
            ((System.ComponentModel.ISupportInitialize)QuizDGV).EndInit();
            QuizBrowserGB.ResumeLayout(false);
            QuizBrowserGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView QuizDGV;
        private GroupBox QuizBrowserGB;
        private TextBox NameIdTB;
        private ComboBox NameOrIdCB;
        private Label SearchByLbl;
        private Button BackBtn;
        private Button ExitBtn;
        private Button SearchBtn;
    }
}