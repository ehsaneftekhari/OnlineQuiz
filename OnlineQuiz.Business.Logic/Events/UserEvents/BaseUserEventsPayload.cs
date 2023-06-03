using OnlineQuiz.Business.Abstractions.Events.UserEvents;
using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Events.UserEvents
{
    public class BaseUserEventsPayload : IBaseUserEventsPayload
    {
        public BaseUser baseUser { get; set; }
    }
}
