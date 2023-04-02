using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;
using System.ComponentModel;
using System.Windows.Forms;

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
            components = new Container();
            mainTreeView = new TreeView();
            contextMenuStrip = new ContextMenuStrip(components);
            openTestToolStripMenuItem = new ToolStripMenuItem();
            clearExplorerToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainTreeView
            // 
            mainTreeView.ContextMenuStrip = contextMenuStrip;
            mainTreeView.Dock = DockStyle.Fill;
            mainTreeView.Location = new Point(0, 0);
            mainTreeView.Name = "mainTreeView";
            mainTreeView.Size = new Size(739, 1384);
            mainTreeView.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(40, 40);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { openTestToolStripMenuItem, clearExplorerToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(361, 155);
            // 
            // openTestToolStripMenuItem
            // 
            openTestToolStripMenuItem.Name = "openTestToolStripMenuItem";
            openTestToolStripMenuItem.Size = new Size(360, 48);
            openTestToolStripMenuItem.Text = "Open Test";
            openTestToolStripMenuItem.Click += openTestToolStripMenuItem_Click;
            // 
            // clearExplorerToolStripMenuItem
            // 
            clearExplorerToolStripMenuItem.Name = "clearExplorerToolStripMenuItem";
            clearExplorerToolStripMenuItem.Size = new Size(360, 48);
            clearExplorerToolStripMenuItem.Text = "Clear Explorer";
            clearExplorerToolStripMenuItem.Click += clearExplorerToolStripMenuItem_Click;
            // 
            // TestExplorerForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 1384);
            Controls.Add(mainTreeView);
            Name = "TestExplorerForm";
            Text = "TestExplorer";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView mainTreeView;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem openTestToolStripMenuItem;
        private ToolStripMenuItem clearExplorerToolStripMenuItem;
    }
}