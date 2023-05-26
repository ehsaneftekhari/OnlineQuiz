using OnlineQuiz.Business.Abstractions.Events.TestEvents;
using OnlineQuiz.Business.Models.Models.Tests;

namespace OnlineQuiz.Business.Logic.Events.TestEvents
{
    public class TestEventsPayload : ITestEventsPayload
    {
        public Test Test { get; set; }
    }
}
