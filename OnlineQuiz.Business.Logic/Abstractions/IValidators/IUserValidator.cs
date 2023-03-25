using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface IUserValidator
    {
        bool ValidateBaseUserInfo(BaseUser baseUserInfo);
    }
}
