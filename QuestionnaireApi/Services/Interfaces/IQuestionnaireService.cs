using QuestionnaireApi.Models;

namespace QuestionnaireApi.Services.Interfaces
{
    public interface IQuestionnaireService
    {
        Question GetQuestions(string typeOfQuesitons);
    }
}
