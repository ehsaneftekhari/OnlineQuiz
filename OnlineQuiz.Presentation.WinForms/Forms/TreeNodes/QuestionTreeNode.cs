namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class QuestionTreeNode : TreeNode
    {
        public int QuestionId { get; set; }

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

        private string _QuestionText;
        public string QuestionText
        {
            get => _QuestionText;
            set
            {
                _QuestionText = value;
                UpdateText();
            }
        }

        public QuestionTreeNode(int questionId, string questionText, int? order)
        {
            QuestionId = questionId;
            QuestionText = questionText;
            Order = order;
        }

        private void UpdateText()
        {
            Text = "";

            if (Order != null)
                Text += Order + " _ ";

            Text += QuestionText;
        }
    }
}
