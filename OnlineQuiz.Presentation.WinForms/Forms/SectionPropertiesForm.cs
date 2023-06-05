using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;
using OnlineQuiz.Presentation.WinForms.Helpers;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class SectionPropertiesForm : Form
    {
        public enum AfterAddEnum { None = 1, ClearForm, CloseForm }

        readonly ITestService testServices;
        readonly ISectionService sectionServices;
        readonly IFormHelper formHelper;

        Test _test;
        Section _section;

        static List<SectionPropertiesForm> instances;

        private SectionPropertiesForm(IServiceProvider serviceProvider, int testId, int sectionsId)
        {
            testServices = serviceProvider.GetRequiredService<ITestService>();
            formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            sectionServices = serviceProvider.GetRequiredService<ISectionService>();

            InitializeComponent();

            //AfterAddCB.DataSource = Enum.GetValues(typeof(AfterAddEnum));
            //AfterAddCB.SelectedIndex = 1;

            ClearForm();
            LoadTestSeedData(testId);
            UpdateRemainingTime();
            LoadSectionSeedData(sectionsId);
        }

        public static SectionPropertiesForm Create(int testId, int sectionsId, IServiceProvider serviceProvider)
        {
            if (instances == null)
                instances = new List<SectionPropertiesForm>();

            SectionPropertiesForm instance = instances.FirstOrDefault(x => x.SectionId == sectionsId)!;

            if (instance == null || instance.IsDisposed)
            {
                instance = new(serviceProvider, testId, sectionsId);
                instances.Add(instance);
            }

            return instance;
        }

        bool RemainingTimeVisible
        {
            get
            {
                //// for test:
                //if (RemainingTimeValuePB.Visible != RemainingTimeValueLbl.Visible != RemainingTimeLbl.Visible != RemainingTimeShouldBeVisible())
                //    throw new Exception();
                //

                return RemainingTimeValuePB.Visible;
            }
            set
            {
                RemainingTimeValuePB.Visible = value;
                RemainingTimeValueLbl.Visible = value;
                RemainingTimeLbl.Visible = value;
            }
        }

        bool DateTimeGBEnabled
        {
            get => DateTimeGB.Enabled;
            set => DateTimeGB.Enabled = value;
        }

        bool OrderNUDEnabled
        {
            get => OrderNUD.Enabled;
            set => OrderNUD.Enabled = value;
        }

        Test Test
        {
            get => _test;
            set
            {
                _test = value;
                FillTestInfoLabels(_test);
                SetDateTimeSettings(_test);
            }
        }

        int SectionId => _section.SectionId;

        bool UpdateRemainingTimeVisible() => RemainingTimeVisible = Test != null && Test.Start.Value != null && Test.End.Value != null;

        void LoadTestSeedData(int testId) => Test = GetTestSeedData(testId);

        Test GetTestSeedData(int testId) => testServices.GetTest(testId);

        void LoadSectionSeedData(int sectionId)
        {
            _section = GetSectionSeedData(sectionId);
            FillSectionForm(_section);
        }

        void EditSectionSeedData(Section section) => sectionServices.EditSection(section);

        Section GetSectionSeedData(int sectionId) => sectionServices.GetSection(sectionId);

        void FillTestInfoLabels(Test test)
        {
            var testViewModel = test.ToViewModel();

            TestTittleValueLbl.Text = testViewModel.Title;

            TestPublishedValueLbl.Text = testViewModel.Published ? "Published" : "Not Published";

            if (testViewModel.Start != null)
                TestStartDateTimeValueLbl.Text = testViewModel.Start.ToString();
            else
                TestStartDateTimeValueLbl.Text = "";

            if (testViewModel.Start != null)
                TestEndDateTimeValueLbl.Text = testViewModel.End.ToString();
            else
                TestEndDateTimeValueLbl.Text = "";

            TestRandomizeTypeValueLbl.Text = testViewModel.RandomizeType.ToString();
        }

        void SetDateTimeSettings(Test test)
        {
            DateTimeGBEnabled = true;
            SetStartDateTime(DateTime.Now);
            SetEndDateTime(DateTime.Now);

            UpdateRemainingTimeVisible();

            OrderNUDEnabled = true;

            switch (test.RandomizeType.Value)
            {
                case RandomizeType.FollowSectionsSetting:
                    break;

                case RandomizeType.RandomOnCompatibleTime:
                    OrderNUDEnabled = false;

                    SetOrder(0);
                    break;


                case RandomizeType.RandomAllSections:
                    DateTimeGBEnabled = false;

                    OrderNUDEnabled = false;
                    SetOrder(0);
                    break;
            }

            //For RandomOnCompatibleTime and RandomAllSections
            if (test.Start.Value != null && test.End.Value != null)
            {
                SetStartDateTime((DateTime)test.Start.Value!);
                SetEndDateTime((DateTime)test.End.Value!);
            }
        }

        void FillSectionForm(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            formHelper.FillForm(section.SectionTitle, TitleTB, TitleMessageLbl);

            if (DateTimeGBEnabled)
            {
                SetStartDateTime(DateTime.Now);
                if (section.Start.Value != null)
                {
                    SetStartDateTime(section.Start);
                    formHelper.SetMessage(section.Start, StartDateTimeMessageLbl);
                }

                SetEndDateTime(DateTime.Now);
                if (section.End.Value != null)
                {
                    SetEndDateTime(section.End);
                    formHelper.SetMessage(section.End, EndDateTimeMessageLbl);
                }
            }

            SetDuration(section.Duration);
            formHelper.SetMessage(section.Duration, DurationMessageLbl);

            SetOrder(section.Order);
            formHelper.SetMessage(section.Duration, OrderMessageLbl);

            formHelper.FillForm(section.AttemptLimit, AttemptLimitNUD);
            formHelper.FillForm(section.RandomizeQuestions, RandomizeQuestionsCkB);
            formHelper.FillForm(section.DisplayResult, DisplayResultCkB);
            formHelper.FillForm(section.AllowEdit, AllowEditCkB);
        }

        #region Duration
        void SetDuration(Field<TimeSpan?> field)
        {
            ThrowHelper.ThrowNullArgumentException(field, nameof(field));

            SetDurationFieldValues(field.Value);

            UpdateRemainingTime();

            formHelper.SetMessage(field, DurationMessageLbl);
        }

        void SetDurationFieldValues(TimeSpan? timeSpan)
        {
            DurationHoursNUD.Value = 0;
            DurationMinutesNUD.Value = 0;
            DurationSecondsNUD.Value = 0;

            if (timeSpan.HasValue)
            {
                DurationHoursNUD.Value = timeSpan.Value.Hours;
                DurationMinutesNUD.Value = timeSpan.Value.Minutes;
                DurationSecondsNUD.Value = timeSpan.Value.Seconds;
            }
        }

        void UpdateRemainingTime()
        {
            TimeSpan SumDurationOfOtherSections = TimeSpan.Zero;
            TimeSpan? TestDuration = null;

            if (Test != null)
            {
                SumDurationOfOtherSections = testServices.GetSectionsDurationSum(Test.TestId);
                TestDuration = Test.ToViewModel().Duration;
            }

            TimeSpan TotalRemainingDuration = SumDurationOfOtherSections + GetDurationFromForm();

            SetRemainingTime(TotalRemainingDuration, TestDuration);
        }

        void SetRemainingTime(TimeSpan? duration, TimeSpan? testDuration)
        {
            //TimeSpan? testDuration = Test.ToViewModel().Duration;
            SetRemainingTimeValuePB(duration, testDuration);
            SetRemainingTimeValueLbl(duration, testDuration);
        }

        void SetRemainingTimeValuePB(TimeSpan? duration, TimeSpan? testDuration)
        {

            if (testDuration != null && duration != null && duration.Value != TimeSpan.Zero && testDuration.Value != TimeSpan.Zero)
            {
                double percent = duration.Value / testDuration.Value * 100;
                if (percent > 100)
                    percent = 100;
                if (percent == double.NaN)
                    percent = 0;
                RemainingTimeValuePB.Value = (int)percent;
            }
            else
                RemainingTimeValuePB.Value = 0;
        }

        void SetRemainingTimeValueLbl(TimeSpan? duration, TimeSpan? testDuration)
        {
            RemainingTimeValueLbl.Text = string.Empty;
            if (testDuration != null && duration != null && duration.Value != TimeSpan.Zero && testDuration.Value != TimeSpan.Zero)
                RemainingTimeValueLbl.Text = (testDuration.Value - duration).ToString();
        }

        TimeSpan GetDurationFromForm()
        {
            return new((int)DurationHoursNUD.Value,
                       (int)DurationMinutesNUD.Value,
                       (int)DurationSecondsNUD.Value);
        }

        #endregion

        void SetStartDateTime(DateTime dateTime)
        {
            ThrowHelper.ThrowNullArgumentException(dateTime, nameof(dateTime));

            Field<DateTime?> field = new Field<DateTime?>();
            field.Value = dateTime;
            SetStartDateTime(field);
        }

        void SetStartDateTime(Field<DateTime?> field)
        {
            formHelper.FillForm(field, StartDateDTP, StartDateTimeMessageLbl);
            formHelper.FillForm(field, StartTimeDTP);
        }

        void SetEndDateTime(DateTime dateTime)
        {
            ThrowHelper.ThrowNullArgumentException(dateTime, nameof(dateTime));

            Field<DateTime?> field = new Field<DateTime?>();
            field.Value = dateTime;
            SetEndDateTime(field);
        }

        void SetEndDateTime(Field<DateTime?> field)
        {
            formHelper.FillForm(field, EndDateDTP, EndDateTimeMessageLbl);
            formHelper.FillForm(field, EndTimeDTP);
        }

        void SetOrder(int order)
        {
            Field<int?> field = new Field<int?>();
            field.Value = order;
            SetOrder(field);
        }

        void SetOrder(Field<int?> field) => formHelper.FillForm(field, OrderNUD, OrderMessageLbl);

        void ClearForm() => FillSectionForm(new Section());

        Section GetFormValue()
        {
            int testId = Test.TestId;
            string sectionTitle = TitleTB.Text;
            DateTime? start = formHelper.CombineDateTime(StartDateDTP.Value, StartTimeDTP.Value);
            DateTime? end = formHelper.CombineDateTime(EndDateDTP.Value, EndTimeDTP.Value);
            TimeSpan? duration = GetDurationFromForm();
            int? order = (int)OrderNUD.Value;
            int? attemptLimit = (int)AttemptLimitNUD.Value;
            bool randomizeQuestions = RandomizeQuestionsCkB.Checked;
            bool displayResult = DisplayResultCkB.Checked;
            bool allowEdit = AllowEditCkB.Checked;

            Section section = new(testId,
                                     sectionTitle,
                                     start,
                                     end,
                                     duration,
                                     order,
                                     attemptLimit,
                                     randomizeQuestions,
                                     displayResult,
                                     allowEdit);

            return section;
        }

        void UpdateSection()
        {
            Section section = GetFormValue();
            section.SectionId = SectionId;
            EditSectionSeedData(section);
            FillSectionForm(section);
        }

        private void CancelBtn_Click(object sender, EventArgs e) => Close();

        private void Duration_ValueChanged(object sender, EventArgs e) => UpdateRemainingTime();

        private void ApplyBtn_Click(object sender, EventArgs e) => UpdateSection();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            UpdateSection();
            Close();
        }
    }
}
