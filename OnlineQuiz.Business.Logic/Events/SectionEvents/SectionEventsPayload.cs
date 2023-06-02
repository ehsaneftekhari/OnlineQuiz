using OnlineQuiz.Business.Abstractions.Events.SectionEvents;
using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Events.SectionEvents
{
    public class SectionEventsPayload : ISectionEventsPayload
    {
        public Section Section { get; set; }
    }
}
