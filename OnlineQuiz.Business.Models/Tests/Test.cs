using OnlineQuiz.Business.Models.Abstractions;
using OnlineQuiz.Business.Models.Models;

namespace OnlineQuiz.Business.Models.Tests
{
    public class Test : IFine, IIdContainer
    {
        private Test() 
        {
            BaseUserId = new Field<int>(0);
            Title = new Field<string>(string.Empty);
            Published = new Field<bool>(false);
            RandomizeSections = new Field<bool>(false);
        }

        public Test(int baseUserId, string title, bool published, bool randomizeSections) : this()
        {
            BaseUserId.Value = baseUserId;
            Title.Value = title;
            Published.Value = published;
            RandomizeSections.Value = randomizeSections;
        }

        public int TestId { get; set; }

        public Field<int> BaseUserId { get; set; }

        public Field<string> Title { get; set; }

        public Field<bool> Published { get; set; }

        public Field<bool> RandomizeSections { get; set; }

        public bool IsFine() => BaseUserId.IsFine() && Title.IsFine() && Published.IsFine() & RandomizeSections.IsFine();

        public bool HasId() => TestId > 0;
    }
}
