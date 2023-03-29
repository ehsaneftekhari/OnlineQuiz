using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Models.Users
{
    public class UserCredential
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserCredential(string username, string password)
        {
            ThrowHelper.ThrowNullArgumentException(
                username, nameof(username),
                password, nameof(password)
            );

            Username = username;
            Password = password;
        }
    }
}
