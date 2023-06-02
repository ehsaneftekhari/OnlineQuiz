using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.Events.SectionEvents;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Events.SectionEvents;
using OnlineQuiz.Business.Logic.Events.TestEvents;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Business.Models.Models.Tests;
using System.ComponentModel;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class TestTreeNode : TreeNode
    {
        IServiceProvider serviceProvider;
        ITestService testServices;
        ISectionService sectionServices;
        IQuestionService questionServices;
        IContainer container;
        ICustomEventAggregator eventAggregator;
        IDelegateContainer delegateContainer;

        public TestTreeNode(IServiceProvider serviceProvider,
                            IContainer container,
                            int testId) : base()
        {
            this.serviceProvider = serviceProvider;
            this.testServices = serviceProvider.GetRequiredService<ITestService>();
            this.sectionServices = serviceProvider.GetRequiredService<ISectionService>();
            this.questionServices = serviceProvider.GetRequiredService<IQuestionService>();
            this.eventAggregator = serviceProvider.GetRequiredService<ICustomEventAggregator>();
            this.sectionTreeNodes = new();
            this.delegateContainer = serviceProvider.GetRequiredService<IDelegateContainer>();
            this.container = container;
            TestId = testId;
            InitializeComponent(container);
            ReLoadSections();

            eventAggregator.Subscribe<TestUpdatedEvent, TestEventsPayload>(SetTestData);
            eventAggregator.Subscribe<SectionDeleteEvent, SectionEventsPayload>(OnSectionDelete);
            eventAggregator.Subscribe<SectionAddEvent, SectionEventsPayload>(OnSectionAdded);
        }

        public Action<TestTreeNode> TestNodeCloser { get; set; }

        private List<SectionTreeNode> sectionTreeNodes { get; set; }

        public int TestId { get; set; }

        private string _TestTitle;

        public string TestTitle
        {
            get => _TestTitle;
            set
            {
                _TestTitle = value;
                Text = _TestTitle;
            }
        }

        public void LoadTestData()
        {
            Test test = GetTestFromDatabase(TestId);
            SetTestData(test);
        }

        void SetTestData(TestEventsPayload payload) => SetTestData(payload.Test);

        void SetTestData(Test test) => TestTitle = test.Title.Value!;

        Test GetTestFromDatabase(int testId) => testServices.GetTest(testId);

        void AddChildNode(SectionTreeNode sectionTreeNode) 
        {
            sectionTreeNodes.Add(sectionTreeNode);
            Nodes.Add(sectionTreeNode);
        }

        void RemoveChildNode(int sectionId)
        {
            //todo: Use remove instead of RemoveAt
            int index = sectionTreeNodes.Select((STN, index) => (STN, index)).First(x => x.STN.SectionId == sectionId).index;
            Nodes.RemoveAt(index);
            sectionTreeNodes.RemoveAt(index);
        }

        void AddChildNodeRange(List<SectionTreeNode> sectionTreeNodeList) 
        {
            sectionTreeNodes.AddRange(sectionTreeNodeList);
            Nodes.AddRange(sectionTreeNodeList.ToArray()); 
        }

        List<SectionViewModel> GetSectionViewModelsOfTest() => sectionServices.GetSectionViewModelList(TestId);

        SectionViewModel GetSectionViewModel(int sectionId) => sectionServices.GetSection(sectionId).ToViewModel();

        SectionTreeNode CreateNewSectionTreeNode(SectionViewModel SectionViewModel)
        {
            var sectionTreeNode = new SectionTreeNode(serviceProvider,
                    container,
                    SectionViewModel.SectionTitle,
                    SectionViewModel.Order,
                    SectionViewModel.SectionId,
                    TestId);
            sectionTreeNode.ChildFormAdder += InvokeChildFormAdder;
            return sectionTreeNode;
        }

        void OnSectionAdded(SectionEventsPayload payload)
        {
            if (payload == null || payload.Section.TestId != TestId)
                return;

            AddSectionFromSeedDate(payload.Section.SectionId);
        }

        void OnSectionDelete(SectionEventsPayload payload)
        {
            if (payload == null || payload.Section.TestId != TestId)
                return;

            RemoveChildNode(payload.Section.SectionId);
        }

        void AddSectionFromSeedDate(int sectionId)
        {
            SectionViewModel section = GetSectionViewModel(sectionId);

            var sectionTreeNode = CreateNewSectionTreeNode(section);

            AddChildNode(sectionTreeNode);
        }

        void ReLoadSections()
        {
            ClearSectionNodes();

            List<SectionViewModel> sectionViewModelList = GetSectionViewModelsOfTest();

            List<SectionTreeNode> sectionTreeList = sectionViewModelList.Select(SVM => CreateNewSectionTreeNode(SVM)).ToList();

            AddChildNodeRange(sectionTreeList);
        }

        void ClearSectionNodes() => Nodes.Clear();

        void PropertiesToolStripMenuItem_Click(object sender, EventArgs e) => OpenTestPropertiesForm();

        void OpenTestPropertiesForm()
        {
            TestPropertiesForm testPropertiesForm = TestPropertiesForm.Create(TestId, 0, serviceProvider);
            InvokeChildFormAdder(testPropertiesForm);
        }

        void InvokeChildFormAdder(Form childForm)
        {
            if (delegateContainer.NewChildFormAdder != null)
                delegateContainer.NewChildFormAdder.Invoke(childForm);
        }

        private void CloseToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            InvokeTestNodeCloser();
        }

        private void InvokeTestNodeCloser()
        {
            if (TestNodeCloser != null)
                TestNodeCloser.Invoke(this);
        }

        private void AddSectionToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = AddSectionForm.Create(TestId, serviceProvider);
            InvokeChildFormAdder(addSectionForm);
        }
    }
}
