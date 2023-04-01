using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode : TreeNode
    {
        IQuestionController questionController;

        public int SectionId { get; set; }

        private int? _Order;
        public int? Order
        {
            get => _Order;
            set
            {
                _Order = value;
                UpdateText();
            }
        }

        private string _SectionTitle;
        public string SectionTitle
        {
            get => _SectionTitle;
            set
            {
                _SectionTitle = value;
                UpdateText();
            }
        }

        public SectionTreeNode(IQuestionController questionController, string sectionTitle, int? order, int sectionId)
        {
            SectionId = sectionId;
            Order = order;
            SectionTitle = sectionTitle;
            this.questionController = questionController;

            ReLoadQuestions();
        }

        public void AddChild(QuestionTreeNode sectionTreeNode) => Nodes.Add(sectionTreeNode);

        public void AddChild(List<QuestionTreeNode> sectionTreeNodeList) => Nodes.AddRange(sectionTreeNodeList.ToArray());

        private void ReLoadQuestions()
        {
            List<QuestionViewModel> questionViewModelList = questionController.GetQuestionList(SectionId);

            List<QuestionTreeNode> questionTreeNodeList 
                = questionViewModelList.Select(
                    QVM => new QuestionTreeNode(
                    QVM.QuestionId,
                    QVM.Text,
                    QVM.Order)
                ).ToList();

            AddChild(questionTreeNodeList);
        }

        private void UpdateText()
        {
            Text = "";

            if (Order != null)
                Text += Order + " _ ";

            Text += SectionTitle;
        }
    }
}
