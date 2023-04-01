using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestExplorerForm : Form
    {
        ITestController testController;
        ISectionController sectionController;
        IQuestionController questionController;

        private TestExplorerForm(ITestController testController,
                                 ISectionController sectionController,
                                 IQuestionController questionController)
        {
            InitializeComponent();
            this.testController = testController;
            this.sectionController = sectionController;
            this.questionController = questionController;
        }

        public static TestExplorerForm Crete(IServiceProvider serviceProvider, int testId = 0)
        {
            if (instance == null || instance.IsDisposed)
            {
                ITestController testController = serviceProvider.GetRequiredService<ITestController>();
                ISectionController sectionController = serviceProvider.GetRequiredService<ISectionController>();
                IQuestionController questionController = serviceProvider.GetRequiredService<IQuestionController>();
                instance = new TestExplorerForm(testController, sectionController, questionController);
            }
            instance.OpenTest(testId);
            return instance;
        }

        static TestExplorerForm instance;

        void OpenTest(int testId = 0)
        {
            if (testId != 0)
            {
                Test test = GetTestSeedData(testId);
                AddTestTreeNode(test);
            }
        }

        Test GetTestSeedData(int testId)
        {
            return testController.GetTest(testId);
        }

        void AddTestTreeNode(Test test)
        {
            ThrowHelper.ThrowNullArgumentException(test,
                nameof(test),
                test.Title,
                nameof(test.Title));

            bool flag = true;
            foreach (TestTreeNode node in mainTreeView.Nodes)
            {
                if (node.TestId == test.TestId)
                    flag = false;
            }

            if (flag)
            {
                TestTreeNode testTreeNode = new TestTreeNode(testController,
                                                             sectionController,
                                                             questionController,
                                                             components!,
                                                             test.Title.Value!,
                                                             test.TestId);
                mainTreeView.Nodes.Add(testTreeNode);
            }
        }
    }
}
