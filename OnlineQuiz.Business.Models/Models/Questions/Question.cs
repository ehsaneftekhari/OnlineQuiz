using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models.Questions
{
    public class Question : IFine, IIdContainer
    {
        int QuestionId;
        int SectionId;
        Field<string> Text;
        Field<string> ImageAddress;
        Field<double?> Score;
        Field<TimeSpan?> Duration;
        Field<int?> Order;

        private Question()
        {
            Text = new Field<string?>(string.Empty)!;
            ImageAddress = new Field<string?>(string.Empty)!;
            Score = new Field<double?>(0);
            Duration = new Field<TimeSpan?>(null);
            Order = new Field<int?>(null);
        }

        public Question(int questionId,
                        int sectionId,
                        string text,
                        string imageAddress,
                        double? score,
                        TimeSpan? duration,
                        int? order) : this()
        {
            QuestionId = questionId;
            SectionId = sectionId;
            Text!.Value = text;
            ImageAddress!.Value = imageAddress;
            Score!.Value = score;
            Duration!.Value = duration;
            Order!.Value = order;
        }

        public QuestionViewModel ToViewModel()
        {
            return new(QuestionId, SectionId, Text.Value!, ImageAddress.Value!, Score.Value, Duration.Value, Order.Value);
        }

        public bool HasId() => QuestionId != 0;

        public bool IsFine() => Text.IsFine()
                                && ImageAddress.IsFine()
                                && Score.IsFine()
                                && Duration.IsFine()
                                && Order.IsFine();


        //[QuestionId] INT IDENTITY(1,1) PRIMARY KEY,
        //[SectionId] INT NOT NULL,
        //[Text] NVARCHAR(4000),
        //[ImageAddress] NVARCHAR(256),
        //[Score] float (24),
        //[Duration] TIME,
        //[Order] INT,
    }
}
