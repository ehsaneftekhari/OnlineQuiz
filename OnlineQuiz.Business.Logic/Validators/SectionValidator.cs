using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class SectionValidator
    {
        IValidatorFunctions validatorFunctions;

        public SectionValidator(IValidatorFunctions validatorFunctions)
        {
            this.validatorFunctions = validatorFunctions;
        }

        public bool IsValid(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            validatorFunctions.CheckStringEmpty(section.SectionTitle, "en_Section_EmptyTitle");
            validatorFunctions.CheckStringMaxLength(section.SectionTitle, 32, "en_Section_LongTitle");

            if(!IsEmptyDataTime(section.Start.Value) && !IsEmptyDataTime(section.End.Value))
            {
                validatorFunctions.Check(section.Start, start => start == section.End.Value, "en_Section_SameStart&End", ModelStatusEnum.Error);
                validatorFunctions.Check(section.End, end => end == section.Start.Value, "en_Section_SameStart&End", ModelStatusEnum.Error);

                validatorFunctions.Check(section.Start, start => start > section.End.Value, "en_Section_LateStart", ModelStatusEnum.Error);
                validatorFunctions.Check(section.End, end => end > section.Start.Value, "en_Section_EarlierEnd", ModelStatusEnum.Error);
            }
            return false;
        }

        private bool IsEmptyDataTime(DateTime? dateTime)
        {
            if (dateTime == null)
                return true;

            if(dateTime == new DateTime())
                return true;

            return false;
        }
    }
}
