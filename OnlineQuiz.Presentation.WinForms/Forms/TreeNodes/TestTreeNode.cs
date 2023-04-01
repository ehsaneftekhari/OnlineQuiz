using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Library;
using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms.Forms.TreeNodes
{
    public partial class TestTreeNode : TreeNode
    {
        ITestController testController;
        ISectionController sectionController;
        IQuestionController questionController;
        public int TestId { get; set; }
        public string TestTitle { get; set; }

        public TestTreeNode(ITestController testController,
                            ISectionController sectionController,
                            IQuestionController questionController,
                            IContainer container,
                            string testTitle,
                            int testId) : base(testTitle)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(testTitle, nameof(testTitle));

            InitializeComponent(container);
            TestId = testId;
            TestTitle = testTitle;
            this.testController = testController;
            this.sectionController = sectionController;
            this.questionController = questionController;

            ReLoadSections();
        }

        private void AddChild(SectionTreeNode sectionTreeNode) => Nodes.Add(sectionTreeNode);

        private void AddChild(List<SectionTreeNode> sectionTreeNodeList) => Nodes.AddRange(sectionTreeNodeList.ToArray());


        private void ReLoadSections()
        {
            List<SectionViewModel> sectionViewModelList = sectionController.GetSectionList(TestId);

            List<SectionTreeNode> sectionTreeList = sectionViewModelList.Select(SVM => new SectionTreeNode(questionController,
                                                                                                           SVM.SectionTitle,
                                                                                                           SVM.Order,
                                                                                                           SVM.SectionId)).ToList();

            AddChild(sectionTreeList);
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = sender.GetType();
        }
    }
}
