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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void BeckCategorybutton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.ShowDialog();
        }
    }
}
