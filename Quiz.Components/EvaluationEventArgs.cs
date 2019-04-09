using System;

namespace Quiz.Components
{
    public class EvaluationEventArgs : EventArgs
    {
        public int CorrectAnswers { get; } = 0;
        public int WrongAnswers { get; } = 0;
        public double SuccessRate { get; } = 0.0;
        public string Feedback { get; } = string.Empty;

        public EvaluationEventArgs(int correctAnswers, int wrongAnswers, double successRate, string feedBack)
        {
            CorrectAnswers = correctAnswers;
            WrongAnswers = wrongAnswers;
            SuccessRate = successRate;
            Feedback = feedBack;
        }
    }
}

