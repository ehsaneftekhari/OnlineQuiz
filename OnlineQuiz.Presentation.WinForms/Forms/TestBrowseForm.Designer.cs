namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class TestBrowseForm
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
            mainTableLayoutPanel = new TableLayoutPanel();
            innerTableLayoutPanel = new TableLayoutPanel();
            TestTitleTB = new TextBox();
            SearchBtn = new Button();
            TestTitleLbl = new Label();
            testListDGV = new DataGridView();
            mainTableLayoutPanel.SuspendLayout();
            innerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)testListDGV).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(innerTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(testListDGV, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(1225, 1399);
            mainTableLayoutPanel.TabIndex = 4;
            // 
            // innerTableLayoutPanel
            // 
            innerTableLayoutPanel.ColumnCount = 3;
            innerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            innerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            innerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 194F));
            innerTableLayoutPanel.Controls.Add(TestTitleTB, 1, 0);
            innerTableLayoutPanel.Controls.Add(SearchBtn, 2, 0);
            innerTableLayoutPanel.Controls.Add(TestTitleLbl, 0, 0);
            innerTableLayoutPanel.Dock = DockStyle.Fill;
            innerTableLayoutPanel.Location = new Point(3, 3);
            innerTableLayoutPanel.Name = "innerTableLayoutPanel";
            innerTableLayoutPanel.RowCount = 1;
            innerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            innerTableLayoutPanel.Size = new Size(1219, 69);
            innerTableLayoutPanel.TabIndex = 4;
            // 
            // TestTitleTB
            // 
            TestTitleTB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TestTitleTB.Location = new Point(83, 11);
            TestTitleTB.Name = "TestTitleTB";
            TestTitleTB.Size = new Size(939, 47);
            TestTitleTB.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchBtn.Location = new Point(1028, 5);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(188, 58);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // TestTitleLbl
            // 
            TestTitleLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TestTitleLbl.AutoSize = true;
            TestTitleLbl.Location = new Point(3, 14);
            TestTitleLbl.Name = "TestTitleLbl";
            TestTitleLbl.Size = new Size(74, 41);
            TestTitleLbl.TabIndex = 0;
            TestTitleLbl.Text = "Title";
            // 
            // testListDGV
            // 
            testListDGV.AllowUserToAddRows = false;
            testListDGV.AllowUserToDeleteRows = false;
            testListDGV.AllowUserToOrderColumns = true;
            testListDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            testListDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testListDGV.Location = new Point(3, 78);
            testListDGV.Name = "testListDGV";
            testListDGV.ReadOnly = true;
            testListDGV.RowHeadersWidth = 102;
            testListDGV.RowTemplate.Height = 49;
            testListDGV.Size = new Size(1219, 1318);
            testListDGV.TabIndex = 3;
            testListDGV.CellClick += testListDGV_CellClick;
            // 
            // TestBrowseForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 1399);
            Controls.Add(mainTableLayoutPanel);
            Name = "TestBrowseForm";
            Text = "TestBrowseForm";
            mainTableLayoutPanel.ResumeLayout(false);
            innerTableLayoutPanel.ResumeLayout(false);
            innerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)testListDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel innerTableLayoutPanel;
        private TextBox TestTitleTB;
        private Button SearchBtn;
        private Label TestTitleLbl;
        private DataGridView testListDGV;
    }
}