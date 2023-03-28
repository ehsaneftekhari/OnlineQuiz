using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IUserRepository
    {
        int VerifyUser(UserCredential credential);

        bool VerifyUserName(string username);

        bool VerifyEmail(string email);

        bool VerifyPhoneNumber(string phoneNumber);

        int Add(User newUser, string password);
    }
}
