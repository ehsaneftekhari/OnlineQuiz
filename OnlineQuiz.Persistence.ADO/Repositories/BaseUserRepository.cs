using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Models.Users;
using SqlCommandBuilder = OnlineQuiz.Persistence.ADO.Builders.SqlCommandBuilder;

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
            if(baseUserInfo == null)
                throw new ArgumentNullException(nameof(baseUserInfo));

            var BaseUserId = SqlCommandBuilder.CreateSP("[Users].[Usp_BaseUser_Add]")
                .AddParameter("@FirstName", baseUserInfo.FirstName.Value)
                .AddParameter("@LastName", baseUserInfo.LastName.Value)
                .AddParameter("@Email", baseUserInfo.Email.Value)
                .AddParameter("@PhoneNumber", baseUserInfo.PhoneNumber.Value)
                .AddOutputParameter("@BaseUserId", System.Data.SqlDbType.Int)
                .ExecuteNonQuery().GetValueOfOutputParameters("@BaseUserId");

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
