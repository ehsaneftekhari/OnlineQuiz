namespace OnlineQuiz.Business.Models.Models.Questions
{
    public class QuestionViewModel
    {
        public int QuestionId;
        public int SectionId;
        public string Text;
        public string ImageAddress;
        public double? Score;
        public TimeSpan? Duration;
        public int? Order;

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
    }
}
