using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UseCase1
    {
        private MoodAnalyser moodAnalyser;
        [TestMethod]
        public void TestCase1()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string myMood = "I am in Sad Mood";

            //Act
            var result = moodAnalyser.analyseMood(myMood);

            //Assert
            Assert.AreEqual("SAD", result);
        }

        [TestMethod]
        public void TestCase2()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string myMood = "I am in Any Mood";

            //Act
            var result = moodAnalyser.analyseMood(myMood);

            //Assert
            Assert.AreEqual("HAPPY", result);
        }

    }
}