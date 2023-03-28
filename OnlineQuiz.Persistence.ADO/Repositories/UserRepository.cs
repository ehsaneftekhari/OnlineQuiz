using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Users;
using System.Data;
using ADOSqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.ADOSqlCommandBuilder;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public UserRepository()
        {
        }

        public int VerifyUser(UserCredential credential)
        {
            if (credential == null)
                throw new ArgumentNullException(nameof(credential));

            DataTable dataTable;

            ADOSqlCommandBuilder.CreateSP("[Users].[Usp_User_Verify]")
                .AddParameter("@UserName", credential.Username)
                .AddParameter("@PassWord", credential.Password)
                .ExecuteReader(out dataTable);

            int baseUserId = 0;
            if (dataTable.Rows.Count > 0)
                baseUserId = (int)dataTable.Rows[0]["BaseUserId"];

            return baseUserId;
        }

        public bool VerifyUserName(string username)
        {
            if (username == null)
                throw new ArgumentNullException(nameof(username));

            DataTable dataTable;

            ADOSqlCommandBuilder.CreateSP("[Users].[Usp_User_ValidateUserName]")
                .AddParameter("@UserName", username)
                .ExecuteReader(out dataTable);


            if (dataTable.Rows.Count < 0)
                throw new Exception();

            int result = -1;
            result = (int)dataTable.Rows[0]["Result"];

            return result == 0;
        }

        public bool VerifyEmail(string email)
        {
            if (email == null)
                throw new ArgumentNullException(nameof(email));

            DataTable dataTable;

            ADOSqlCommandBuilder.CreateSP("[Users].[Usp_User_ValidateEmail]")
                .AddParameter("@Email", email)
                .ExecuteReader(out dataTable);


            if (dataTable.Rows.Count < 0)
                throw new Exception();

            int result = -1;
            result = (int)dataTable.Rows[0]["Result"];

            return result == 0;
        }

        public bool VerifyPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null)
                throw new ArgumentNullException(nameof(phoneNumber));

            DataTable dataTable;

            ADOSqlCommandBuilder.CreateSP("[Users].[Usp_User_ValidatePhoneNumber]")
                .AddParameter("@PhoneNumber", phoneNumber)
                .ExecuteReader(out dataTable);


            if (dataTable.Rows.Count < 0)
                throw new Exception();

            int result = -1;
            result = (int)dataTable.Rows[0]["Result"];

            return result == 0;
        }

        public int Add (User newUser, string password)
        {
            if (newUser == null)
                throw new ArgumentNullException(nameof(newUser));

            if (password == null)
                throw new ArgumentNullException(nameof(password));

            var baseUserId = ADOSqlCommandBuilder.CreateSP("[Users].[Usp_User_Add]")
                .AddParameter("@FirstName", newUser.FirstName.Value)
                .AddParameter("@LastName", newUser.LastName.Value)
                .AddParameter("@Email", newUser.Email.Value)
                .AddParameter("@PhoneNumber", newUser.PhoneNumber.Value)
                .AddParameter("@UserName", newUser.Username.Value)
                .AddParameter("@PassWord", password)
                .AddOutputParameter("@BaseUserId", System.Data.SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameters("@BaseUserId");

            return (int)baseUserId;
        }
    }
}
