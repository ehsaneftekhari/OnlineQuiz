using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Tests;
using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode : TreeNode
    {
        readonly IQuestionService questionServices;
        readonly IServiceProvider serviceProvider;
        readonly ISectionService sectionServices;
        int? _Order;

        string _SectionTitle;

        public SectionTreeNode(IServiceProvider serviceProvider,
                               IContainer container,
                               string sectionTitle,
                               int? order,
                               int sectionId,
                               int testId) : base()
        {
            this.serviceProvider = serviceProvider;
            this.questionServices = serviceProvider.GetRequiredService<IQuestionService>();
            this.sectionServices = serviceProvider.GetRequiredService<ISectionService>();
            SectionId = sectionId;
            SectionTitle  = sectionTitle;
            Order = order;
            TestId = testId;
            InitializeComponent(container);
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

        public Action OnSectionDelete { get; set; }

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

        void InvokeSectionDelete()
        {
            if (OnSectionDelete != null)
                OnSectionDelete.Invoke();
        }

        public void AddChild(QuestionTreeNode sectionTreeNode) => Nodes.Add(sectionTreeNode);

        public void AddChild(List<QuestionTreeNode> sectionTreeNodeList) => Nodes.AddRange(sectionTreeNodeList.ToArray());

        private void ReLoadQuestions()
        {
            List<QuestionViewModel> questionViewModelList = questionServices.GetQuestionList(SectionId);

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

        private void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            var result = sectionServices.DeleteSection(SectionId);

            if (result.result == DeleteResult.Failed)
                MessageBox.Show(result.message);

            if (result.result == DeleteResult.Success)
                InvokeSectionDelete();
        }
    }
}
