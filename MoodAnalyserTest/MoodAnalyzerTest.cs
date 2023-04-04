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
        [Test]
        public void GivenEmptyMood_ShouldThrow_Exception()
        {
            try
            {
                string message = "";
                MoodAnalyzer mood = new MoodAnalyzer(message);
                string result = mood.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        [Test]
        public void GivenClassName_ShouldReturnMoodAnalyzeObject()
        {
            string message = null;
            object expected = new MoodAnalyzer(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MAnalyzer.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
        [Test]
        public void GivenClassNameImproper_ShouldThrowException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MAnalyzer.Mood_analyzer", "MoodAnalyzer");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Class Not Found");
            }
        }
        [Test]
        public void GivenConstructorNameImproper_ShouldThrowException()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyze("MAnalyzer.MoodAnalyzer", "Mood_analyzer");
                expected.Equals(obj);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "Constructor Not Found");
            }
        }
    }
}