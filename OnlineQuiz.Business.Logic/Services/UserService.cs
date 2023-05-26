using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Events.EventAggregators;
using OnlineQuiz.Business.Logic.Events.UserEvents;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Services
{
    public class UserService : IUserService
    {
        IBaseUserRepository baseUserRepository;
        IUserRepository userRepository;
        IUserValidator userValidator;
        IUserVerifier verifier;
        ICustomEventAggregator customEventAggregator;

        public UserService(IBaseUserRepository baseUserRepository, IUserValidator userValidator, IUserVerifier verifier, IUserRepository userRepository, ICustomEventAggregator customEventAggregator)
        {
            this.baseUserRepository = baseUserRepository;
            this.userValidator = userValidator;
            this.verifier = verifier;
            this.userRepository = userRepository;
            this.customEventAggregator = customEventAggregator;
        }

        public async Task<BaseUser> AddBaseUserAsync(BaseUser baseUserInfo)
        {
            ThrowHelper.ThrowNullArgumentException(
                baseUserInfo, nameof(baseUserInfo)
                );

            int id = 0;
            if (userValidator.ValidateBaseUserInfo(baseUserInfo))
            {
                id = baseUserRepository.Add(baseUserInfo);
                await PublishBaseUserAddEventAsync(baseUserInfo);
            }

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

        private async Task PublishBaseUserAddEventAsync(BaseUser baseUser)
            => customEventAggregator.Publish<BaseUserAddEvent, BaseUserEventsPayload>(new() { baseUser = baseUser });
    }
}
