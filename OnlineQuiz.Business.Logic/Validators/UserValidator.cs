using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models;
using OnlineQuiz.Business.Models.Users;
using System.Text.RegularExpressions;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class UserValidator : IUserValidator
    {
        IValidatorFunctions validatorFunctions;

        public UserValidator(IValidatorFunctions validatorFunctions)
        {
            validatorFunctions.CheckNullArgumentException(
                validatorFunctions, nameof(validatorFunctions)
                );

            this.validatorFunctions = validatorFunctions;
        }

        public bool ValidateBaseUserInfo(BaseUser baseUserInfo)
        {
            validatorFunctions.CheckNullArgumentException(baseUserInfo, nameof(baseUserInfo));


            validatorFunctions.CheckStringEmpty(baseUserInfo.FirstName, "en_BaseUserInfo_EmptyFirstName");

            validatorFunctions.CheckStringEmpty(baseUserInfo.LastName, "en_BaseUserInfo_EmptyLastName");

            validatorFunctions.CheckStringEmpty(baseUserInfo.Email, "en_BaseUserInfo_EmptyEmail");

            validatorFunctions.CheckStringEmpty(baseUserInfo.PhoneNumber, "en_BaseUserInfo_EmptyPhoneNumber");


            validatorFunctions.CheckStringMaxLength(baseUserInfo.FirstName, 32, "en_BaseUserInfo_LongFirstName");

            validatorFunctions.CheckStringMaxLength(baseUserInfo.LastName, 32, "en_BaseUserInfo_LongLastName");

            validatorFunctions.CheckRegex(baseUserInfo.Email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", "en_BaseUserInfo_EmailWrongFormat");

            validatorFunctions.CheckStringMaxLength(baseUserInfo.PhoneNumber, 10, "en_BaseUserInfo_PhoneNumberWrongFormat");
        
            return baseUserInfo.IsFine();
        }

        
    }
}
