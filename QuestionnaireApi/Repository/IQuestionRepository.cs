namespace QuestionnaireApi.Repository
{
    public interface IQuestionRepository
    {
        IEnumerable<string> GetQuestions(string questionType);
    }
}
