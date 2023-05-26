using OnlineQuiz.Business.Abstractions.Events.UserEvents;
using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Events.UserEvents
{
    public class UserEventsPayload : IUserEventsPayload
    {
        public User User { get; set; }
    }
}
