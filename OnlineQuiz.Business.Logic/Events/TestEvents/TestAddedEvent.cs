using OnlineQuiz.Business.Abstractions.Events.TestEvents;
using Prism.Events;

namespace OnlineQuiz.Business.Logic.Events.TestEvents
{
    public class TestAddedEvent : PubSubEvent<TestEventsPayload>, ITestAddedEvent
    {
    }
}
