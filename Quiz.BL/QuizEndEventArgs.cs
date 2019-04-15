using System;
using System.Collections;

namespace Quiz.BL
{
    public class QuizEndEventArgs : EventArgs
    {
        public ArrayList QuizSummary { get; } = null;

        public QuizEndEventArgs(ArrayList summary)
        {
            QuizSummary = summary;
        }

    }
}
