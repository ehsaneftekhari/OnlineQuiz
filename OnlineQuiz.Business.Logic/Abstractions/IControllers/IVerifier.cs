using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IVerifier
    {
        User VerifyUserCredential(UserCredential credential);

        public bool VerifyUserFields(User newUser);
    }
}