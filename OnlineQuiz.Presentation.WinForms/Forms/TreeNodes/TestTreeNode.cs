using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Business.Models.Models.Tests;
using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class TestTreeNode : TreeNode
    {
        IServiceProvider serviceProvider;
        ITestController testController;
        ISectionController sectionController;
        IQuestionController questionController;
        IContainer container;

        public TestTreeNode(IServiceProvider serviceProvider,
                            IContainer container,
                            int testId) : base()
        {
            this.serviceProvider = serviceProvider;
            this.testController = serviceProvider.GetRequiredService<ITestController>();
            this.sectionController = serviceProvider.GetRequiredService<ISectionController>();
            this.questionController = serviceProvider.GetRequiredService<IQuestionController>();
            this.container = container;
            TestId = testId;
            InitializeComponent(container);
            ReLoadSections();
        }

        public Action<Form> ChildFormAdder { get; set; }

        public Action<TestTreeNode> TestNodeCloser { get; set; }

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
            Test test = GetTestSeedData(TestId);
            SetTestData(test);
        }

        void SetTestData(Test test)
        {
            TestTitle = test.Title.Value!;
        }

        Test GetTestSeedData(int testId)
        {
            return testController.GetTest(testId);
        }

        void AddChildNode(SectionTreeNode sectionTreeNode) => Nodes.Add(sectionTreeNode);

        void AddChildNodeRange(List<SectionTreeNode> sectionTreeNodeList) => Nodes.AddRange(sectionTreeNodeList.ToArray());

        List<SectionViewModel> GetSectionViewModelsOfTest() => sectionController.GetSectionViewModelList(TestId);

        SectionViewModel GetSectionViewModel(int sectionId) => sectionController.GetSection(sectionId).ToViewModel();

        SectionTreeNode CreateNewSectionTreeNode(SectionViewModel SectionViewModel)
        {
            var sectionTreeNode = new SectionTreeNode(serviceProvider,
                    container,
                    SectionViewModel.SectionTitle,
                    SectionViewModel.Order,
                    SectionViewModel.SectionId,
                    TestId);
            sectionTreeNode.ChildFormAdder += InvokeChildFormAdder;
            sectionTreeNode.OnSectionEdited += ReLoadSections;
            sectionTreeNode.OnSectionDelete += ReLoadSections;
            return sectionTreeNode;
        }

        void AddSectionFromSeedDate(int sectionId)
        {
            SectionViewModel section = GetSectionViewModel(sectionId);

            var sectionTreeNode = CreateNewSectionTreeNode(section);

            AddChildNode(sectionTreeNode);

            //ReLoadSections();
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
            testPropertiesForm.OnTestSaved -= SetTestData;
            testPropertiesForm.OnTestSaved += SetTestData;
            InvokeChildFormAdder(testPropertiesForm);
        }

        void InvokeChildFormAdder(Form childForm)
        {
            if (ChildFormAdder != null)
                ChildFormAdder.Invoke(childForm);
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
            addSectionForm.OnSectionAdded -= AddSectionFromSeedDate;
            addSectionForm.OnSectionAdded += AddSectionFromSeedDate;
            InvokeChildFormAdder(addSectionForm);
        }
    }
}
