using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Abstractions.Events.TestEvents
{
    public interface ITestEventsPayload
    {
        Test Test { get; }
    }
}