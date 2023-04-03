using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestPropertiesForm : Form
    {
        IServiceProvider serviceProvider;
        ITestController testController;
        IFormHelper formHelper;

        private static List<TestPropertiesForm> instances;

        private TestPropertiesForm(int testId, IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
            TestId = testId;
            testController = serviceProvider.GetRequiredService<ITestController>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            var test = GetSeedData();
            FillForm(test);
        }

        public static TestPropertiesForm Create(int testId, int userId, IServiceProvider serviceProvider)
        {
            if (instances == null)
                instances = new List<TestPropertiesForm>();

            TestPropertiesForm instance = instances.FirstOrDefault(x => x.TestId == testId);

            if (instance == null || instance.IsDisposed)
            {
                instance = new TestPropertiesForm(testId, serviceProvider);
                instances.Add(instance);
            }

            return instance;
        }

        int TestId { get; set; }

        public Action<Test> OnTestSaved { get; set; }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            EditTest();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            EditTest();
            Close();
        }

        Test GetSeedData()
        {
            return testController.GetTest(TestId);
        }

        void FillForm(Test test)
        {
            formHelper.FillForm(test.Title, TitleTB, TitleMessageLbl);
            formHelper.FillForm(test.RandomizeSections, RandomizeSectionsCkB);
            formHelper.FillForm(test.Published, PublishCkB);
        }

        void EditTest()
        {
            Test editedTest = new Test(TestId, 0, TitleTB.Text, PublishCkB.Checked, RandomizeSectionsCkB.Checked);

            bool editResult = testController.EditTest(editedTest);

            FillForm(GetSeedData());

            if (editResult)
                InvokeOnTestSaved(editedTest);
        }

        private void InvokeOnTestSaved(Test saveTest)
        {
            if (OnTestSaved != null)
            {
                OnTestSaved.Invoke(saveTest);
            }
        }
    }
}
