using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;
using System.Text.RegularExpressions;

namespace OnlineQuiz.Business.Logic.Validators
{
    internal class ValidatorFunctions : IValidatorFunctions
    {
        IAppMessageRepository appMessageRepository;

        public ValidatorFunctions(IAppMessageRepository appMessageRepository)
        {
            this.appMessageRepository = appMessageRepository;
        }

        public bool Check<T>(Field<T> field, Func<T, bool> finderMethod, string messageTitle, ModelStatusEnum status)
        {
            ThrowHelper.ThrowNullArgumentException(
                field, nameof(field),
                field.Value!, nameof(field.Value),
                finderMethod, nameof(finderMethod),
                messageTitle, nameof(messageTitle),
                status, nameof(status)
                );

            if (finderMethod.Invoke(field.Value))
            {
                SetStatusForField(field, status);
                SetMessageForField(field, messageTitle);

                return false;
            }
            return true;
        }

        public bool CheckRegex(Field<string> email, string regexPattern, string messageTitle)
        {
            ThrowHelper.ThrowNullArgumentException(
                email, nameof(email),
                email.Value!, nameof(email.Value),
                regexPattern, nameof(regexPattern),
                messageTitle, nameof(messageTitle)
                );

            Regex rg = new Regex(regexPattern);

            Func<string, bool> func = x => !rg.IsMatch(x);

            return Check(email, func, messageTitle, ModelStatusEnum.Error);
        }

        public bool CheckStringMaxLength(Field<string> field, int lengthLimit, string messageTitle)
        {
            ThrowHelper.ThrowNullArgumentException(
                field, nameof(field),
                field.Value!, nameof(field.Value),
                messageTitle, nameof(messageTitle)
                );

            return Check(field, x => x!.Length > lengthLimit, messageTitle, ModelStatusEnum.Error);
        }

        public bool CheckStringEmpty(Field<string> field, string messageTitle)
        {
            ThrowHelper.ThrowNullArgumentException(
                field, nameof(field),
                field.Value!, nameof(field.Value),
                messageTitle, nameof(messageTitle)
                );

            return Check(field, x => x!.Length == 0, messageTitle, ModelStatusEnum.Error);
        }

        public void SetMessageForField<T>(Field<T> field, string messageTitle)
        {
            ThrowHelper.ThrowNullArgumentException(
            field, nameof(field),
                messageTitle, nameof(messageTitle)
                );

            field.Message = appMessageRepository.GetMessage(messageTitle);
        }

        public void SetStatusForField<T>(Field<T> field, ModelStatusEnum status)
        {
            ThrowHelper.ThrowNullArgumentException(
                field, nameof(field),
                status, nameof(status)
                );

            field.Status = status;
        }
    }
}
