using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Business.Models.Users
{
    public record User : BaseUser
    {
        public Field<string> Username { get; private set; }

        public User() : base()
        {
            Username = new Field<string>(string.Empty);
        }

        public User(string username) : this()
        {
            Username.Value = username;
        }

        public User(string firstName, string lastName, string email, string phoneNumber, string username, int baseUserId = 0) : this(username)
        { 
            base.FirstName.Value = firstName;
            base.LastName.Value = lastName;
            base.Email.Value = email;
            base.PhoneNumber.Value = phoneNumber;
            base.BaseUserId = baseUserId;
        }
    }
}
