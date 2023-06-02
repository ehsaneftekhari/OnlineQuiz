
using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Abstractions.Events.SectionEvents
{
    public interface ISectionEventsPayload
    {
        Section Section { get; } 
    }
}
