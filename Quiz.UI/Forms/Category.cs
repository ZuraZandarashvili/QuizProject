using System;
using System.Windows.Forms;
using Quiz.BL.Models;

namespace Quiz.UI.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            var gameForm = new InGameUI();
            
        }

        private void BeckCategorybutton_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Close();
        }

        private void Footballbutton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameForm = new InGameUI();
            gameForm.Show();
        }
        private void Basketballbutton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameForm = new InGameUI();
            gameForm.Show();
        }
        private void Historybutton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameForm = new InGameUI();
            gameForm.Show();
        }
        private void Geographybutton_Click(object sender, EventArgs e)
        {
            Hide();
            var gameForm = new InGameUI();
            gameForm.Show();
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner?.Show();
        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (String.IsNullOrWhiteSpace(userInputTextBox.Text))
            //    PlayerName = "Anonymous";
            //else
            //    PlayerName = userInputTextBox.Text;
        }
    }
}
