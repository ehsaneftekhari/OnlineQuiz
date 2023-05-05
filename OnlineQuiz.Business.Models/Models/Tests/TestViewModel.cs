namespace OnlineQuiz.Business.Models.Models.Tests
{
    public class TestViewModel
    {
        public TestViewModel(int testId,
                             string title,
                             DateTime? start,
                             DateTime? end,
                             bool published,
                             RandomizeType randomizeType)
        {
            TestId = testId;
            Title = title;
            Start = start;
            End = end;
            Published = published;
            RandomizeType = randomizeType;
        }

        public int TestId { get; set; }

        public string Title { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public TimeSpan? Duration
        {
            get
            {
                if (Start != null && End != null)
                    return End - Start;

                return TimeSpan.Zero;
            }
        }

        public bool Published { get; set; }

        public RandomizeType RandomizeType { get; set; }
    }
}
