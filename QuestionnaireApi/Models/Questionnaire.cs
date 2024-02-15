namespace QuestionnaireApi.Models
{
    public class Questionnaire
    {
        public string QuestionnaireTitle { get; set; }
        public IEnumerable<string> QuestionnaireText { get; set; }
    }
}
