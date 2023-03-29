using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface IValidatorFunctions
    {
        bool Check<T>(Field<T> field, Func<T, bool> finderMethod, string messageTitle, ModelStatusEnum status);

        bool CheckRegex(Field<string> field, string regexPattern, string messageTitle);

        bool CheckStringMaxLength(Field<string> field, int lengthLimit, string messageTitle);

        bool CheckStringEmpty(Field<string> field, string messageTitle);

        void SetMessageForField<T>(Field<T> field, string messageTitle);

        void SetStatusForField<T>(Field<T> field, ModelStatusEnum status);
    }
}