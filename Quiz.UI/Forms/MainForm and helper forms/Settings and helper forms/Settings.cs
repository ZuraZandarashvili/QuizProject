using Quiz.UI.Forms.MainForm_and_helper_forms.Settings_and_helper_forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void BeckSettingsbutton_Click(object sender, EventArgs e)
        {
            var mainform = new MainForm();
            mainform.ShowDialog();
        }

        private void HighScoresStatisticsbutton_Click(object sender, EventArgs e)
        {
            var highScoreForm = new HighScoreForm();
            highScoreForm.ShowDialog();
        }

        private void GameModebutton_Click(object sender, EventArgs e)
        {
            var gamemode = new GameModeForm();
            gamemode.ShowDialog();
        }
    }
}
