using Quiz.BL.Services;
using Quiz.UI.TestServices;
using System;
using System.Windows.Forms;
using System.Linq;

namespace Quiz.UI.Forms
{
    public partial class HighScoreForm : Form
    {
        IRecordService recordService;

        public HighScoreForm()
        {
            InitializeComponent();

            recordService = new RecordService();

            recordsListBox.DataSource = recordService.GetRecords().OrderByDescending(r => r.Score).ToList();
            recordsListBox.DisplayMember = "Info";
        }

        private void HighScoureBackbutton_Click(object sender, EventArgs e)
        {
           
            Close();
        }

       

        private void HighScoreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner?.Show();

        }
    }
}
