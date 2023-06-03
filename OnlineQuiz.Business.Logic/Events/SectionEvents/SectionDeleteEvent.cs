using OnlineQuiz.Business.Abstractions.Events.SectionEvents;
using Prism.Events;

namespace OnlineQuiz.Business.Logic.Events.SectionEvents
{
    public class SectionDeleteEvent : PubSubEvent<SectionEventsPayload>, ISectionDeleteEvent
    {
    }
}
