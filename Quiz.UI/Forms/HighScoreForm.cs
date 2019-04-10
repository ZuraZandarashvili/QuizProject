using System;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class HighScoreForm : Form
    {
        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void HighScoureBackbutton_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Close();
        }
    }
}
