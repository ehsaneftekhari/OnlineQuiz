using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Abstractions.IValidators
{
    public interface ISectionValidator
    {
        bool ValidateSection(Section section);
    }
}