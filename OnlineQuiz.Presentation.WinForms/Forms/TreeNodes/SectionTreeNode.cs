using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.Events.QuestionEvents;
using OnlineQuiz.Business.Abstractions.Events.SectionEvents;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Events.SectionEvents;
using OnlineQuiz.Business.Models.Models.Questions;
using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class SectionTreeNode : TreeNode
    {
        readonly IQuestionService questionServices;
        readonly IServiceProvider serviceProvider;
        readonly ISectionService sectionServices;
        readonly ICustomEventAggregator eventAggregator;
        readonly IDelegateContainer delegateContainer;
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
            this.eventAggregator = serviceProvider.GetRequiredService<ICustomEventAggregator>();
            this.delegateContainer = serviceProvider.GetRequiredService<IDelegateContainer>();

            eventAggregator.Subscribe<SectionUpdateEvent, SectionEventsPayload>(OnSectionEdited);
            eventAggregator.Subscribe<QuestionAddEvent, QuestionEventsPayload>(OnQuestionAdded);

            SectionId = sectionId;
            SectionTitle  = sectionTitle;
            Order = order;
            TestId = testId;
            InitializeComponent(container);
            ReLoadQuestions();
        }

        public int SectionId { get; set; }

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

        void InvokeChildFormAdder(Form childForm)
        {
            if (delegateContainer.NewChildFormAdder != null)
                delegateContainer.NewChildFormAdder.Invoke(childForm);
        }

        void OnSectionEdited(ISectionEventsPayload payload)
        {
            if (payload == null || payload.Section.SectionId != SectionId)
                return;

            SectionTitle = payload.Section.SectionTitle.Value ?? "";
            Order = payload.Section.Order.Value ?? 0;
        }

        void OnQuestionAdded(IQuestionEventsPayload payload)
        {
            if (payload == null || payload.Question.sectionId != SectionId)
                return;

            var questionTreeNode = new QuestionTreeNode(
                    payload.Question.questionId,
                    payload.Question.text.Value ?? "",
                    payload.Question.order.Value ?? 0);

            AddChild(questionTreeNode);
        }

        void AddChild(QuestionTreeNode sectionTreeNode) => Nodes.Add(sectionTreeNode);

        void AddChild(List<QuestionTreeNode> sectionTreeNodeList) => Nodes.AddRange(sectionTreeNodeList.ToArray());

        void ReLoadQuestions()
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

        void UpdateText()
        {
            Text = "";

            if (Order != null)
                Text += Order + " _ ";

            Text += SectionTitle;
        }

        void PropertiesToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            SectionPropertiesForm addSectionForm = SectionPropertiesForm.Create(TestId, SectionId, serviceProvider);
            InvokeChildFormAdder(addSectionForm);
        }

        void DeleteToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            var result = sectionServices.DeleteSection(SectionId);

            if (result.result == DeleteResult.Failed)
                MessageBox.Show(result.message);
        }

        void AddSectionToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            QuestionDesignForm questionDesignForm = QuestionDesignForm.Crete(serviceProvider, TestId, SectionId);
            InvokeChildFormAdder(questionDesignForm);
        }
    }
}
