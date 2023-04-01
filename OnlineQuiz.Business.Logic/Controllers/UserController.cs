using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class UserController : IUserController
    {
        IBaseUserRepository baseUserRepository;
        IUserRepository userRepository;
        IUserValidator userValidator;
        IUserVerifier verifier;

        public UserController(IBaseUserRepository baseUserRepository, IUserValidator userValidator, IUserVerifier verifier, IUserRepository userRepository)
        {
            this.baseUserRepository = baseUserRepository;
            this.userValidator = userValidator;
            this.verifier = verifier;
            this.userRepository = userRepository;
        }

        public BaseUser AddBaseUser(BaseUser baseUserInfo)
        {
            ThrowHelper.ThrowNullArgumentException(
                baseUserInfo, nameof(baseUserInfo)
                );

            int id = 0;
            if (userValidator.ValidateBaseUserInfo(baseUserInfo))
                id = baseUserRepository.Add(baseUserInfo);

            BaseUser baseUser = new BaseUser(id, baseUserInfo);
            return baseUser;
        }

        public User AddUser(User newUser, Field<string> password, Field<string> passwordVerify)
        {
            ThrowHelper.ThrowNullArgumentException(
                 newUser, nameof(newUser),
                 password, nameof(password),
                 passwordVerify, nameof(passwordVerify)
                 );

            int id = 0;
            bool validatePasswordResult = userValidator.ValidatePassword(password, passwordVerify);
            bool validateResult = userValidator.ValidateUserInfo(newUser);
            bool verifyResult = verifier.VerifyUserFields(newUser);

            if (validatePasswordResult && validateResult && verifyResult)
                id = userRepository.Add(newUser, password.Value!);

            newUser.BaseUserId = id;

            return newUser;
        }
    }
}
