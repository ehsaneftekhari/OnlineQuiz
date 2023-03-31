using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class QuestionTreeNode : TreeNode
    {
        public int QuestionId { get; set; }

        public QuestionTreeNode(string text, int questionId) : base(text)
        {
            QuestionId = questionId;
        }
    }
}
