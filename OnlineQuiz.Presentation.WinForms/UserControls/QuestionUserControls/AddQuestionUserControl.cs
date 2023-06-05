using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Presentation.WinForms.UserControls.QuestionUserControls
{
    public partial class AddQuestionUserControl : UserControl
    {
        readonly IServiceProvider serviceProvider;
        readonly IQuestionService questionService;
        readonly ISectionService sectionService;

        public AddQuestionUserControl(IServiceProvider serviceProvider,
                                      SectionViewModel section)
        {
            this.serviceProvider = serviceProvider;
            this.questionService = serviceProvider.GetRequiredService<IQuestionService>();
            this.sectionService = serviceProvider.GetRequiredService<ISectionService>();
            this.Section = section;

            InitializeComponent();
            UpdateRemainingTime();
            ClearAfterAddRBtn.Checked = true;
        }

        SectionViewModel Section { get; set; }

        #region From
        string Text
        {
            get => TextRTB.Text;
            set => TextRTB.Text = value;
        }

        string ImageAddress
        {
            get => ImageAddressTB.Text;
            set => ImageAddressTB.Text = value;
        }

        int Score
        {
            get => (int)ScoreNUD.Value;
            set => ScoreNUD.Value = value;
        }

        int Order
        {
            get => (int)OrderNUD.Value;
            set => OrderNUD.Value = value;
        }

        TimeSpan Duration
        {
            get => GetDurationFromForm();
            set
            {
                SetDurationFieldValues(value);
                UpdateRemainingTime();
            }
        }

        Question GetDataFromForm()
        {
            var question = new Question(Section.SectionId, Text, ImageAddress, Score, Duration, Order);

            return question;
        }

        void ClearForm()
        {
            Text = string.Empty;
            ImageAddress = string.Empty;
            Score = 0;
            Duration = TimeSpan.Zero;
            Order = 0;
        }

        #region Duration

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

        TimeSpan GetDurationFromForm()
        {
            return new((int)DurationHoursNUD.Value,
                       (int)DurationMinutesNUD.Value,
                       (int)DurationSecondsNUD.Value);
        }

        void UpdateRemainingTime()
        {
            TimeSpan remainingDuration = TimeSpan.Zero;

            if (Section != null)
            {
                remainingDuration = sectionService.GetRemainingDuration(Section.SectionId, out var _);
                SetRemainingTime(remainingDuration, GetDurationFromForm());
            }
        }

        void SetRemainingTime(TimeSpan? durationCapacity, TimeSpan? questionDuration)
        {
            //TimeSpan? testDuration = Test.ToViewModel().Duration;
            SetRemainingTimeValuePB(durationCapacity, questionDuration);
            SetRemainingTimeValueLbl(durationCapacity, questionDuration);
        }

        void SetRemainingTimeValuePB(TimeSpan? durationCapacity, TimeSpan? questionDuration)
        {

            if (durationCapacity != null && questionDuration != null && questionDuration.Value != TimeSpan.Zero)
            {
                if (durationCapacity.Value != TimeSpan.Zero)
                    RemainingTimeValuePB.Value = 100;
                else
                {
                    double percent = questionDuration.Value / durationCapacity.Value * 100;
                    if (percent > 100)
                        percent = 100;
                    if (percent == double.NaN)
                        percent = 0;
                    RemainingTimeValuePB.Value = (int)percent;
                }
            }
            else
                RemainingTimeValuePB.Value = 0;
        }

        void SetRemainingTimeValueLbl(TimeSpan? durationCapacity, TimeSpan? questionDuration)
        {
            RemainingTimeValueLbl.Text = string.Empty;
            if (durationCapacity != null && questionDuration != null)
                RemainingTimeValueLbl.Text = (durationCapacity.Value - questionDuration).ToString();
        }

        #endregion

        #endregion

        #region Service Calls
        void AddQuestion(Question question) => questionService.AddQuestion(question);

        #endregion

        #region UI Actions
        public void RemoveThisControl()
        {
            this.Parent.Controls.Remove(this);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var newQuestion = GetDataFromForm();

            var addResult = AddNewQuestion(newQuestion);

            if (addResult && CloseAfterAddRBtn.Checked)
                RemoveThisControl();

            if (addResult && ClearAfterAddRBtn.Checked)
                ClearForm();
        }

        private void DurationNUD_ValueChanged(object sender, EventArgs e) => UpdateRemainingTime();

        private void CloseAfterAddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CloseAfterAddRBtn.Checked)
                ClearAfterAddRBtn.Checked = false;
        }

        private void ClearAfterAddRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ClearAfterAddRBtn.Checked)
                CloseAfterAddRBtn.Checked = false;
        }
        #endregion UI Actions


        bool AddNewQuestion(Question newQuestion)
        {
            AddQuestion(newQuestion);

            if (!newQuestion.IsFine())
            {
                var messages = string.Concat(newQuestion.Messages.Select(message => message + "\n"));
                MessageBox.Show(messages, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
