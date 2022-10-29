namespace MoodAnalyserProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result = moodAnalyser.analyseMood("I am in Sad Mood");
            Console.WriteLine(result);
        }
    }
}