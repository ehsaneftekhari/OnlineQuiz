using OnlineQuiz.Business.Abstractions.Events.TestEvents;
using Prism.Events;

namespace OnlineQuiz.Business.Logic.Events.TestEvents
{
    public class TestUpdatedEvent : PubSubEvent<TestEventsPayload>, ITestUpdatedEvent
    {
    }
}
