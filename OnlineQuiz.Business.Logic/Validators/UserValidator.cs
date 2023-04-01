using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class UserValidator : IUserValidator
    {
        IValidatorFunctions validatorFunctions;

        public UserValidator(IValidatorFunctions validatorFunctions)
        {
            ThrowHelper.ThrowNullArgumentException
                (
                validatorFunctions, nameof(validatorFunctions)
                );

            this.validatorFunctions = validatorFunctions;
        }

        public bool ValidateBaseUserInfo(BaseUser baseUserInfo)
        {
            ThrowHelper.ThrowNullArgumentException(baseUserInfo, nameof(baseUserInfo));

            validatorFunctions.CheckStringEmpty(baseUserInfo.FirstName, "en_BaseUserInfo_EmptyFirstName");
            validatorFunctions.CheckStringEmpty(baseUserInfo.LastName, "en_BaseUserInfo_EmptyLastName");
            validatorFunctions.CheckStringEmpty(baseUserInfo.Email, "en_BaseUserInfo_EmptyEmail");
            validatorFunctions.CheckStringEmpty(baseUserInfo.PhoneNumber, "en_BaseUserInfo_EmptyPhoneNumber");
            validatorFunctions.CheckStringMaxLength(baseUserInfo.FirstName, 32, "en_BaseUserInfo_LongFirstName");
            validatorFunctions.CheckStringMaxLength(baseUserInfo.LastName, 32, "en_BaseUserInfo_LongLastName");
            validatorFunctions.CheckRegex(baseUserInfo.Email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", "en_BaseUserInfo_EmailWrongFormat");
            validatorFunctions.CheckRegex(baseUserInfo.PhoneNumber, "^(0{0,1})\\d{10}$", "en_BaseUserInfo_PhoneNumberWrongFormat");
            return baseUserInfo.IsFine();
        }

        public bool ValidateUserInfo(User user)
        {
            ThrowHelper.ThrowNullArgumentException(
                user, nameof(user)
                );

            ValidateBaseUserInfo(user);

            validatorFunctions.CheckRegex(user.Username, "\\A[a-zA-Z0-9_\\-\\.]*\\z", "en_User_InvalidUsername");
            validatorFunctions.Check(user.Username, x => x.Length < 5, "en_User_InvalidShortUsername", ModelStatusEnum.Error);
            validatorFunctions.CheckStringMaxLength(user.Username, 32, "en_User_InvalidLongUsername");
            validatorFunctions.CheckStringEmpty(user.Username, "en_User_InvalidEmptyUsername");

            return user.IsFine();
        }

        public bool ValidatePassword(Field<string> password, Field<string> passwordVerify)
        {
            ThrowHelper.ThrowNullArgumentException(
                password, nameof(password),
                passwordVerify, nameof(passwordVerify)
                );

            bool result = validatorFunctions.Check(passwordVerify, x => x != password.Value, "en_User_NotEqualPasswordVerify", ModelStatusEnum.Error);
            result = result && validatorFunctions.CheckStringEmpty(password, "en_User_EmptyPassword");

            return result;
        }
    }
}
