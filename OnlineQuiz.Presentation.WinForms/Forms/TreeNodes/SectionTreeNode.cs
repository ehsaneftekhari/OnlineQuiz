using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode : TreeNode
    {
        public int SectionId { get; set; }

        public SectionTreeNode(string text, int sectionId) : base(text)
        {
            SectionId = sectionId;
        }

        public void AddChild(QuestionTreeNode sectionTreeNode)
        {
            Nodes.Add(sectionTreeNode);
        }
    }
}
