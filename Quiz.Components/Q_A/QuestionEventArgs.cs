using System;

namespace Quiz.Components
{
    public class QuestionEventArgs : EventArgs
    {
        public Questions Question { get; }

        public QuestionEventArgs(Questions question)
        {
            Question = question;
        }
    }
}
