namespace Quiz.Components
{
    public class Answers
    {       
        public int QuestionNumber { get; } = 0;
        public string CorrectAnswer { get; } = string.Empty;

        public Answers(int questionNumber, string correctAnswer)
        {
            QuestionNumber = questionNumber;
            CorrectAnswer = correctAnswer;
        }
    }
}