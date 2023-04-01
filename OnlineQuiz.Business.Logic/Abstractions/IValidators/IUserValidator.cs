using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface IUserValidator
    {
        bool ValidateBaseUserInfo(BaseUser baseUserInfo);
        bool ValidateUserInfo(User user);
        bool ValidatePassword(Field<string> password, Field<string> passwordVerify);
    }
}
