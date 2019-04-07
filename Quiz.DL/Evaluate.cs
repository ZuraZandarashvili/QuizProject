using System;

namespace Quiz.Components
{
    public class Evaluate : EventArgs
    {
        public int CorrectAnswers { get; } = 0;
        public int WrongAnswers { get; } = 0;
        public decimal SuccessRate { get; } = 0.0m;
        public string Feedback { get; } = string.Empty;

        public Evaluate(int correctAnswers, int wrongAnswers, decimal successRate, string feedBack)
        {
            CorrectAnswers = correctAnswers;
            WrongAnswers = wrongAnswers;
            SuccessRate = successRate;
            Feedback = feedBack;
        }
    }
}

