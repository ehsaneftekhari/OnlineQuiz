using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Validators;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Persistence.ADO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class Verifier : IVerifier
    {
        IUserRepository userRepository;
        IAppMessageRepository appMessageRepository;

        public Verifier(IUserRepository userRepository, IAppMessageRepository appMessageRepository)
        {
            this.userRepository = userRepository;
            this.appMessageRepository = appMessageRepository;
        }

        public User VerifyUser(UserCredential credential)
        {
            int id = userRepository.VerifyUser(credential);

            User result = new User(credential.Username);
            if (id == 0)
            {
                result.Username.Message = appMessageRepository.GetMessage("en_User_InvalidCredentials");
                result.Username.Status = Models.ModelStatusEnum.Error;
            }
            else
            {
                result.BaseUserId = id;
            }
            return result;
        }
    }
}
