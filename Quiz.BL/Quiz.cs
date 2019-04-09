using Quiz.Components;
using Quiz.DL;
using System.Collections;

namespace Quiz.BL
{
    public class Quiz
    {
        public delegate void AnswerEvaluatedEventHandler(object sender, EvaluationEventArgs e);
        public delegate void QuizEndEventHandler(object sender, QuizEndEventArgs e);

        public event AnswerEvaluatedEventHandler AnswerEvaluated;
        public event QuizEndEventHandler QuizEnded;

        ArrayList Answers = null;
        ArrayList Summary = null;
        private int questionNumber = 0;
        private int anwseredQuestionsCount = 0;
        private int correctCount = 0;
        private int wrongCount = 0;
        private double successRate = 0.0;


        public Quiz()
        {
            Answers = new ArrayList();
            Summary = new ArrayList();
        }

        protected virtual void OnEnd()
        {
            QuizEndEventArgs e = new QuizEndEventArgs(Summary, GetAnalysis());
            QuizEnded(this, e);
        }

        protected virtual void OnEvaluate(int questionNumber, string answer)
        {
            string userFeedBack = string.Empty;
            string summaryFeedBack = string.Empty;

            foreach (Answers a in Answers)
            {
                if (questionNumber == a.QuestionNumber)
                {
                    if (answer == a.CorrectAnswer)
                    {
                        correctCount++;
                        userFeedBack = $"{a.CorrectAnswer} is the correct answer";
                        summaryFeedBack = "Correct";
                    }
                    else
                    {
                        wrongCount++;
                        userFeedBack = $"{answer} is incorrect \n  {a.CorrectAnswer} is the correct answer";
                        summaryFeedBack = "Incorrect";
                    }

                    anwseredQuestionsCount++;

                    successRate = (correctCount / anwseredQuestionsCount) * 100.00;

                    Summarize s = new Summarize(a.QuestionNumber, a.CorrectAnswer, answer, summaryFeedBack);
                    Summary.Add(s);

                    break;
                }
            }


            EvaluationEventArgs e = new EvaluationEventArgs(correctCount, wrongCount, successRate, userFeedBack);
            AnswerEvaluated(this, e);

            if (questionNumber == this.questionNumber)
                OnEnd();
        }

        public void ProvideAnswer(object sender, AnswerEventArgs e)
        {
            Answers.Add(e.Answer);
        }

        public void LoadDB(object sender, DatabaseEventArgs e)
        {
            questionNumber = e.NumberOfQuestions;
        }

        private string GetAnalysis()
        {
            string analysis = string.Empty;

            if (correctCount == 0)
                analysis = "Terrible";
            else if (correctCount > 0 && correctCount < 6)
                analysis = "Bad";
            else if (correctCount > 5 && correctCount < 11)
                analysis = "Mediocre";
            else if (correctCount > 10 && correctCount < 15)
                analysis = "Good";
            else if (correctCount > 14 && correctCount < 20)
                analysis = "Nice";
            else if (correctCount == 20)
                analysis = "Perfect";

            return analysis;
        }

        public void Evaluate(int questionNumber, string answer)
        {
            OnEvaluate(questionNumber, answer);
        }
    }
}
