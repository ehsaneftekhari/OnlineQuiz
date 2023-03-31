using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;
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
    public partial class AddTestForm : Form
    {
        ITestController testController;
        IFormHelper formHelper;

        public AddTestForm(int userId, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            UserId = userId;
            testController = serviceProvider.GetRequiredService<ITestController>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
        }

        int UserId { get; set; }

        public Action<Test, bool> OnTestAdded { get; set; }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Test newTest = new Test(UserId, TitleTB.Text, PublishCkB.Checked, RandomizeSectionsCkB.Checked);

            testController.AddTest(newTest);

            formHelper.SetFromFieldModel(newTest.Title, TitleTB, TitleMessageLbl);

            if (newTest.HasId())
                InvokeTestAdded(newTest, OpenTestExplorerCkB.Checked);
        }

        private void InvokeTestAdded(Test newTest, bool OpenTestExplorer)
        {
            if (OnTestAdded != null)
            {
                OnTestAdded.Invoke(newTest, OpenTestExplorer);
            }
            Close();
        }
    }
}
