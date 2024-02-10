namespace QuestionnaireApi.Models
{
    public class Question
    {
        public string QuestionnaireTitle { get; set; }
        public IEnumerable<string> QuestionnaireText { get; set; }
    }
}
