using MoodAnalyser;

namespace TestMoodAnalyser
{
    public class Tests
    {
        //Mood checkMood = new Mood();
                
        [Test]
        public void SadMood_WhenAnalyse_ShouldReturnSad()
        {
            Mood checkMood = new Mood("I am in sad mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "sad");
        }
        [Test]
        public void HappyMood_WhenAnalyse_ShouldReturnSad()
        {
            Mood checkMood = new Mood("I am in happy mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "happy");
        }
    }
}