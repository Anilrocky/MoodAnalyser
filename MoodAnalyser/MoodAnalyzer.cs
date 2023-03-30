namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch(Exception)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Message is Null");
            }
        }
    }
}