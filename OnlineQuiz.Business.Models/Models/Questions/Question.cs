using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models.Questions
{
    public class Question : IFine, IIdContainer
    {
        public int questionId;
        public int sectionId;
        public Field<string> text;
        public Field<string> imageAddress;
        public Field<double?> score;
        public Field<TimeSpan?> duration;
        public Field<int?> order;

        public Question()
        {
            text = new Field<string?>(string.Empty)!;
            imageAddress = new Field<string?>(string.Empty)!;
            score = new Field<double?>(0);
            duration = new Field<TimeSpan?>(null);
            order = new Field<int?>(null);
        }

        public Question(int sectionId,
                        string text,
                        string imageAddress,
                        double? score,
                        TimeSpan? duration,
                        int? order) : this()
        {
            this.sectionId = sectionId;
            this.text!.Value = text;
            this.imageAddress!.Value = imageAddress;
            this.score!.Value = score;
            this.duration!.Value = duration;
            this.order!.Value = order;
        }

        public Question(int questionId,
                int sectionId,
                string text,
                string imageAddress,
                double? score,
                TimeSpan? duration,
                int? order) : this(sectionId,
                                   text,
                                   imageAddress,
                                   score,
                                   duration,
                                   order)
        {
            this.questionId = questionId;
        }

        public List<string> Messages
        {
            get 
            {
                var messages = new List<string>();

                if (!text.IsFine())
                    messages.Add(text.Message);

                if(!imageAddress.IsFine())
                    messages.Add(imageAddress.Message);

                if (!score.IsFine())
                    messages.Add(score.Message);

                if (!duration.IsFine())
                    messages.Add(duration.Message);

                if (!order.IsFine())
                    messages.Add(order.Message);

                return messages;
            }
        }

        public QuestionViewModel ToViewModel()
        {
            return new(questionId, sectionId, text.Value!, imageAddress.Value!, score.Value, duration.Value, order.Value);
        }

        public bool HasId() => questionId != 0;

        public bool IsFine() => text.IsFine()
                                && imageAddress.IsFine()
                                && score.IsFine()
                                && duration.IsFine()
                                && order.IsFine();

    }
}
