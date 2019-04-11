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

            Question.Rows.Add(1, "City of Cairo lies on the banks of which river?", "C");
            Question.Rows.Add(2, "Which of these countries is the 5th largest in the world by surface area?", "B");
            Question.Rows.Add(3, "In which of these countries can we find the Mont Blanc mountain?", "D");
            Question.Rows.Add(4, "Where are the Faroe Islands located?", "D");
            Question.Rows.Add(5, "Which of these cities is the most northern?", "A");
            Question.Rows.Add(6, "What's the capital of Venezuela?", "D");
            Question.Rows.Add(7, "Where can we find the old region of Abyssinia today?", "A");
            Question.Rows.Add(8, "What is Earth's largest continent by surface size?", "D");
            Question.Rows.Add(9, "Which continent the most independent countries?", "C");
            Question.Rows.Add(10, "What is Earth's approximate water vs land coverage ratio?", "B");
            Question.Rows.Add(11, "How many oceans are on Earth?", "C");
            Question.Rows.Add(12, "What is the northermost capital of an independant nation int he world?", "C");
            Question.Rows.Add(13, "What is the largest desert on Earth?", "A");
            Question.Rows.Add(14, "Which country has the largest population in South America?", "C");
            Question.Rows.Add(15, "In which country is the Andgels Falls located?", "D");
            Question.Rows.Add(16, "What is the second largest continent by population size?", "B");
            Question.Rows.Add(17, "Which of these countries has three national capitals?", "A");
            Question.Rows.Add(18, "Which of these countries is the owner of Greenland?", "C");
            Question.Rows.Add(19, "Which of these cities is the most western?", "D");
            Question.Rows.Add(20, "Where can we find the old region of Nubia today?", "A");
        }

        private void BuildAnswerTable()
        {
            Answer = new DataTable("Answers");

            Answer.Columns.Add("AnswerID", typeof(string));
            Answer.Columns.Add("QuestionID", typeof(int));
            Answer.Columns.Add("Answer", typeof(string));
            Answer.Columns.Add("AnswerText", typeof(string));
            // Question: 1
            Answer.Rows.Add("1A", 1, "A", "Tigris");
            Answer.Rows.Add("1B", 1, "B", "Limpopo");
            Answer.Rows.Add("1C", 1, "C", "Nile");
            Answer.Rows.Add("1D", 1, "D", "Notwane");
            // Question: 2               
            Answer.Rows.Add("2A", 2, "A", "Australia");
            Answer.Rows.Add("2B", 2, "B", "Brazil");
            Answer.Rows.Add("2C", 2, "C", "Canada");
            Answer.Rows.Add("2D", 2, "D", "India");
            // Question: 3                
            Answer.Rows.Add("3A", 3, "A", "France and Switzerland");
            Answer.Rows.Add("3B", 3, "B", "France and Austria");
            Answer.Rows.Add("3C", 3, "C", "Germany and France");
            Answer.Rows.Add("3D", 3, "D", "Italy and France");
            // Question: 4                
            Answer.Rows.Add("4A", 4, "A", "Mediterranean Sea");
            Answer.Rows.Add("4B", 4, "B", "Pacific Ocean");
            Answer.Rows.Add("4C", 4, "C", "Caribean Sea");
            Answer.Rows.Add("4D", 4, "D", "Atlantic Ocean");
            // Question: 5                
            Answer.Rows.Add("5A", 5, "A", "Ulan Bator");
            Answer.Rows.Add("5B", 5, "B", "Tirana");
            Answer.Rows.Add("5C", 5, "C", "Lisbon");
            Answer.Rows.Add("5D", 5, "D", "Vladivostok");
            // Question: 6                
            Answer.Rows.Add("6A", 6, "A", "Georgetown");
            Answer.Rows.Add("6B", 6, "B", "Bogata");
            Answer.Rows.Add("6C", 6, "C", "Maracaibo");
            Answer.Rows.Add("6D", 6, "D", "Caracas");
            // Question: 7                
            Answer.Rows.Add("7A", 7, "A", "Ethiopia");
            Answer.Rows.Add("7B", 7, "B", "Somalia");
            Answer.Rows.Add("7C", 7, "C", "Chad");
            Answer.Rows.Add("7D", 7, "D", "Sudan");
            // Question: 8                
            Answer.Rows.Add("8A", 8, "A", "Europe");
            Answer.Rows.Add("8B", 8, "B", "Africa");
            Answer.Rows.Add("8C", 8, "C", "North America");
            Answer.Rows.Add("8D", 8, "D", "Asia");
            // Question: 9                
            Answer.Rows.Add("9A", 9, "A", "Asia");
            Answer.Rows.Add("9B", 9, "B", "Europe");
            Answer.Rows.Add("9C", 9, "C", "Africa");
            Answer.Rows.Add("9D", 9, "D", "Oceania");
            // Question: 10               
            Answer.Rows.Add("10A", 10, "A", "54 to 46");
            Answer.Rows.Add("10B", 10, "B", "71 to 29");
            Answer.Rows.Add("10C", 10, "C", "51 to 49");
            Answer.Rows.Add("10D", 10, "D", "81 to 19");
            // Questions: 11              
            Answer.Rows.Add("11A", 11, "A", "3");
            Answer.Rows.Add("11B", 11, "B", "4");
            Answer.Rows.Add("11C", 11, "C", "5");
            Answer.Rows.Add("11D", 11, "D", "6");
            // Questions: 12               
            Answer.Rows.Add("12A", 12, "A", "Ulaanbaatar");
            Answer.Rows.Add("12B", 12, "B", "Ottawa");
            Answer.Rows.Add("12C", 12, "C", "Reykjavik");
            Answer.Rows.Add("12D", 12, "D", "Helsinki");
            // Questions: 13               
            Answer.Rows.Add("13A", 13, "A", "Antarctica");
            Answer.Rows.Add("13B", 13, "B", "Sahara");
            Answer.Rows.Add("13C", 13, "C", "Kalahari Desert");
            Answer.Rows.Add("13D", 13, "D", "Arabian Desert");
            // Question: 14               
            Answer.Rows.Add("14A", 14, "A", "Uruguay");
            Answer.Rows.Add("14B", 14, "B", "Peru");
            Answer.Rows.Add("14C", 14, "C", "Brazil");
            Answer.Rows.Add("14D", 14, "D", "Chile");
            // Questions: 15              
            Answer.Rows.Add("15A", 15, "A", "Indonesia");
            Answer.Rows.Add("15B", 15, "B", "Uganda");
            Answer.Rows.Add("15C", 15, "C", "Brazil");
            Answer.Rows.Add("15D", 15, "D", "Venezuela");
            // Question: 16              
            Answer.Rows.Add("16A", 16, "A", "Europe");
            Answer.Rows.Add("16B", 16, "B", "Africa");
            Answer.Rows.Add("16C", 16, "C", "Asia");
            Answer.Rows.Add("16D", 16, "D", "South America");
            // Question: 17                
            Answer.Rows.Add("17A", 17, "A", "South Africa");
            Answer.Rows.Add("17B", 17, "B", "Bolivia");
            Answer.Rows.Add("17C", 17, "C", "Israel");
            Answer.Rows.Add("17D", 17, "D", "The Netherlands");
            // Question: 18              
            Answer.Rows.Add("18A", 18, "A", "Canada");
            Answer.Rows.Add("18B", 18, "B", "France");
            Answer.Rows.Add("18C", 18, "C", "Denmark");
            Answer.Rows.Add("18D", 18, "D", "USA");
            // Questions: 19             
            Answer.Rows.Add("19A", 19, "A", "Monaco");
            Answer.Rows.Add("19B", 19, "B", "Moscow");
            Answer.Rows.Add("19C", 19, "C", "Mogadishu");
            Answer.Rows.Add("19D", 19, "D", "Monrovia");
            // Question: 20              
            Answer.Rows.Add("20A", 20, "A", "Egypt and Sudan");
            Answer.Rows.Add("20B", 20, "B", "Libia and Tunesia");
            Answer.Rows.Add("20C", 20, "C", "Ethiopia and Somalia");
            Answer.Rows.Add("20D", 20, "D", "Israel and Lebanon");
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
