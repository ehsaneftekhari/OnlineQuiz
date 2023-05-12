using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode
    {
        private void InitializeComponent(IContainer container)
        {
            contextMenuStrip = new ContextMenuStrip(container);
            AddQuestionToolStripMenuItem = new ToolStripMenuItem();
            PropertiesToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(40, 40);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { AddQuestionToolStripMenuItem, DeleteToolStripMenuItem, PropertiesToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(361, 155);
            // 
            // PropertiesToolStripMenuItem
            // 
            PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            PropertiesToolStripMenuItem.Size = new Size(360, 48);
            PropertiesToolStripMenuItem.Text = "Properties";
            PropertiesToolStripMenuItem.Click += PropertiesToolStripMenuItem_Click;
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.Size = new Size(360, 48);
            DeleteToolStripMenuItem.Text = "Delete";
            DeleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // AddQuestionToolStripMenuItem
            // 
            AddQuestionToolStripMenuItem.Name = "AddQuestionToolStripMenuItem";
            AddQuestionToolStripMenuItem.Size = new Size(360, 48);
            AddQuestionToolStripMenuItem.Text = "AddQuestion";
            //AddQuestionToolStripMenuItem.Click += AddSectionToolStripMenuItem_Click;

            ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.ResumeLayout(false);
        }

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem AddQuestionToolStripMenuItem;
        private ToolStripMenuItem PropertiesToolStripMenuItem;
        private ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
