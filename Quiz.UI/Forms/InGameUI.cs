using Quiz.Components;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class InGameUI : Form
    {
        public InGameUI()
        {
            InitializeComponent();
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

    }
}
