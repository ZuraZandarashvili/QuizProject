using System;

namespace Quiz.Components
{
    public class AnswerEventArgs : EventArgs
    {
        public Answers Answers { get; } = null;

        public AnswerEventArgs(Answers answer)
        {
            Answers = answer;
        }

    }
}
