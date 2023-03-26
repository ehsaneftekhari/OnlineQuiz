using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IVerifier
    {
        User VerifyUser(UserCredential credential);
    }
}