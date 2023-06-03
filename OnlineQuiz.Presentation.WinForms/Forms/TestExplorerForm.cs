using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Library;
using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestExplorerForm : Form
    {
        IServiceProvider serviceProvider;
        IDelegateContainer delegateContainer;
        private TestExplorerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
            this.delegateContainer = serviceProvider.GetRequiredService<IDelegateContainer>();
        }

        public static TestExplorerForm Crete(IServiceProvider serviceProvider)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TestExplorerForm(serviceProvider);
            }
            return instance;
        }

        static TestExplorerForm instance;

        public void OpenTest(int testId = 0)
        {
            if (testId != 0 && HasTestId(testId))
            {
                TestTreeNode testTreeNode = new TestTreeNode(serviceProvider, components, testId);
                testTreeNode.TestNodeCloser += RemoveTestTreeNode;
                OneTimeAddTestTreeNode(testTreeNode);
            }
        }

        void ClearTreeView()
        {
            mainTreeView.Nodes.Clear();
        }

        void OneTimeAddTestTreeNode(TestTreeNode testTreeNode)
        {
            ThrowHelper.ThrowNullArgumentException(testTreeNode, nameof(testTreeNode));

            if (HasTestId(testTreeNode.TestId))
            {
                testTreeNode.LoadTestData();
                mainTreeView.Nodes.Add(testTreeNode);
            }
        }

        bool HasTestId(int testId)
        {
            bool flag = true;
            foreach (TestTreeNode node in mainTreeView.Nodes)
            {
                if (node.TestId == testId)
                    flag = false;
            }
            return flag;
        }

        void RemoveTestTreeNode(TestTreeNode testTreeNode)
        {
            mainTreeView.Nodes.Remove(testTreeNode);
        }

        private void openTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvokeTestBrowseFormOpener();
        }

        private void InvokeTestBrowseFormOpener()
        {
            bool closeTestBrowseAfterSelect = true;
            if (delegateContainer.TestBrowseFormOpener != null)
                delegateContainer.TestBrowseFormOpener.Invoke(closeTestBrowseAfterSelect, nameof(TestExplorerForm));
        }

        private void clearExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTreeView();
        }
    }
}

