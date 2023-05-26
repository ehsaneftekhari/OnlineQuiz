using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Abstractions.Events.UserEvents
{
    public interface IBaseUserEventsPayload
    {
        BaseUser baseUser { get; }
    }
}
