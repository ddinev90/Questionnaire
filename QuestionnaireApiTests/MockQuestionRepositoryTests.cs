using QuestionnaireApi.Repository;

namespace QuestionnaireApiTests
{
    [TestFixture]
    public class MockQuestionRepositoryTests
    {
        [Test]
        public void GetQuestions_Returns_Questions_For_Valid_Question_Type()
        {
            // Arrange
            var repository = new MockQuestionRepository();

            // Act
            var questions = repository.GetQuestions("Geography Questions");

            // Assert

            Assert.Multiple(() =>
            {
                Assert.That(questions, Is.Not.Null);
                Assert.That(questions.Count(), Is.EqualTo(4));
                Assert.That(questions, Does.Contain("What is the capital of Cuba?"));
                Assert.That(questions, Does.Contain("What is the capital of France?"));
                Assert.That(questions, Does.Contain("What is the capital of Poland?"));
                Assert.That(questions, Does.Contain("What is the capital of Germany?"));
            });

        }

        [Test]
        public void GetQuestions_Returns_Empty_List_For_Invalid_Question_Type()
        {
            // Arrange
            var repository = new MockQuestionRepository();

            // Act
            var questions = repository.GetQuestions("Invalid Type");

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(questions, Is.Not.Null);
                Assert.That(questions.Count(), Is.EqualTo(0));
            });

        }
    }
}