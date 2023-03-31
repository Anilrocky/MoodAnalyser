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
            if (this.message.Equals(string.Empty))
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Message is Empty");
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