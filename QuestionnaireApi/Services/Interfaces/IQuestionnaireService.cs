using QuestionnaireApi.Models;

namespace QuestionnaireApi.Services.Interfaces
{
    public interface IQuestionnaireService
    {
        Questionnaire GetQuestionnaire(string typeOfQuesitons);
    }
}
