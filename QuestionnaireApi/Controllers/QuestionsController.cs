using Microsoft.AspNetCore.Mvc;
using QuestionnaireApi.Services.Interfaces;

namespace QuestionnaireApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController(ILogger<QuestionsController> logger,IQuestionnaireService questionnaireService) : ControllerBase
    {

        private readonly ILogger<QuestionsController> _logger = logger;
        private readonly IQuestionnaireService _questionnaireService = questionnaireService;

        [HttpGet]
        public IActionResult Get()
        {
            _logger.Log(LogLevel.Information, "Get Questionnaire Method Called");
            //There could be different question types and we could add a method called " GetByType " and pass the parameter through url for eg.
            return Ok(_questionnaireService.GetQuestionnaire("Geography Questions"));
        }
    }
}
