using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Tests;
using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode : TreeNode
    {
        readonly IQuestionController questionController;
        readonly IServiceProvider serviceProvider;
        int? _Order;

        string _SectionTitle;

        public SectionTreeNode(IServiceProvider serviceProvider,
                               IContainer container,
                               string sectionTitle,
                               int? order,
                               int sectionId,
                               int testId) : base()
        {
            InitializeComponent(container);
            this.serviceProvider = serviceProvider;
            this.questionController = serviceProvider.GetRequiredService<IQuestionController>();
            SectionId = sectionId;
            SectionTitle  = sectionTitle;
            Order = order;
            TestId = testId;
            ReLoadQuestions();
        }

        int SectionId { get; set; }

        int TestId { get; set; }

        public int? Order
        {
            get => _Order;
            set
            {
                _Order = value;
                UpdateText();
            }
        }

        public string SectionTitle
        {
            get => _SectionTitle;
            set
            {
                _SectionTitle = value;
                UpdateText();
            }
        }

        public Action<Form> ChildFormAdder { get; set; }

        public Action OnSectionEdited { get; set; }

        void InvokeChildFormAdder(Form childForm)
        {
            if (ChildFormAdder != null)
                ChildFormAdder.Invoke(childForm);
        }

        void InvokeSectionEdited()
        {
            if (OnSectionEdited != null)
                OnSectionEdited.Invoke();
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

        private void PropertiesToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            SectionPropertiesForm addSectionForm = SectionPropertiesForm.Create(TestId, SectionId, serviceProvider);
            addSectionForm.OnSectionEdited -= SectionEdited;
            addSectionForm.OnSectionEdited += SectionEdited;
            InvokeChildFormAdder(addSectionForm);
        }

        private void SectionEdited(int SectionId)
        {
            InvokeSectionEdited();
        }
    }
}
