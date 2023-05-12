using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Controllers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class TestPropertiesForm : Form
    {
        IServiceProvider serviceProvider;
        ITestService testController;
        IFormHelper formHelper;

        private static List<TestPropertiesForm> instances;

        private TestPropertiesForm(int testId, IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            testController = serviceProvider.GetRequiredService<ITestService>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            InitializeComponent();
            TestId = testId;

            TitleMessageLbl.Text = string.Empty;
            RandomizeTypeMessageLbl.Text = string.Empty;
            StartDateTimeMessageLbl.Text = string.Empty;
            EndDateTimeMessageLbl.Text = string.Empty;

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
            if (test != null)
            {
                formHelper.FillForm(test.Title, TitleTB, TitleMessageLbl);
                RandomizeTypeCB.SelectedIndex = (int)test.RandomizeType.Value;
                formHelper.SetMessage(test.RandomizeType, RandomizeTypeMessageLbl);
                formHelper.FillForm(test.Start, StartDateDTP, StartDateTimeMessageLbl);
                formHelper.FillForm(test.Start, StartTimeDTP);
                formHelper.FillForm(test.End, EndDateDTP, EndDateTimeMessageLbl);
                formHelper.FillForm(test.End, EndTimeDTP);
                formHelper.FillForm(test.Published, PublishCkB);
            }
        }

        void EditTest()
        {
            DateTime? start = null;
            DateTime? end = null;
            if (PickDateTimeCkB.Checked)
            {
                start = CombineDateTime(StartDateDTP.Value, StartTimeDTP.Value);
                end = CombineDateTime(EndDateDTP.Value, EndTimeDTP.Value);
            }
            Test editedTest = new Test(TestId,
                                    0,
                                    TitleTB.Text,
                                    start,
                                    end,
                                    PublishCkB.Checked,
                                    (RandomizeType)RandomizeTypeCB.SelectedIndex);

            bool editResult = testController.EditTest(editedTest);

            FillForm(editedTest);

            if (editResult)
                InvokeOnTestSaved(editedTest);
        }

        DateTime CombineDateTime(DateTime Date, DateTime Time)
        {
            DateTime dateTime = new(Date.Year, Date.Month, Date.Day, Time.Hour, Time.Minute, Time.Second);
            return dateTime;
        }

        private void InvokeOnTestSaved(Test saveTest)
        {
            if (OnTestSaved != null)
            {
                OnTestSaved.Invoke(saveTest);
            }
        }

        void RandomizeTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandomizeType randomizeType = (RandomizeType)RandomizeTypeCB.SelectedIndex;

            StatusMessageModel statusMessageModel = new StatusMessageModel();

            switch (randomizeType)
            {
                case RandomizeType.FollowSectionsSetting:
                    SetPickDateTimeCkB(false);
                    statusMessageModel.ClearMessage();
                    break;
                case RandomizeType.RandomAllSections:
                    SetPickDateTimeCkB(true, true);
                    statusMessageModel.ClearMessage();
                    break;
                case RandomizeType.RandomOnCompatibleTime:
                    SetPickDateTimeCkB(false);
                    statusMessageModel.ClearMessage();
                    break;
            }
            formHelper.SetMessage(statusMessageModel, RandomizeTypeMessageLbl);
        }

        private void SetPickDateTimeCkB(bool force, bool? value = null)
        {
            if (value != null)
                PickDateTimeCkB.Checked = (bool)value;

            PickDateTimeCkB.Enabled = !force;
        }

        private void PickDateTimeCkB_CheckStateChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;

            DateTimeGB.Enabled = checkBox.Checked;
        }
    }
}
