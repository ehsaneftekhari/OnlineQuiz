using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;
using System;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class AddTestForm : Form
    {
        IServiceProvider serviceProvider;
        ITestController testController;
        IFormHelper formHelper;

        private static AddTestForm instance;

        private AddTestForm(int userId, IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
            UserId = userId;
            testController = serviceProvider.GetRequiredService<ITestController>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            
        }

        public static AddTestForm Create(int userId, IServiceProvider serviceProvider)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddTestForm(userId, serviceProvider);
            }
            return instance;
        }

        int UserId { get; set; }

        public Action<Test, bool> OnTestAdded { get; set; }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddTest();
        }

        void AddTest()
        {
            Test newTest = new Test(UserId, TitleTB.Text, PublishCkB.Checked, RandomizeSectionsCkB.Checked);

            testController.AddTest(newTest);

            formHelper.FillForm(newTest.Title, TitleTB, TitleMessageLbl);

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
