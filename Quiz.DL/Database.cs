using Quiz.Components;
using System.Data;

namespace Quiz.DL
{
    public class Database
    {       
        private DataTable Question = null;
        private DataTable Answer = null;

        public delegate void OnLoadEventHandler(object sender, DatabaseEventArgs e);
        public delegate void QuestionAcquiredEventHandler(object sender, QuestionEventArgs e);
        public delegate void AnswerProvidedEventHandler(object sender, AnswerEventArgs e);

        public event OnLoadEventHandler DatabaseLoaded;
        public event QuestionAcquiredEventHandler QuestionAcquired;
        public event AnswerProvidedEventHandler AnswerProvided;

        public Database()
        {
            BuildQuestionTable();
            BuildAnswerTable();
        }

        protected virtual void OnLoad()
        {
            int questionCount = Question.Rows.Count;
            DatabaseEventArgs e = new DatabaseEventArgs(questionCount);
            DatabaseLoaded(this, e);
        }

        protected virtual void OnQuestionAcquired(int questionNumber)
        {
            string question = string.Empty;
            string answerA = string.Empty;
            string answerB = string.Empty;
            string answerC = string.Empty;
            string answerD = string.Empty;

            foreach (DataRow dr in Question.Rows)
            {
                if (questionNumber == (int)dr["QuestionID"])
                {
                    question = dr["Question"].ToString();
                    break;
                }
            }

            foreach (DataRow dr in Answer.Rows)
            {
                if (questionNumber == (int)dr["QuestionID"])
                {
                    string answerText = dr["AnswerText"].ToString();

                    switch (dr["Answer"].ToString())
                    {
                        case "A":
                            answerA = answerText;
                            break;
                        case "B":
                            answerB = answerText;
                            break;
                        case "C":
                            answerC = answerText;
                            break;
                        case "D":
                            answerD = answerText;
                            break;
                    }
                }
            }

            Questions q = new Questions(questionNumber, question, answerA, answerB, answerC, answerD);
            QuestionEventArgs e = new QuestionEventArgs(q);
            QuestionAcquired(this, e);
        }

        protected virtual void OnAnswerProvided(int questionNumber)
        {
            string correctAnswer = string.Empty;

            foreach (DataRow dr in Question.Rows)
            {
                if (questionNumber == (int)dr["QuestionID"])
                {
                    correctAnswer = dr["Correct"].ToString();
                    break;
                }
            }

            Answers answer = new Answers(questionNumber, correctAnswer);
            AnswerEventArgs e = new AnswerEventArgs(answer);
            AnswerProvided(this, e);
        }

        private void BuildQuestionTable()
        {
            Question = new DataTable("Questions");

            Question.Columns.Add("QuestionID", typeof(int));
            Question.Columns.Add("Question", typeof(string));
            Question.Columns.Add("Correct", typeof(string));

            Question.Rows.Add(1, "Question", "A");
            Question.Rows.Add(2, "Question", "D");
            Question.Rows.Add(3, "Question", "B");
            Question.Rows.Add(4, "Question", "C");
            Question.Rows.Add(5, "Question", "D");
            Question.Rows.Add(6, "Question", "A");
            Question.Rows.Add(7, "Question", "B");
            Question.Rows.Add(8, "Question", "A");
            Question.Rows.Add(9, "Question", "C");
            Question.Rows.Add(10, "Question", "A");
            Question.Rows.Add(11, "Question", "B");
            Question.Rows.Add(12, "Question", "B");
            Question.Rows.Add(13, "Question", "D");
            Question.Rows.Add(14, "Question", "C");
            Question.Rows.Add(15, "Question", "D");
            Question.Rows.Add(16, "Question", "C");
            Question.Rows.Add(17, "Question", "B");
            Question.Rows.Add(18, "Question", "A");
            Question.Rows.Add(19, "Question", "D");
            Question.Rows.Add(20, "Question", "A");
        }

        private void BuildAnswerTable()
        {
            Answer = new DataTable("Answers");

            Answer.Columns.Add("AnswerID", typeof(string));
            Answer.Columns.Add("QuestionID", typeof(int));
            Answer.Columns.Add("Answer", typeof(string));
            Answer.Columns.Add("AnswerText", typeof(string));
            // Question: 1
            Answer.Rows.Add("1A", 1, "A", "foo");
            Answer.Rows.Add("1B", 1, "B", "foo");
            Answer.Rows.Add("1C", 1, "C", "foo");
            Answer.Rows.Add("1D", 1, "D", "foo");
            // Question: 2               
            Answer.Rows.Add("2A", 2, "A", "foo");
            Answer.Rows.Add("2B", 2, "B", "foo");
            Answer.Rows.Add("2C", 2, "C", "foo");
            Answer.Rows.Add("2D", 2, "D", "foo");
            // Question: 3                
            Answer.Rows.Add("3A", 3, "A", "foo");
            Answer.Rows.Add("3B", 3, "B", "foo");
            Answer.Rows.Add("3C", 3, "C", "foo");
            Answer.Rows.Add("3D", 3, "D", "foo");
            // Question: 4                
            Answer.Rows.Add("4A", 4, "A", "foo");
            Answer.Rows.Add("4B", 4, "B", "foo");
            Answer.Rows.Add("4C", 4, "C", "foo");
            Answer.Rows.Add("4D", 4, "D", "foo");
            // Question: 5                
            Answer.Rows.Add("5A", 5, "A", "foo");
            Answer.Rows.Add("5B", 5, "B", "foo");
            Answer.Rows.Add("5C", 5, "C", "foo");
            Answer.Rows.Add("5D", 5, "D", "foo");
            // Question: 6                
            Answer.Rows.Add("6A", 6, "A", "foo");
            Answer.Rows.Add("6B", 6, "B", "foo");
            Answer.Rows.Add("6C", 6, "C", "foo");
            Answer.Rows.Add("6D", 6, "D", "foo");
            // Question: 7                
            Answer.Rows.Add("7A", 7, "A", "foo");
            Answer.Rows.Add("7B", 7, "B", "foo");
            Answer.Rows.Add("7C", 7, "C", "foo");
            Answer.Rows.Add("7D", 7, "D", "foo");
            // Question: 8                
            Answer.Rows.Add("8A", 8, "A", "foo");
            Answer.Rows.Add("8B", 8, "B", "foo");
            Answer.Rows.Add("8C", 8, "C", "foo");
            Answer.Rows.Add("8D", 8, "D", "foo");
            // Question: 9                
            Answer.Rows.Add("9A", 9, "A", "foo");
            Answer.Rows.Add("9B", 9, "B", "foo");
            Answer.Rows.Add("9C", 9, "C", "foo");
            Answer.Rows.Add("9D", 9, "D", "foo");
            // Question: 10               
            Answer.Rows.Add("10A", 10, "A", "foo");
            Answer.Rows.Add("10B", 10, "B", "foo");
            Answer.Rows.Add("10C", 10, "C", "foo");
            Answer.Rows.Add("10D", 10, "D", "foo");
            // Questions: 11              
            Answer.Rows.Add("11A", 11, "A", "foo");
            Answer.Rows.Add("11B", 11, "B", "foo");
            Answer.Rows.Add("11C", 11, "C", "foo");
            Answer.Rows.Add("11D", 11, "D", "foo");
            // Questions: 12               
            Answer.Rows.Add("12A", 12, "A", "foo");
            Answer.Rows.Add("12B", 12, "B", "foo");
            Answer.Rows.Add("12C", 12, "C", "foo");
            Answer.Rows.Add("12D", 12, "D", "foo");
            // Questions: 13               
            Answer.Rows.Add("13A", 13, "A", "foo");
            Answer.Rows.Add("13B", 13, "B", "foo");
            Answer.Rows.Add("13C", 13, "C", "foo");
            Answer.Rows.Add("13D", 13, "D", "foo");
            // Question: 14               
            Answer.Rows.Add("14A", 14, "A", "foo");
            Answer.Rows.Add("14B", 14, "B", "foo");
            Answer.Rows.Add("14C", 14, "C", "foo");
            Answer.Rows.Add("14D", 14, "D", "foo");
            // Questions: 15              
            Answer.Rows.Add("15A", 15, "A", "foo");
            Answer.Rows.Add("15B", 15, "B", "foo");
            Answer.Rows.Add("15C", 15, "C", "foo");
            Answer.Rows.Add("15D", 15, "D", "foo");
            // Question: 16              
            Answer.Rows.Add("16A", 16, "A", "foo");
            Answer.Rows.Add("16B", 16, "B", "foo");
            Answer.Rows.Add("16C", 16, "C", "foo");
            Answer.Rows.Add("16D", 16, "D", "foo");
            // Question: 17                
            Answer.Rows.Add("17A", 17, "A", "foo");
            Answer.Rows.Add("17B", 17, "B", "foo");
            Answer.Rows.Add("17C", 17, "C", "foo");
            Answer.Rows.Add("17D", 17, "D", "foo");
            // Question: 18              
            Answer.Rows.Add("18A", 18, "A", "foo");
            Answer.Rows.Add("18B", 18, "B", "foo");
            Answer.Rows.Add("18C", 18, "C", "foo");
            Answer.Rows.Add("18D", 18, "D", "foo");
            // Questions: 19             
            Answer.Rows.Add("19A", 19, "A", "foo");
            Answer.Rows.Add("19B", 19, "B", "foo");
            Answer.Rows.Add("19C", 19, "C", "foo");
            Answer.Rows.Add("19D", 19, "D", "foo");
            // Question: 20              
            Answer.Rows.Add("20A", 20, "A", "foo");
            Answer.Rows.Add("20B", 20, "B", "foo");
            Answer.Rows.Add("20C", 20, "C", "foo");
            Answer.Rows.Add("20D", 20, "D", "foo");
        }                               

        public void GetQuestion(int questionNumber)
        {
            OnQuestionAcquired(questionNumber);
            OnAnswerProvided(questionNumber);
        }

        public void QueryDatabase()
        {
            OnLoad();
        }
    }
}
