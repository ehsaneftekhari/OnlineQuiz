using OnlineQuiz.Business.Models.Models.Questions;

namespace OnlineQuiz.Business.Abstractions.Events.QuestionEvents
{
    public interface IQuestionEventsPayload
    {
        Question Question { get; }
    }
}
