using OnlineQuiz.Business.Models.Models.Sections;

namespace OnlineQuiz.Business.Logic.Abstractions.IVerifiers
{
    public interface ISectionVerifier
    {
        bool VerifySection(Section section);
    }
}