namespace OnlineQuiz.Business.Models.Models.Sections
{
    public class SectionViewModel
    {
        public int SectionId;
        public int TestId;
        public string SectionTitle;
        public DateTime? Start;
        public DateTime? End;
        public TimeSpan? Duration;
        public int? Order;
        public int? AttemptLimit;
        public bool RandomizeQuestions;
        public bool DisplayResult;
        public bool AllowEdit;

        public SectionViewModel(int sectionId,
                                int testId,
                                string sectionTitle,
                                DateTime? start,
                                DateTime? end,
                                TimeSpan? duration,
                                int? order,
                                int? attemptLimit,
                                bool randomizeQuestions,
                                bool displayResult,
                                bool allowEdit)
        {
            SectionId = sectionId;
            TestId = testId;
            SectionTitle = sectionTitle;
            Start = start;
            End = end;
            Duration = duration;
            Order = order;
            AttemptLimit = attemptLimit;
            RandomizeQuestions = randomizeQuestions;
            DisplayResult = displayResult;
            AllowEdit = allowEdit;
        }
    }
}
