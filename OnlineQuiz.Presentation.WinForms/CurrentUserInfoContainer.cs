using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Presentation.WinForms
{
    internal class CurrentUserInfoContainer : ICurrentUserInfoContainer
    {
        public User User { get; set; }

        public BaseUser Guest { get; set; }
    }
    public interface ICurrentUserInfoContainer
    {
        User User { get; set; }

        BaseUser Guest { get; set; }
    }
}
