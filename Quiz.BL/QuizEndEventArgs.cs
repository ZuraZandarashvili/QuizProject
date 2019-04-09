using System;
using System.Collections;

namespace Quiz.BL
{
    public class QuizEndEventArgs : EventArgs
    {
        public ArrayList QuizSummary { get; } = null;
        public string Analysis { get; } = string.Empty;

        public QuizEndEventArgs(ArrayList summary, string analysis)
        {
            Analysis = analysis;
            QuizSummary = summary;
        }

    }
}
