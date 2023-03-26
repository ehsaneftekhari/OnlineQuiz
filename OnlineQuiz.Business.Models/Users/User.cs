namespace OnlineQuiz.Business.Models.Users
{
    public class User
    {
        public Field<string> Username { get; private set; }

        public int BaseUserId { get; set; }

        public User()
        {
            Username = new Field<string>();
        }

        public User(string username) : this()
        {
            Username.Value = username;
        }
    }
}
