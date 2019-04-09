namespace Quiz.DL
{
    public class DatabaseEventArgs
    {
        public int NumberOfQuestions { get; } = 0;

        public DatabaseEventArgs(int numberOfQuestions)
        {
            NumberOfQuestions = numberOfQuestions;
        }
    }
}
