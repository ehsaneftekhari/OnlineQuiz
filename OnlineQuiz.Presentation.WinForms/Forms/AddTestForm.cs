using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class AddTestForm : Form
    {
        ITestController testController;
        IFormHelper formHelper;

        private static AddTestForm instance;

        private AddTestForm(int userId, ITestController testController, IFormHelper formHelper)
        {
            InitializeComponent();
            UserId = userId;
            this.testController = testController;
            this.formHelper = formHelper;
        }

        public static AddTestForm Create(int userId, IServiceProvider serviceProvider)
        {
            if (instance == null || instance.IsDisposed)
            {
                ITestController testController = serviceProvider.GetRequiredService<ITestController>();
                IFormHelper formHelper = serviceProvider.GetRequiredService<IFormHelper>();
                instance = new AddTestForm(userId, testController, formHelper);
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
