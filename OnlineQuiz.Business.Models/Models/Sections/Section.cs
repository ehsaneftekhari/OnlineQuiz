using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models.Sections
{
    public class Section : IFine, IIdContainer
    {
        public int SectionId;
        public int TestId;
        public Field<string> SectionTitle;
        public Field<DateTime?> Start;
        public Field<DateTime?> End;
        public Field<TimeSpan?> Duration;
        public Field<int?> Order;
        public Field<int?> AttemptLimit;
        public Field<bool> RandomizeQuestions;
        public Field<bool> DisplayResult;
        public Field<bool> AllowEdit;

        private Section()
        {
            SectionId = 0;
            TestId = 0;
            SectionTitle = new Field<string>(string.Empty);
            Start = new Field<DateTime?>();
            End = new Field<DateTime?>();
            Duration = new Field<TimeSpan?>();
            Order = new Field<int?>(0);
            AttemptLimit = new Field<int?>(1);
            RandomizeQuestions = new Field<bool>(true);
            DisplayResult = new Field<bool>(false);
            AllowEdit = new Field<bool>(false);
        }

        public Section(int testId,
                       string sectionTitle,
                       DateTime? start,
                       DateTime? end,
                       TimeSpan? duration,
                       int? order,
                       int? attemptLimit,
                       bool randomizeQuestions,
                       bool displayResult,
                       bool allowEdit) : this()
        {
            TestId = testId;
            SectionTitle!.Value = sectionTitle;
            Start!.Value = start;
            End!.Value = end;
            Duration!.Value = duration;
            Order!.Value = order;
            AttemptLimit!.Value = attemptLimit;
            RandomizeQuestions!.Value = randomizeQuestions;
            DisplayResult!.Value = displayResult;
            AllowEdit!.Value = allowEdit;
        }

        public Section(int sectionId,
                       int testId,
                       string sectionTitle,
                       DateTime? start,
                       DateTime? end,
                       TimeSpan? duration,
                       int? order,
                       int? attemptLimit,
                       bool randomizeQuestions,
                       bool displayResult,
                       bool allowEdit) : this(testId,
                sectionTitle,
                start,
                end,
                duration,
                order,
                attemptLimit,
                randomizeQuestions,
                displayResult,
                allowEdit)
        {
            SectionId = sectionId;
        }

        public SectionViewModel ToViewModel()
        {
            return new(SectionId,
                        TestId,
                        SectionTitle.Value!,
                        Start.Value,
                        End.Value,
                        Duration.Value,
                        Order.Value,
                        AttemptLimit.Value,
                        RandomizeQuestions.Value,
                        DisplayResult.Value,
                        AllowEdit.Value);
        }

        public bool HasId() => SectionId != 0;

        public bool IsFine() =>
            SectionTitle.IsFine() &&
            SectionTitle.IsFine() &&
            Start.IsFine() &&
            End.IsFine() &&
            Duration.IsFine() &&
            Order.IsFine() &&
            AttemptLimit.IsFine() &&
            RandomizeQuestions.IsFine() &&
            DisplayResult.IsFine() &&
            AllowEdit.IsFine();

        //[SectionId] INT IDENTITY(1,1) PRIMARY KEY,
        //[TestId] INT NOT NULL,
        //[SectionTitle] NVARCHAR(32) NOT NULL,
        //[Start] DATETIME,
        //[End] DATETIME,
        //[Duration] TIME,
        //[Order] INT,
        //[AttemptLimit] INT DEFAULT 1,
        //[RandomizeQuestions] INT DEFAULT 1,
        //[DisplayResult] BIT DEFAULT 0,
        //[AllowEdit] BIT DEFAULT 0,
    }
}
