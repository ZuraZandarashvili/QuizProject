namespace Quiz.Components
{
    public class Questions
    {
        public int QuestionNumber { get; } = 0;
        public string QuestionText { get; } = string.Empty;
        public string AnswerTextA { get; } = string.Empty;
        public string AnswerTextB { get; } = string.Empty;
        public string AnswerTextC { get; } = string.Empty;
        public string AnswerTextD { get; } = string.Empty;

        public Questions(int questionNumber, string questionText, string answerA, string answerB, string answerC, string answerD)
        {
            QuestionNumber = questionNumber;
            QuestionText = questionText;
            AnswerTextA = answerA;
            AnswerTextB = answerB;
            AnswerTextC = answerC;
            AnswerTextD = answerD;
        }
    }
}
