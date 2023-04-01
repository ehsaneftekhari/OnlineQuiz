using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IBaseUserRepository
    {
        int Add(BaseUser baseUserInfo);

        BaseUser GetById(int baseUserId);

        int Update(BaseUser baseUser);

        int Delete(int baseUserId);

        bool VerifyEmail();

        bool VerifyPhoneNumber();
    }
}
