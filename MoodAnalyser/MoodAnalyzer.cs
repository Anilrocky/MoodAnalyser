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
            if (message.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}