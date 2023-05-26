using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IServices
{
    public interface IUserService
    {
        Task<BaseUser> AddBaseUserAsync(BaseUser baseUserInfo);
        User AddUser(User newUser, Field<string> password, Field<string> passwordVerify);
    }
}
