using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Sections;
using OnlineQuiz.Business.Models.Models.Tests;
using OnlineQuiz.Library;

namespace OnlineQuiz.Business.Logic.Verifiers
{
    internal class SectionVerifier : ISectionVerifier
    {
        ITestRepository testRepository;
        ISectionRepository sectionRepository;
        IAppMessageRepository appMessageRepository;
        IValidatorFunctions validatorFunctions;
        ITestService testServices;

        public SectionVerifier(ITestRepository testRepository,
                               ISectionRepository sectionRepository,
                               IValidatorFunctions validatorFunctions,
                               ITestService testServices)
        {
            this.testRepository = testRepository;
            this.sectionRepository = sectionRepository;
            this.validatorFunctions = validatorFunctions;
            this.testServices = testServices;
        }



        public bool VerifySection(Section section)
        {
            ThrowHelper.ThrowNullArgumentException(section, nameof(section));

            Test test = testRepository.Get(section.TestId);

            bool testIsExist = test.HasId();

            if (!testIsExist)
                return false;

            RandomizeType randomizeType = test.RandomizeType.Value;

            if (testIsExist && randomizeType == RandomizeType.RandomAllSections)
            {
                validatorFunctions.Check(section.Start,
                                         start => start != test.Start.Value,
                                         "en_Section_TestAndSectionNotSameStart",
                                         ModelStatusEnum.Error);

                validatorFunctions.Check(section.End,
                                         end => end != test.End.Value,
                                         "en_Section_TestAndSectionNotSameEnd",
                                         ModelStatusEnum.Error);

                TimeSpan SectionsDurationSum = testServices.GetSectionsDurationSum(section.TestId);

                validatorFunctions.Check(section.Duration,
                                         duration => duration >= SectionsDurationSum,
                                         "en_Section_NotEnoughTestDuration",
                                         ModelStatusEnum.Error);
            }

            if (testIsExist && randomizeType == RandomizeType.RandomOnCompatibleTime)
            {
                if (test.Start.Value != null && test.End.Value != null)
                {
                    validatorFunctions.Check(section.Start,
                                             start => start < test.Start.Value,
                                             "en_Section_TestAndSectionNotSameStart",
                                             ModelStatusEnum.Error);

                    validatorFunctions.Check(section.End,
                                             end => end > test.End.Value,
                                             "en_Section_TestAndSectionNotSameEnd",
                                             ModelStatusEnum.Error);
                }

                validatorFunctions.Check(section.Order,
                                     order => order != 0,
                                     "en_Section_TestAndSectionNotSameEnd",
                                     ModelStatusEnum.Error);
            }

            if (testIsExist && randomizeType == RandomizeType.FollowSectionsSetting)
            {
            }

            return section.IsFine();
        }
    }
}
