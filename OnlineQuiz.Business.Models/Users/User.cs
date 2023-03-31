using OnlineQuiz.Business.Models.Abstractions;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Models.Users
{
    public record User : BaseUser, IFine, IIdContainer
    {
        public Field<string> Username { get; private set; }

        public User() : base()
        {
            Username = new Field<string>(string.Empty);
        }

        public User(string username) : this()
        {
            ThrowHelper.ThrowNullArgumentException(
                username, nameof(username)
            );

            Username.Value = username;
        }

        public User(string firstName, string lastName, string email, string phoneNumber, string username, int baseUserId = 0) : this(username)
        {
            ThrowHelper.ThrowNullArgumentException(
                firstName, nameof(firstName),
                lastName, nameof(lastName),
                email, nameof(email),
                phoneNumber, nameof(phoneNumber),
                username, nameof(username),
                baseUserId, nameof(baseUserId)
            );

            base.FirstName.Value = firstName;
            base.LastName.Value = lastName;
            base.Email.Value = email;
            base.PhoneNumber.Value = phoneNumber;
            base.BaseUserId = baseUserId;
        }

        public new bool IsFine() => FirstName.IsFine() && LastName.IsFine() && Email.IsFine() && PhoneNumber.IsFine() && Username.IsFine();
    }
}
