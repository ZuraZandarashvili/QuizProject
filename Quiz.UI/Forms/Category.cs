using System;
using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void BeckCategorybutton_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Close();
        }
    }
}
