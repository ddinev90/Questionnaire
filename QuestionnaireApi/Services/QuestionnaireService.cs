using QuestionnaireApi.Models;
using QuestionnaireApi.Repository;
using QuestionnaireApi.Services.Interfaces;

namespace QuestionnaireApi.Services
{
    public class QuestionnaireService(IQuestionRepository questionRepository) : IQuestionnaireService
    {
        private readonly IQuestionRepository _questionRepository = questionRepository;

        public Questionnaire GetQuestionnaire(string questionnaireType)
        {
            return new Questionnaire()
            {
                QuestionnaireTitle = questionnaireType,
                QuestionnaireText = _questionRepository.GetQuestions(questionnaireType)
            };
        }
    }
}
