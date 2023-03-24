using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IBaseUserRepository
    {
        int Add(BaseUserInfo baseUserInfo);

        BaseUser GetById(int baseUserId);

        int Update(BaseUser baseUser);

        int Delete(int baseUserId);

        bool VerifyEmail();

        bool VerifyPhoneNumber();
    }
}
