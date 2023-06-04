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
            CloseToolStripMenuItem = new ToolStripMenuItem();
            DesignQuestionsMenuItem = new ToolStripMenuItem();
            contextMenuStrip.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(40, 40);
            contextMenuStrip.Items.AddRange(new ToolStripItem[]
            {
                AddSectionToolStripMenuItem,
                CloseToolStripMenuItem,
                PropertiesToolStripMenuItem,
                DesignQuestionsMenuItem
            });
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
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(360, 48);
            CloseToolStripMenuItem.Text = "Close";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // AddSectionToolStripMenuItem
            // 
            AddSectionToolStripMenuItem.Name = "AddSectionToolStripMenuItem";
            AddSectionToolStripMenuItem.Size = new Size(360, 48);
            AddSectionToolStripMenuItem.Text = "Add Section";
            AddSectionToolStripMenuItem.Click += AddSectionToolStripMenuItem_Click;
            //
            //DesignQuestionsMenuItem
            //
            DesignQuestionsMenuItem.Name = "DesignQuestionsMenuItem";
            DesignQuestionsMenuItem.Size = new Size(360, 48);
            DesignQuestionsMenuItem.Text = "Design Questions";
            DesignQuestionsMenuItem.Click += DesignQuestionsMenuItem_Click;

            ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.ResumeLayout(false);
        }

        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem AddSectionToolStripMenuItem;
        private ToolStripMenuItem PropertiesToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem DesignQuestionsMenuItem;
    }
}
