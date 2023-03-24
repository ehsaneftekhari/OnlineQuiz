namespace OnlineQuiz.Business.Models.Users
{
    public class BaseUserInfo 
    {
        public Field<string> FirstName { get; private set; }
        public Field<string> LastName { get; private set; }
        public Field<string> Email { get; private set; }
        public Field<string> PhoneNumber { get; private set; }

        private BaseUserInfo()
        {
            FirstName = new Field<string>();
            LastName = new Field<string>();
            Email = new Field<string>();
            PhoneNumber = new Field<string>();
        }

        public BaseUserInfo(string firstName, string lastName, string email, string phoneNumber) : this()
        {
            if (firstName == null)
                throw new ArgumentNullException(nameof(firstName));

            if (lastName == null)
                throw new ArgumentNullException(nameof(lastName));

            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));

            FirstName.Value = firstName;
            LastName.Value = lastName;
            Email.Value = email;
            PhoneNumber.Value = phoneNumber;
        }

        internal BaseUserInfo(BaseUserInfo baseUserInfo) : this(baseUserInfo.FirstName.Value, baseUserInfo.LastName.Value, baseUserInfo.Email.Value, baseUserInfo.PhoneNumber.Value) { }


        public bool IsFine() => FirstName.IsFine() && LastName.IsFine() && Email.IsFine() & PhoneNumber.IsFine();
    }
}
