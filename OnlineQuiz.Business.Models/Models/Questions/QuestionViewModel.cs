namespace OnlineQuiz.Business.Models.Models.Questions
{
    public class QuestionViewModel
    {
        public QuestionViewModel(int questionId,
                                 int sectionId,
                                 string text,
                                 string imageAddress,
                                 double? score,
                                 TimeSpan? duration,
                                 int? order)
        {
            QuestionId = questionId;
            SectionId = sectionId;
            Text = text;
            ImageAddress = imageAddress;
            Score = score;
            Duration = duration;
            Order = order;
        }

        public int QuestionId { get; set; }

        public int SectionId { get; set; }

        public string Text { get; set; }

        public string ImageAddress { get; set; }

        public double? Score { get; set; }

        public TimeSpan? Duration { get; set; }

        public int? Order { get; set; }
    }
}
