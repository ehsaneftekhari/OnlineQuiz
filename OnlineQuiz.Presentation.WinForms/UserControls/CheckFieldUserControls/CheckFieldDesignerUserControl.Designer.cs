namespace OnlineQuiz.Presentation.WinForms.UserControls.CheckFieldUserControls
{
    partial class CheckFieldDesignerUserControl
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
            UiTypeCB = new ComboBox();
            UiTypeLbl = new Label();
            RandomizeOptionsCkB = new CheckBox();
            MaximumSelectionsNUD = new NumericUpDown();
            MaximumSelectionsLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            MaximumSelectionsPanel = new Panel();
            UiTypePanel = new Panel();
            RandomizeOptionsPanel = new Panel();
            UpDownPanel = new Panel();
            DownBtn = new Button();
            UpBtn = new Button();
            AddRemovePanel = new Panel();
            AddOptionBtn = new Button();
            RemoveOptionBtn = new Button();
            OptionsTableLayoutPanel = new TableLayoutPanel();
            OpenFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)MaximumSelectionsNUD).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            MaximumSelectionsPanel.SuspendLayout();
            UiTypePanel.SuspendLayout();
            RandomizeOptionsPanel.SuspendLayout();
            UpDownPanel.SuspendLayout();
            AddRemovePanel.SuspendLayout();
            SuspendLayout();
            // 
            // UiTypeCB
            // 
            UiTypeCB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UiTypeCB.FormattingEnabled = true;
            UiTypeCB.Location = new Point(203, 6);
            UiTypeCB.Name = "UiTypeCB";
            UiTypeCB.Size = new Size(398, 49);
            UiTypeCB.TabIndex = 0;
            // 
            // UiTypeLbl
            // 
            UiTypeLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UiTypeLbl.AutoSize = true;
            UiTypeLbl.Location = new Point(3, 9);
            UiTypeLbl.Name = "UiTypeLbl";
            UiTypeLbl.Size = new Size(117, 41);
            UiTypeLbl.TabIndex = 1;
            UiTypeLbl.Text = "Ui Type";
            // 
            // RandomizeOptionsCkB
            // 
            RandomizeOptionsCkB.Anchor = AnchorStyles.Left;
            RandomizeOptionsCkB.AutoSize = true;
            RandomizeOptionsCkB.Location = new Point(3, 9);
            RandomizeOptionsCkB.Name = "RandomizeOptionsCkB";
            RandomizeOptionsCkB.Size = new Size(319, 45);
            RandomizeOptionsCkB.TabIndex = 2;
            RandomizeOptionsCkB.Text = "Randomize Options";
            RandomizeOptionsCkB.UseVisualStyleBackColor = true;
            // 
            // MaximumSelectionsNUD
            // 
            MaximumSelectionsNUD.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MaximumSelectionsNUD.Location = new Point(336, 8);
            MaximumSelectionsNUD.Name = "MaximumSelectionsNUD";
            MaximumSelectionsNUD.Size = new Size(268, 47);
            MaximumSelectionsNUD.TabIndex = 3;
            // 
            // MaximumSelectionsLbl
            // 
            MaximumSelectionsLbl.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MaximumSelectionsLbl.AutoSize = true;
            MaximumSelectionsLbl.Location = new Point(0, 10);
            MaximumSelectionsLbl.Name = "MaximumSelectionsLbl";
            MaximumSelectionsLbl.Size = new Size(292, 41);
            MaximumSelectionsLbl.TabIndex = 1;
            MaximumSelectionsLbl.Text = "Maximum Selections";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MaximumSelectionsPanel, 0, 2);
            tableLayoutPanel1.Controls.Add(UiTypePanel, 0, 0);
            tableLayoutPanel1.Controls.Add(RandomizeOptionsPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(UpDownPanel, 0, 3);
            tableLayoutPanel1.Controls.Add(AddRemovePanel, 0, 5);
            tableLayoutPanel1.Controls.Add(OptionsTableLayoutPanel, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(610, 912);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // MaximumSelectionsPanel
            // 
            MaximumSelectionsPanel.Controls.Add(MaximumSelectionsLbl);
            MaximumSelectionsPanel.Controls.Add(MaximumSelectionsNUD);
            MaximumSelectionsPanel.Dock = DockStyle.Fill;
            MaximumSelectionsPanel.Location = new Point(3, 143);
            MaximumSelectionsPanel.Name = "MaximumSelectionsPanel";
            MaximumSelectionsPanel.Size = new Size(604, 64);
            MaximumSelectionsPanel.TabIndex = 5;
            // 
            // UiTypePanel
            // 
            UiTypePanel.Controls.Add(UiTypeCB);
            UiTypePanel.Controls.Add(UiTypeLbl);
            UiTypePanel.Dock = DockStyle.Fill;
            UiTypePanel.Location = new Point(3, 3);
            UiTypePanel.Name = "UiTypePanel";
            UiTypePanel.Size = new Size(604, 64);
            UiTypePanel.TabIndex = 2;
            // 
            // RandomizeOptionsPanel
            // 
            RandomizeOptionsPanel.Controls.Add(RandomizeOptionsCkB);
            RandomizeOptionsPanel.Dock = DockStyle.Fill;
            RandomizeOptionsPanel.Location = new Point(3, 73);
            RandomizeOptionsPanel.Name = "RandomizeOptionsPanel";
            RandomizeOptionsPanel.Size = new Size(604, 64);
            RandomizeOptionsPanel.TabIndex = 3;
            // 
            // UpDownPanel
            // 
            UpDownPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UpDownPanel.Controls.Add(UpBtn);
            UpDownPanel.Controls.Add(DownBtn);
            UpDownPanel.Location = new Point(218, 213);
            UpDownPanel.Name = "UpDownPanel";
            UpDownPanel.Size = new Size(389, 64);
            UpDownPanel.TabIndex = 6;
            // 
            // DownBtn
            // 
            DownBtn.Location = new Point(0, 0);
            DownBtn.Name = "DownBtn";
            DownBtn.Size = new Size(188, 58);
            DownBtn.TabIndex = 0;
            DownBtn.Text = "Down";
            DownBtn.UseVisualStyleBackColor = true;
            // 
            // UpBtn
            // 
            UpBtn.Location = new Point(194, 0);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(188, 58);
            UpBtn.TabIndex = 1;
            UpBtn.Text = "Up";
            UpBtn.UseVisualStyleBackColor = true;
            // 
            // AddRemovePanel
            // 
            AddRemovePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AddRemovePanel.Controls.Add(RemoveOptionBtn);
            AddRemovePanel.Controls.Add(AddOptionBtn);
            AddRemovePanel.Location = new Point(216, 845);
            AddRemovePanel.Name = "AddRemovePanel";
            AddRemovePanel.Size = new Size(391, 64);
            AddRemovePanel.TabIndex = 7;
            // 
            // AddOptionBtn
            // 
            AddOptionBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AddOptionBtn.Location = new Point(200, 3);
            AddOptionBtn.Name = "AddOptionBtn";
            AddOptionBtn.Size = new Size(188, 58);
            AddOptionBtn.TabIndex = 0;
            AddOptionBtn.Text = "Add";
            AddOptionBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveOptionBtn
            // 
            RemoveOptionBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveOptionBtn.Location = new Point(6, 3);
            RemoveOptionBtn.Name = "RemoveOptionBtn";
            RemoveOptionBtn.Size = new Size(188, 58);
            RemoveOptionBtn.TabIndex = 1;
            RemoveOptionBtn.Text = "Remove";
            RemoveOptionBtn.UseVisualStyleBackColor = true;
            // 
            // OptionsTableLayoutPanel
            // 
            OptionsTableLayoutPanel.ColumnCount = 1;
            OptionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            OptionsTableLayoutPanel.Dock = DockStyle.Fill;
            OptionsTableLayoutPanel.Location = new Point(3, 283);
            OptionsTableLayoutPanel.Name = "OptionsTableLayoutPanel";
            OptionsTableLayoutPanel.RowCount = 1;
            OptionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            OptionsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            OptionsTableLayoutPanel.Size = new Size(604, 556);
            OptionsTableLayoutPanel.TabIndex = 8;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // CheckFieldDesignerUserControl
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CheckFieldDesignerUserControl";
            Size = new Size(610, 912);
            ((System.ComponentModel.ISupportInitialize)MaximumSelectionsNUD).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            MaximumSelectionsPanel.ResumeLayout(false);
            MaximumSelectionsPanel.PerformLayout();
            UiTypePanel.ResumeLayout(false);
            UiTypePanel.PerformLayout();
            RandomizeOptionsPanel.ResumeLayout(false);
            RandomizeOptionsPanel.PerformLayout();
            UpDownPanel.ResumeLayout(false);
            AddRemovePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox UiTypeCB;
        private Label UiTypeLbl;
        private CheckBox RandomizeOptionsCkB;
        private NumericUpDown MaximumSelectionsNUD;
        private Label MaximumSelectionsLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel MaximumSelectionsPanel;
        private Panel UiTypePanel;
        private Panel RandomizeOptionsPanel;
        private Panel UpDownPanel;
        private Button UpBtn;
        private Button DownBtn;
        private Panel AddRemovePanel;
        private Button RemoveOptionBtn;
        private Button AddOptionBtn;
        private TableLayoutPanel OptionsTableLayoutPanel;
        private OpenFileDialog OpenFileDialog;
    }
}
