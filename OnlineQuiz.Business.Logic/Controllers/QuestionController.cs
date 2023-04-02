﻿using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Models.Questions;
using OnlineQuiz.Persistence.ADO.Repositories;

namespace OnlineQuiz.Business.Logic.Controllers
{
    public class QuestionController : IQuestionController
    {
        IQuestionRepository questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            this.questionRepository = questionRepository;
        }

        public List<QuestionViewModel> GetQuestionList(int sectionId)
        {
            List<Question> getResult = questionRepository.GetList(sectionId);

            List<QuestionViewModel> result = getResult.Select(test => test.ToViewModel()).ToList();

            return result;
        }
    }
}
