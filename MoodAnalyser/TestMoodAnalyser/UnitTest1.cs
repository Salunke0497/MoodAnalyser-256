using MoodAnalyser;

namespace TestMoodAnalyser
{
    public class Tests
    {
        Mood checkMood = new Mood();
                
        [Test]
        public void SadMood_WhenAnalyse_ShouldReturnSad()
        {
            string result = checkMood.AnalyseMood("I am in sad mood");
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void HappyMood_WhenAnalyse_ShouldReturnSad()
        {
            string result = checkMood.AnalyseMood("I am in happy mood");
            Assert.AreEqual(result, "happy");
        }
    }
}