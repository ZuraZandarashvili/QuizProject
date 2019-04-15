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
            var categoryForm = new InGameUI();
            categoryForm.Owner = this;
            categoryForm.Show();
        }

        private void MainExitbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }
    }
}
