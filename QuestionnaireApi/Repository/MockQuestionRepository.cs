
namespace QuestionnaireApi.Repository
{
    public class MockQuestionRepository : IQuestionRepository
    {
        //This is just to imitate sort of like a DbContext type of situation. We query the database for all question types that are requested. There could be different types of questions in the same table is the assumption.
        public IEnumerable<string> GetQuestions(string questionType)
        {
            return QuestionTypes().FirstOrDefault(x => x.Key == questionType).Value ?? [];
        }
        
        public static Dictionary<string, List<string>> QuestionTypes()
        {
            return new Dictionary<string, List<string>>()
          {
              {
                    "Geography Questions",new List<string>()
                    {
                        "What is the capital of Cuba?",
                        "What is the capital of France?",
                        "What is the capital of Poland?",
                        "What is the capital of Germany?"
                    }
              }
          };
        }
    }
}
