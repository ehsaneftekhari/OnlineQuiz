using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class TestTreeNode : TreeNode
    {
        public int TestId { get; set; }

        public TestTreeNode(IContainer container, string text, int testId) : base(text)
        {
            InitializeComponent(container);
            TestId = testId;
        }

        public void AddChild(SectionTreeNode sectionTreeNode)
        {
            Nodes.Add(sectionTreeNode);
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = sender.GetType();
        }
    }
}
