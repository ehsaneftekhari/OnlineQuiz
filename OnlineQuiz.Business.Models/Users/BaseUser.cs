using OnlineQuiz.Business.Models.Abstractions;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Models.Users
{
    public record BaseUser : IFine, IIdContainer
    {
        public Field<string> FirstName { get; private set; }

        public Field<string> LastName { get; private set; }

        public Field<string> Email { get; private set; }

        public Field<string> PhoneNumber { get; private set; }

        public int BaseUserId { get; set; }

        public BaseUser()
        {
            FirstName = new Field<string>(string.Empty);
            LastName = new Field<string>(string.Empty);
            Email = new Field<string>(string.Empty);
            PhoneNumber = new Field<string>(string.Empty);
            BaseUserId = 0;
        }


        public BaseUser(string firstName, string lastName, string email, string phoneNumber, int baseUserId = 0) : this()
        {
            ThrowHelper.ThrowNullArgumentException(
                firstName, nameof(firstName),
                lastName, nameof(lastName),
                email, nameof(email),
                phoneNumber, nameof(phoneNumber),
                baseUserId, nameof(baseUserId)
            );

            FirstName!.Value = firstName;
            LastName!.Value = lastName;
            Email!.Value = email;
            PhoneNumber!.Value = phoneNumber;
            BaseUserId = baseUserId;
        }

        public BaseUser(Field<string> firstName, Field<string> lastName, Field<string> email, Field<string> phoneNumber, int baseUserId = -1) : base()
        {
            ThrowHelper.ThrowNullArgumentException(
                firstName, nameof(firstName),
                lastName, nameof(lastName),
                email, nameof(email),
                phoneNumber, nameof(phoneNumber),
                baseUserId, nameof(baseUserId)
            );

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            BaseUserId = baseUserId;
        }

        public BaseUser(int baseUserId, BaseUser baseUserInfo) : this(baseUserInfo.FirstName, baseUserInfo.LastName, baseUserInfo.Email, baseUserInfo.PhoneNumber, baseUserId) { }

        public bool IsFine() => FirstName.IsFine() && LastName.IsFine() && Email.IsFine() & PhoneNumber.IsFine();

        public bool HasId() => BaseUserId > 0;
    }
}
