using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Users;
using System.Data;
using ADOSqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.ADOSqlCommandBuilder;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private IAppMessageRepository appMessageRepository;

        public UserRepository(IAppMessageRepository appMessageRepository)
        {
            this.appMessageRepository = appMessageRepository;
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
    }
}
