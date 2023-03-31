using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    partial class TestExplorerForm
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
            mainTreeView = new TreeView();
            SuspendLayout();
            // 
            // mainTreeView
            // 
            mainTreeView.Dock = DockStyle.Fill;
            mainTreeView.Location = new Point(0, 0);
            mainTreeView.Name = "mainTreeView";
            mainTreeView.Size = new Size(739, 1384);
            mainTreeView.TabIndex = 0;
            // 
            // TestExplorerForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 1384);
            Controls.Add(mainTreeView);
            Name = "TestExplorerForm";
            Text = "TestExplorer";
            ResumeLayout(false);
        }

        #endregion

        private TreeView mainTreeView;
    }
}