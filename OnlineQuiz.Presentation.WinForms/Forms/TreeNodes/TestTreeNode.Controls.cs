using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class TestTreeNode
    {

        private void InitializeComponent(IContainer container)
        {
            contextMenuStrip = new ContextMenuStrip(container);
            AddSectionToolStripMenuItem = new ToolStripMenuItem();
            PropertiesToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(40, 40);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { AddSectionToolStripMenuItem, PropertiesToolStripMenuItem });
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
            // AddSectionToolStripMenuItem
            // 
            AddSectionToolStripMenuItem.Name = "AddSectionToolStripMenuItem";
            AddSectionToolStripMenuItem.Size = new Size(360, 48);
            AddSectionToolStripMenuItem.Text = "AddSection";

            ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.ResumeLayout(false);
        }

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem AddSectionToolStripMenuItem;
        private ToolStripMenuItem PropertiesToolStripMenuItem;
    }
}
