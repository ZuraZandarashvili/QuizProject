namespace Quiz.Components
{
    public class Summarize
    {
        public int QuestionNumber { get; } = 0;
        public string CorrectAnswer { get; } = string.Empty;
        public string SubmittedAnswer { get; } = string.Empty;
        public string Feedback { get; } = string.Empty;

        public Summarize(int questionNumber, string correctAnswer, string submittedAnswer, string feedBack)
        {
            QuestionNumber = questionNumber;
            CorrectAnswer = correctAnswer;
            SubmittedAnswer = submittedAnswer;
            Feedback = feedBack;
        }
    }
}