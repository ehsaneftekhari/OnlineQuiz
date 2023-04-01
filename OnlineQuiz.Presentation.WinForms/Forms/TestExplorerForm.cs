using OnlineQuiz.Presentation.WinForms.Forms.TreeNodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestExplorerForm : Form
    {
        private TestExplorerForm(int testId = 0)
        {
            InitializeComponent();
            TestTreeNode testTreeNode = new TestTreeNode(components!, "Test1", 0);
            mainTreeView.Nodes.Add(testTreeNode);
        }

        public static TestExplorerForm Crete(int testId = 0)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new TestExplorerForm(testId);
            }
            return instance;
        }

        static TestExplorerForm instance;
    }
}
