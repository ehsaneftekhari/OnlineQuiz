using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Events.EventAggregators;
using OnlineQuiz.Business.Logic.Events.TestEvents;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class AddTestForm : Form
    {
        IAppMessageService appMessageServices;
        ITestService testServices;
        IFormHelper formHelper;
        IDelegateContainer delegateContainer;

        private static AddTestForm instance;

        private AddTestForm(int userId, IServiceProvider serviceProvider)
        {
            testServices = serviceProvider.GetRequiredService<ITestService>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            appMessageServices = serviceProvider.GetRequiredService<IAppMessageService>();
            delegateContainer = serviceProvider.GetRequiredService<IDelegateContainer>();

            InitializeComponent();
            RandomizeTypeCB.SelectedIndex = 0;
            UserId = userId;

            DateTime Now = DateTime.Now;
            StartDateDTP.Value = Now;
            StartTimeDTP.Value = Now;
            EndDateDTP.Value = Now;
            EndTimeDTP.Value = Now;


            TitleMessageLbl.Text = string.Empty;
            RandomizeTypeMessageLbl.Text = string.Empty;
            StartDateTimeMessageLbl.Text = string.Empty;
            EndDateTimeMessageLbl.Text = string.Empty;
            this.delegateContainer = delegateContainer;
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
            DateTime? start = null;
            DateTime? end = null;
            if (PickDateTimeCkB.Checked)
            {
                start = formHelper.CombineDateTime(StartDateDTP.Value, StartTimeDTP.Value);
                end = formHelper.CombineDateTime(EndDateDTP.Value, EndTimeDTP.Value);
            }
            Test newTest = new Test(UserId,
                                    TitleTB.Text,
                                    start,
                                    end,
                                    PublishCkB.Checked,
                                    (RandomizeType)RandomizeTypeCB.SelectedIndex);

            testServices.AddTest(newTest);

            bool hasId = newTest.HasId();

            if (hasId && OpenInTestExplorerCkB.Checked)
                InvokeTestExplorerOpener(newTest);

            bool close = hasId && CloseFormCkB.Checked;

            if (close)
                Close();
            else
                FillForm(newTest);

            if (hasId && !close)
                MessageBox.Show(appMessageServices.GetMessage("en_AddTestForm_TestAddedSuccessfully"));
        }

        void FillForm(Test newTest)
        {
            if (newTest != null)
            {
                formHelper.FillForm(newTest.Title, TitleTB, TitleMessageLbl);
                RandomizeTypeCB.SelectedIndex = (int)newTest.RandomizeType.Value;
                formHelper.SetMessage(newTest.RandomizeType, RandomizeTypeMessageLbl);
                formHelper.FillForm(newTest.Start, StartDateDTP, StartDateTimeMessageLbl);
                formHelper.FillForm(newTest.Start, StartTimeDTP);
                formHelper.FillForm(newTest.End, EndDateDTP, EndDateTimeMessageLbl);
                formHelper.FillForm(newTest.End, EndTimeDTP);
                formHelper.FillForm(newTest.Published, PublishCkB);
            }
        }

        void ClearForm()
        {
            FillForm(new Test(0, "", null, null, false, RandomizeType.FollowSectionsSetting));
            PickDateTimeCkB.Checked = false;
        }

        void InvokeTestExplorerOpener(Test newTest)
        {
            if (delegateContainer.TestExplorerFormOpener != null)
                delegateContainer.TestExplorerFormOpener.Invoke(newTest.TestId);
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

        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
