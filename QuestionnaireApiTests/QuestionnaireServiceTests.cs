using Moq;
using QuestionnaireApi.Repository;
using QuestionnaireApi.Services;

namespace QuestionnaireApiTests
{
    [TestFixture]
    public class QuestionServiceTests
    {
        [Test]
        public void GetQuestions_Returns_Valid_Question_Object()
        {
            // Arrange
            var mockRepository = new Mock<IQuestionRepository>();
            mockRepository.Setup(x => x.GetQuestions("Geography Questions"))
                          .Returns(new List<string> { "Question 1", "Question 2" });

            var service = new QuestionnaireService(mockRepository.Object);

            // Act
            var actual = service.GetQuestionnaire("Geography Questions");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
                Assert.That(actual.QuestionnaireText, Is.Not.Null);
                Assert.That(actual.QuestionnaireText.Count(), Is.EqualTo(2));
                Assert.That(actual.QuestionnaireText, Does.Contain("Question 1"));
                Assert.That(actual.QuestionnaireText, Does.Contain("Question 2"));
            });
        }

        [Test]
        public void GetQuestions_Returns_Empty_QuestionnaireText_For_Invalid_QuestionnaireType()
        {
            // Arrange
            var mockRepository = new Mock<IQuestionRepository>();
            mockRepository.Setup(x => x.GetQuestions(It.IsAny<string>()))
                          .Returns(new List<string>());

            var service = new QuestionnaireService(mockRepository.Object);

            // Act
            var actual = service.GetQuestionnaire("Invalid Type");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(actual, Is.Not.Null);
                Assert.That(actual.QuestionnaireTitle, Is.EqualTo("Invalid Type"));
                Assert.That(actual.QuestionnaireText, Is.Not.Null);
                Assert.That(actual.QuestionnaireText.Count(), Is.EqualTo(0));
            });

        }
    }
}