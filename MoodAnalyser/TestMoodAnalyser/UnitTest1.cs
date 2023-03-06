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
        public void HappyMood_WhenAnalyse_ShouldReturnHappy()
        {
            Mood checkMood = new Mood("I am in happy mood");
            string result = checkMood.AnalyseMood();
            Assert.AreEqual(result, "happy");
        }
        [Test]
        public void NullReference_WhenAnalyse_ShouldReturnHappy()
        {
            try
            {
                Mood checkMood = new Mood(null);
                string result = checkMood.AnalyseMood();
                
            }
            catch(MoodException obj)
            {
                Assert.AreEqual("Message should not be null", obj.Message);
            }
        }
    }
}