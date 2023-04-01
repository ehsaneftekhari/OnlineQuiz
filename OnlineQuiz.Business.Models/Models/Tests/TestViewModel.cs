using OnlineQuiz.Business.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models.Models.Tests
{
    public class TestViewModel
    {
        public TestViewModel(int testId,
                             string title,
                             bool published,
                             bool randomizeSections)
        {
            TestId = testId;
            Title = title;
            Published = published;
            RandomizeSections = randomizeSections;
        }

        public int TestId { get; set; }

        public string Title { get; set; }

        public bool Published { get; set; }

        public bool RandomizeSections { get; set; }
    }
}
