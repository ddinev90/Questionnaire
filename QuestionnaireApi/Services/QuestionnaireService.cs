using QuestionnaireApi.Models;
using QuestionnaireApi.Repository;
using QuestionnaireApi.Services.Interfaces;

namespace QuestionnaireApi.Services
{
    public class QuestionnaireService(IQuestionRepository questionRepository) : IQuestionnaireService
    {
        private readonly IQuestionRepository _questionRepository = questionRepository;

        public Question GetQuestions(string questionnaireType)
        {
            return new Question()
            {
                QuestionnaireTitle = questionnaireType,
                QuestionnaireText = _questionRepository.GetQuestions(questionnaireType)
            };
        }
    }
}
