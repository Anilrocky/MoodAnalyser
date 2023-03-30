using MoodAnalyser;

namespace MoodAnalyserTest
{
    public class Tests
    {     
        [Test]
        public void GivenSadMood_ShouldReturn_Sad()
        {
            string message = "Iam in Sad Mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual("SAD",result);
        }
        [Test]
        public void GivenAnyMood_ShouldReturn_Happy()
        {
            string message = "Iam in Any Mood";
            MoodAnalyzer mood = new MoodAnalyzer(message);
            string result = mood.AnalyzeMood();
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void GivenNullMood_ShouldThrow_Exception()
        {
            try
            {
                string message = null;
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(e.Message,"Message is Null");
            }            
        }
    }
}