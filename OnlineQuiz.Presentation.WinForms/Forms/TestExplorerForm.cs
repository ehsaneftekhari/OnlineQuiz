using OnlineQuiz.Library;
using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestExplorerForm : Form
    {
        IServiceProvider serviceProvider;

        private TestExplorerForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
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

        public Action<bool, string> TestBrowseFormOpener { get; set; }

        public Action<Form> ChildFormAdder { get; set; }

        public void OpenTest(int testId = 0)
        {
            if (testId != 0 && HasTestId(testId))
            {
                TestTreeNode testTreeNode = new TestTreeNode(serviceProvider, components, testId);
                testTreeNode.ChildFormAdder += ChildFormAdder;
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
            if (TestBrowseFormOpener != null)
                TestBrowseFormOpener.Invoke(closeTestBrowseAfterSelect, nameof(TestExplorerForm));
        }

        private void clearExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearTreeView();
        }
    }
}
