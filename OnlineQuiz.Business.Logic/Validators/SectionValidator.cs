using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Library;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Business.Logic.Validators
{
    public class SectionValidator : ISectionValidator
    {
        IValidatorFunctions validatorFunctions;

        public SectionValidator(IValidatorFunctions validatorFunctions)
        {
            this.validatorFunctions = validatorFunctions;
        }

        public bool ValidateSection(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            validatorFunctions.CheckStringEmpty(section.SectionTitle, "en_Section_EmptyTitle");
            validatorFunctions.CheckStringMaxLength(section.SectionTitle, 32, "en_Section_LongTitle");

            validatorFunctions.Check(section.Start, start => start == section.End.Value, "en_Section_SameStart&End", ModelStatusEnum.Error);
            validatorFunctions.Check(section.End, end => end == section.Start.Value, "en_Section_SameStart&End", ModelStatusEnum.Error);

            validatorFunctions.Check(section.Start, start => section.End.Value < start, "en_Section_LateStart", ModelStatusEnum.Error);
            validatorFunctions.Check(section.End, end => end < section.Start.Value, "en_Section_EarlierEnd", ModelStatusEnum.Error);

            validatorFunctions.Check(section.Order, order => order < 0, "en_Section_LessThanZeroOrder", ModelStatusEnum.Error);
            validatorFunctions.Check(section.AttemptLimit, attemptLimit => attemptLimit < 1, "en_Section_ZeroAttemptLimit", ModelStatusEnum.Error);

            return section.IsFine();
        }
    }
}
