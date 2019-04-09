using Quiz.Components;
using Quiz.DL;
using System;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class InGameUI : Form
    {
        private Database dataBase = null;
        private BL.Quiz quiz = null;
        private int questionNumber = 0;

        public InGameUI()
        {
            InitializeComponent();
            dataBase = new Database();
            quiz = new BL.Quiz();
        }

        public void AskQuestion(object sender, Components.QuestionEventArgs e)
        {
            Questions q = e.Question;
            questionNumberLabel.Text = q.QuestionNumber.ToString();
            questionTextBox.Text = q.QuestionText;
            radioButtonA.Text = q.AnswerTextA;
            radioButtonB.Text = q.AnswerTextB;
            radioButtonC.Text = q.AnswerTextC;
            radioButtonD.Text = q.AnswerTextD;
        }

        #region UI State Management

        private void ResetAnswers()
        {
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }

        private void UpdateStatusPanels(int correctAnswered, int incorrectAnswered, double successPercentage)
        {
            correctCountLabel.Text = correctAnswered.ToString();
            wrongCountLabel.Text = incorrectAnswered.ToString();
            ratePercentLabel.Text = $"{successPercentage} %";
        }

        private bool GetSubmitButtonEnabledState()
        {
            bool result = false;

            result = ((radioButtonA.Checked == true) || (radioButtonB.Checked == true) 
                   || (radioButtonC.Checked == true) || (radioButtonD.Checked == true));

            return result;
        }
        #endregion

        #region Supporting Subroutines

        private void SetupSummaryListView()
        {
            //lvwSummary.Columns.Clear();
            //lvwSummary.Columns.Add("Question", 75, HorizontalAlignment.Left);
            //lvwSummary.Columns.Add("Correct", 75, HorizontalAlignment.Left);
            //lvwSummary.Columns.Add("Submitted", 75, HorizontalAlignment.Left);
            //lvwSummary.Columns.Add("Feedback", 100, HorizontalAlignment.Left);
        }

        private string GetSelectedAnswer()
        {
            string answer = string.Empty;

            if (radioButtonA.Checked == true) { answer = "A"; }
            if (radioButtonB.Checked == true) { answer = "B"; }
            if (radioButtonC.Checked == true) { answer = "C"; }
            if (radioButtonD.Checked == true) { answer = "D"; }

            return answer;
        }

        #endregion

    }
}
