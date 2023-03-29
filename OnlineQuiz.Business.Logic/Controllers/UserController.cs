using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Validators;
using OnlineQuiz.Business.Models;
using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class UserController : IUserController
    {
        IBaseUserRepository baseUserRepository;
        IUserRepository userRepository;
        IUserValidator userValidator;
        IUserVerifier verifier;
        IValidatorFunctions validatorFunctions;

        public UserController(IBaseUserRepository baseUserRepository, IUserValidator userValidator, IUserVerifier verifier, IUserRepository userRepository, IValidatorFunctions validatorFunctions)
        {
            this.baseUserRepository = baseUserRepository;
            this.userValidator = userValidator;
            this.verifier = verifier;
            this.userRepository = userRepository;
            this.validatorFunctions = validatorFunctions;
        }

        public BaseUser AddBaseUser(BaseUser baseUserInfo)
        {
            int id = 0;
            if (userValidator.ValidateBaseUserInfo(baseUserInfo))
                id = baseUserRepository.Add(baseUserInfo);

            BaseUser baseUser = new BaseUser(id, baseUserInfo);
            return baseUser;
        }

        public User AddUser(User newUser, Field<string> password, Field<string> passwordVerify)
        {
            int id = 0;
            bool validatePasswordResult = userValidator.ValidatePassword(password, passwordVerify);
            bool validateResult = userValidator.ValidateUserInfo(newUser);
            bool verifyResult = verifier.VerifyUserFields(newUser);

            if (validatePasswordResult && validateResult && verifyResult)
                id = userRepository.Add(newUser, password.Value);

            newUser.BaseUserId = id;

            return newUser;
        }
    }
}
