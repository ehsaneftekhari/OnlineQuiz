﻿using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Verifiers
{
    public class UserVerifier : IUserVerifier
    {
        IUserRepository userRepository;
        IAppMessageRepository appMessageRepository;
        IValidatorFunctions validatorFunctions;

        public UserVerifier(IUserRepository userRepository, IAppMessageRepository appMessageRepository, IValidatorFunctions validatorFunctions)
        {
            this.userRepository = userRepository;
            this.appMessageRepository = appMessageRepository;
            this.validatorFunctions = validatorFunctions;
        }

        public User VerifyUserCredential(UserCredential credential)
        {
            ThrowHelper.ThrowNullArgumentException(
                credential, nameof(credential)
                );

            int id = userRepository.VerifyUser(credential);

            User result = new User(credential.Username);
            if (id == 0)
            {
                result.Username.Message = appMessageRepository.GetMessage("en_User_InvalidCredentials");
                result.Username.Status = ModelStatusEnum.Error;
            }
            else
            {
                result.BaseUserId = id;
            }
            return result;
        }

        public bool VerifyUserFields(User newUser)
        {
            ThrowHelper.ThrowNullArgumentException(
                newUser, nameof(newUser),
                newUser.Username, nameof(newUser.Username),
                newUser.Email, nameof(newUser.Email),
                newUser.PhoneNumber, nameof(newUser.PhoneNumber)
            );

            bool usernameNotInUse = userRepository.VerifyUserName(newUser.Username.Value!);
            if (!usernameNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.Username, ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.Username, "en_User_UsernameInUse");
            }

            bool emailNotInUse = userRepository.VerifyEmail(newUser.Email.Value!);
            if (!emailNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.Email, ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.Email, "en_User_EmailInUse");
            }

            bool phoneNumberNotInUse = userRepository.VerifyPhoneNumber(newUser.PhoneNumber.Value!);
            if (!phoneNumberNotInUse)
            {
                validatorFunctions.SetStatusForField(newUser.PhoneNumber, ModelStatusEnum.Error);
                validatorFunctions.SetMessageForField(newUser.PhoneNumber, "en_User_PhoneNumberInUse");
            }

            return usernameNotInUse && emailNotInUse && phoneNumberNotInUse;
        }
    }
}
