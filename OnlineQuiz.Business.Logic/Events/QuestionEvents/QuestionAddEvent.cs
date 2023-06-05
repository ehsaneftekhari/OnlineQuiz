using Prism.Events;

namespace OnlineQuiz.Business.Abstractions.Events.QuestionEvents
{
    public class QuestionAddEvent : PubSubEvent<QuestionEventsPayload>, IQuestionAddEvent
    {
    }
}
