using Quiz.BL;
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
        private int ticks;

        public InGameUI()
        {
            InitializeComponent();
            dataBase = new Database();
            quiz = new BL.Quiz();
            timer1.Start();
        }

        private void InGameUI_Load(object sender, EventArgs e)
        {
            dataBase.QuestionAcquired += AskQuestion;
            dataBase.AnswerProvided += quiz.ProvideAnswer;
            dataBase.DatabaseLoaded += quiz.LoadDB;
            quiz.AnswerEvaluated += EvaluateAnswer;
            quiz.QuizEnded += Quiz_QuizEnded;

            dataBase.QueryDatabase();
            submitButton.Enabled = GetSubmitButtonEnabledState();
            UpdateStatusPanels(0, 0, 0);
            SetupSummaryListView();

            questionNumber++;
            dataBase.GetQuestion(questionNumber);
            statsPanel.SendToBack();
            listView1.Hide();
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
        public void EvaluateAnswer(object sender, EvaluationEventArgs e)
        {
            UpdateStatusPanels(e.CorrectAnswers, e.WrongAnswers, e.SuccessRate);
            MessageBox.Show(e.Feedback, "Quiz Challenge", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Quiz_QuizEnded(object sender, QuizEndEventArgs e)
        {
            timer1.Stop();
            statsPanel.BringToFront();
            listView1.Show();
            foreach (Summarize listItem in e.QuizSummary)
            {
                ListViewItem i = new ListViewItem();
                i.Text = listItem.QuestionNumber.ToString();
                ListViewItem.ListViewSubItem s1 = new ListViewItem.ListViewSubItem();
                s1.Text = listItem.CorrectAnswer;
                i.SubItems.Add(s1);
                ListViewItem.ListViewSubItem s2 = new ListViewItem.ListViewSubItem();
                s2.Text = listItem.SubmittedAnswer;
                i.SubItems.Add(s2);
                ListViewItem.ListViewSubItem s3 = new ListViewItem.ListViewSubItem();
                s3.Text = listItem.Feedback;
                i.SubItems.Add(s3);

                listView1.Items.Add(i);
            }
        }


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
            ratePercentLabel.Text = successPercentage.ToString("#.##") + "%";
        }
        private bool GetSubmitButtonEnabledState()
        {
            bool result = false;

            result = ((radioButtonA.Checked == true) || (radioButtonB.Checked == true) 
                   || (radioButtonC.Checked == true) || (radioButtonD.Checked == true));

            return result;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            quiz.Evaluate(questionNumber, GetSelectedAnswer());
            ResetAnswers();
                        
            submitButton.Enabled = GetSubmitButtonEnabledState();
            questionNumber++;
            dataBase.GetQuestion(questionNumber);
        }
        private void RadioButtonA_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = GetSubmitButtonEnabledState();
        }
        private void RadioButtonB_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = GetSubmitButtonEnabledState();
        }
        private void RadioButtonC_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = GetSubmitButtonEnabledState();
        }
        private void RadioButtonD_Click(object sender, EventArgs e)
        {
            submitButton.Enabled = GetSubmitButtonEnabledState();
        }

        public void SetupSummaryListView()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Question", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Correct", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Submitted", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Feedback", 200, HorizontalAlignment.Left);
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

        private void InGameUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();

            //Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            timeLabel.Text = ticks.ToString();
        }
    }
}