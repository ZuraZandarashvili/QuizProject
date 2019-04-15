using System;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Startgamebutton_Click(object sender, EventArgs e)
        {
            Hide();
            var categoryForm = new CategoryForm();
            categoryForm.Owner = this;
            categoryForm.Show();
        }

        private void MainExitbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void GameModesButton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameModeForm = new GameModeForm();
            gameModeForm.Owner = this;
            gameModeForm.Show();
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            Hide();
            var highScoresForm = new HighScoreForm();
            highScoresForm.Owner = this;
            highScoresForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }
    }
}
