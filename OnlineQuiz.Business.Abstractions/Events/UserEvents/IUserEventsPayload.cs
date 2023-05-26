using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Abstractions.Events.UserEvents
{
    public interface IUserEventsPayload
    {
        User User { get; }
    }
}
