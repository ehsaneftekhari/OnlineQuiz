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
        IValidatorFunctions validatorFunctions;

        public Verifier(IUserRepository userRepository, IAppMessageRepository appMessageRepository, IValidatorFunctions validatorFunctions)
        {
            this.userRepository = userRepository;
            this.appMessageRepository = appMessageRepository;
            this.validatorFunctions = validatorFunctions;
        }

        public User VerifyUserCredential(UserCredential credential)
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

        public bool VerifyUserFields(User newUser)
        {
            bool usernameNotInUse = userRepository.VerifyUserName(newUser.Username.Value);
            if(!usernameNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.Username, Models.ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.Username, "en_User_UsernameInUse");
            }

            bool emailNotInUse = userRepository.VerifyEmail(newUser.Email.Value);
            if (!emailNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.Email, Models.ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.Email, "en_User_EmailInUse");
            }

            bool phoneNumberNotInUse = userRepository.VerifyPhoneNumber(newUser.PhoneNumber.Value);
            if (!phoneNumberNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.PhoneNumber, Models.ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.PhoneNumber, "en_User_PhoneNumberInUse");
            }

            return usernameNotInUse && emailNotInUse && phoneNumberNotInUse;
        }
    }
}
