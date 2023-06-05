using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Abstractions.Events.QuestionEvents
{
    public class QuestionEventsPayload : IQuestionEventsPayload
    {
        public Question Question { get; set; }
    }
}
