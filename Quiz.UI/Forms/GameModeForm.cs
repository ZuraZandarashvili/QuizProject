using System;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class GameModeForm : Form
    {
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Close();
        }
    }
}
