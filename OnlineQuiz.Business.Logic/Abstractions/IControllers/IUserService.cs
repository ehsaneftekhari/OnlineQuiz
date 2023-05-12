using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IUserService
    {
        BaseUser AddBaseUser(BaseUser baseUserInfo);
        User AddUser(User newUser, Field<string> password, Field<string> passwordVerify);
    }
}
