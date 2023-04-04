using OnlineQuiz.Business.Models.Abstractions;

namespace OnlineQuiz.Business.Models.Models.Tests
{
    public class Test : IFine, IIdContainer
    {
        private Test()
        {
            BaseUserId = new Field<int>(0);
            Title = new Field<string>(string.Empty);
            Start = new Field<DateTime?>();
            End = new Field<DateTime?>();
            Published = new Field<bool>(false);
            RandomizeType = new Field<RandomizeType>();
        }

        public Test(int baseUserId,
                    string title,
                    DateTime? start,
                    DateTime? end,
                    bool published,
                    RandomizeType randomizeType) : this()
        {
            BaseUserId.Value = baseUserId;
            Title.Value = title;
            Start.Value = start;
            End.Value = end;
            Published.Value = published;
            RandomizeType.Value = randomizeType;
        }

        public Test(int testId,
                    int baseUserId,
                    string title,
                    DateTime? start,
                    DateTime? end,
                    bool published,
                    RandomizeType randomizeSections) : this()
        {
            BaseUserId.Value = baseUserId;
            TestId = testId;
            Title.Value = title;
            Start.Value = start;
            End.Value = end;
            Published.Value = published;
            RandomizeType.Value = randomizeSections;
        }

        public int TestId { get; set; }

        public Field<int> BaseUserId { get; set; }

        public Field<string> Title { get; set; }

        public Field<DateTime?> Start { get; set; }

        public Field<DateTime?> End { get; set; }

        public Field<bool> Published { get; set; }

        public Field<RandomizeType> RandomizeType { get; set; }

        public bool IsFine() => BaseUserId.IsFine()
                                && Title.IsFine()
                                && Start.IsFine()
                                && Start.IsFine()
                                && Published.IsFine() 
                                && RandomizeType.IsFine();

        public bool HasId() => TestId > 0;

        public TestViewModel ToViewModel()
        {
            return new(TestId,
                       Title.Value!,
                       Start.Value,
                       End.Value,
                       Published.Value,
                       RandomizeType.Value);
        }
    }
}
