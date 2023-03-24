using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Users;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class UserController : IUserController
    {
        IBaseUserRepository baseUserRepository;
        IUserValidator userValidator;

        public UserController(IBaseUserRepository baseUserRepository, IUserValidator userValidator)
        {
            this.baseUserRepository = baseUserRepository;
            this.userValidator = userValidator;
        }

        public BaseUser AddBaseUser(BaseUserInfo baseUserInfo)
        {
            int id = -1;
            if (userValidator.ValidateBaseUserInfo(baseUserInfo))
                id = baseUserRepository.Add(baseUserInfo);

            BaseUser baseUser = new BaseUser(id, baseUserInfo);
            return baseUser;
        }
    }
}
