using System;

namespace Quiz.Components
{
    public class AnswerEventArgs : EventArgs
    {
        public Answers Answer { get; } = null;

        public AnswerEventArgs(Answers answer)
        {
            Answer = answer;
        }

    }
}
