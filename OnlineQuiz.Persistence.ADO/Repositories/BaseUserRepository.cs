using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Library;
using ADOSqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.ADOSqlCommandBuilder;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    public class BaseUserRepository : IBaseUserRepository
    {
        private IAppMessageRepository appMessageRepository;

        public BaseUserRepository(IAppMessageRepository appMessageRepository)
        {
            this.appMessageRepository = appMessageRepository;
        }

        public int Add(BaseUser baseUserInfo)
        {
            ThrowHelper.ThrowNullArgumentException(
                baseUserInfo, nameof(baseUserInfo),
                baseUserInfo.FirstName, nameof(baseUserInfo.FirstName),
                baseUserInfo.LastName, nameof(baseUserInfo.LastName),
                baseUserInfo.Email, nameof(baseUserInfo.Email),
                baseUserInfo.PhoneNumber, nameof(baseUserInfo.PhoneNumber)
           );

            var BaseUserId = ADOSqlCommandBuilder.CreateSP("[Users].[Usp_BaseUser_Add]")
                .AddParameter("@FirstName", baseUserInfo.FirstName.Value!)
                .AddParameter("@LastName", baseUserInfo.LastName.Value!)
                .AddParameter("@Email", baseUserInfo.Email.Value!)
                .AddParameter("@PhoneNumber", baseUserInfo.PhoneNumber.Value!)
                .AddOutputParameter("@BaseUserId", System.Data.SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameter("@BaseUserId");

            return (int)BaseUserId;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BaseUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(BaseUser item)
        {
            throw new NotImplementedException();
        }

        public bool VerifyEmail()
        {
            throw new NotImplementedException();
        }

        public bool VerifyPhoneNumber()
        {
            throw new NotImplementedException();
        }
    }
}
