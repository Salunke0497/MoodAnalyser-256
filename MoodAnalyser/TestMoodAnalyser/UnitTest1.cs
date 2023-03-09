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
        public void NullReference_WhenAnalyse_ShouldReturnNULL_MESSAGE()
        {
            try
            {
                Mood checkMood = new Mood(null);
                string result = checkMood.AnalyseMood();

            }
            catch (MoodException obj)
            {
                Assert.AreEqual("Message should not be null", obj.Message);
            }
        }
        [Test]
        public void GivenEmptyMood_ThrowMoodAnalysisException_EmptyMessage()
        {

            try
            {
                Mood checkMood = new Mood(string.Empty);
                string result = checkMood.AnalyseMood();
            }
            catch (MoodException obj)
            {
                Assert.AreEqual("Message should not be empty", obj.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ReturnMoodAnalyserObjectoOfThatClass()
        {
            object expected = new Mood();  //Default constructor object
            object actual = Reflection.CreatMoodAnalyser("MoodAnalyser.Mood", "Mood");
            expected.Equals(actual);
        }
    }
}