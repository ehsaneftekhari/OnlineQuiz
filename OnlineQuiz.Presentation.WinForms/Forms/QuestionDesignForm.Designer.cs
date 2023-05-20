namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class QuestionDesignForm
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            label2 = new Label();
            comboBox2 = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            SectionSelectCB = new ComboBox();
            SectionLbl = new Label();
            QuestionGV = new DataGridView();
            panel1 = new Panel();
            TestLbl = new Label();
            TestSelectCB = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionGV).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1644, 1376);
            splitContainer1.SplitterDistance = 723;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer2.Size = new Size(917, 1376);
            splitContainer2.SplitterDistance = 439;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(439, 1376);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(comboBox2);
            panel4.Location = new Point(3, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 60);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(81, 41);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(125, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(299, 49);
            comboBox2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(QuestionGV, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(474, 1376);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(SectionSelectCB);
            panel3.Controls.Add(SectionLbl);
            panel3.Location = new Point(3, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 60);
            panel3.TabIndex = 2;
            // 
            // SectionSelectCB
            // 
            SectionSelectCB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SectionSelectCB.FormattingEnabled = true;
            SectionSelectCB.Location = new Point(126, 8);
            SectionSelectCB.Name = "SectionSelectCB";
            SectionSelectCB.Size = new Size(333, 49);
            SectionSelectCB.TabIndex = 2;
            SectionSelectCB.SelectedIndexChanged += SectionSelectCB_SelectedIndexChanged;
            // 
            // SectionLbl
            // 
            SectionLbl.Anchor = AnchorStyles.Left;
            SectionLbl.AutoSize = true;
            SectionLbl.Location = new Point(4, 11);
            SectionLbl.Name = "SectionLbl";
            SectionLbl.Size = new Size(116, 41);
            SectionLbl.TabIndex = 1;
            SectionLbl.Text = "Section";
            // 
            // QuestionGV
            // 
            QuestionGV.AllowUserToAddRows = false;
            QuestionGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuestionGV.Dock = DockStyle.Fill;
            QuestionGV.Location = new Point(3, 143);
            QuestionGV.Name = "QuestionGV";
            QuestionGV.ReadOnly = true;
            QuestionGV.RowHeadersWidth = 102;
            QuestionGV.RowTemplate.Height = 49;
            QuestionGV.Size = new Size(468, 1230);
            QuestionGV.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(TestLbl);
            panel1.Controls.Add(TestSelectCB);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 60);
            panel1.TabIndex = 2;
            // 
            // TestLbl
            // 
            TestLbl.Anchor = AnchorStyles.Left;
            TestLbl.AutoSize = true;
            TestLbl.Location = new Point(3, 6);
            TestLbl.Name = "TestLbl";
            TestLbl.Size = new Size(70, 41);
            TestLbl.TabIndex = 1;
            TestLbl.Text = "Test";
            // 
            // TestSelectCB
            // 
            TestSelectCB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TestSelectCB.FormattingEnabled = true;
            TestSelectCB.Location = new Point(126, 3);
            TestSelectCB.Name = "TestSelectCB";
            TestSelectCB.Size = new Size(333, 49);
            TestSelectCB.TabIndex = 0;
            TestSelectCB.SelectedIndexChanged += TestSelectCB_SelectedIndexChanged;
            TestSelectCB.TextUpdate += TestSelectCB_OnTextUpdate;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox4);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 60);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(70, 41);
            label4.TabIndex = 1;
            label4.Text = "Test";
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.None;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(-48, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(426, 49);
            comboBox4.TabIndex = 0;
            // 
            // QuestionDesignForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1644, 1376);
            Controls.Add(splitContainer1);
            Name = "QuestionDesignForm";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuestionGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Label SectionLbl;
        private Panel panel1;
        private Label TestLbl;
        private ComboBox TestSelectCB;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label4;
        private ComboBox comboBox4;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel4;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox SectionSelectCB;
        private DataGridView QuestionGV;
    }
}