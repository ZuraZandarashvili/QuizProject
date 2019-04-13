using System.Windows.Forms;

namespace Quiz.UI.Forms
{
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        public void SetupSummaryListView()
        {
            listView1.Columns.Clear();
            listView1.Columns.Add("Question", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Correct", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Submitted", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Feedback", 100, HorizontalAlignment.Left);
        }
    }
}
