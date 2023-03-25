namespace OnlineQuiz.Business.Models.Users
{
    public record BaseUser
    {
        public Field<string> FirstName { get; private set; }

        public Field<string> LastName { get; private set; }

        public Field<string> Email { get; private set; }

        public Field<string> PhoneNumber { get; private set; }

        public int BaseUserId { get; set; }

        private BaseUser()
        {
            FirstName = new Field<string>();
            LastName = new Field<string>();
            Email = new Field<string>();
            PhoneNumber = new Field<string>();
            BaseUserId = 0;
        }


        public BaseUser(string firstName, string lastName, string email, string phoneNumber, int baseUserId = -1) : this()
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));

            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));

            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));

            FirstName!.Value = firstName;
            LastName!.Value = lastName;
            Email!.Value = email;
            PhoneNumber!.Value = phoneNumber;
            BaseUserId = baseUserId;
        }

        public BaseUser(Field<string> firstName, Field<string> lastName, Field<string> email, Field<string> phoneNumber, int baseUserId = -1) : base()
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));

            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));

            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            BaseUserId = baseUserId;
        }

        public BaseUser(int baseUserId, BaseUser baseUserInfo) : this(baseUserInfo.FirstName, baseUserInfo.LastName, baseUserInfo.Email, baseUserInfo.PhoneNumber, baseUserId) { }

        public bool IsFine() => FirstName.IsFine() && LastName.IsFine() && Email.IsFine() & PhoneNumber.IsFine();

        public bool HasId() => BaseUserId > 0;

        public bool HasEqualFieldsValues(BaseUser baseUser)
        {
            bool result = baseUser.FirstName.Value == this.FirstName.Value;
            result &= baseUser.LastName.Value == this.LastName.Value;
            result &= baseUser.Email.Value == this.Email.Value;
            result &= baseUser.PhoneNumber.Value == this.PhoneNumber.Value;

            return result;
        }
    }
}
