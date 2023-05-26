using OnlineQuiz.Business.Abstractions.Events.UserEvents;
using Prism.Events;

namespace OnlineQuiz.Business.Logic.Events.UserEvents
{
    public class BaseUserAddEvent : PubSubEvent<BaseUserEventsPayload>, IBaseUserAddEvent
    {
    }
}
