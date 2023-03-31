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
        public TestExplorerForm()
        {
            components = new System.ComponentModel.Container();
            InitializeComponent();
            TestTreeNode testTreeNode = new TestTreeNode(components, "Testi", 0);
            mainTreeView.Nodes.Add(testTreeNode);
        }
    }
}
