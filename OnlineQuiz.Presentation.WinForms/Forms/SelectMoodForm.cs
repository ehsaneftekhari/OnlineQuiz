using System.ComponentModel;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class SelectMoodForm : Form
    {
        public SelectMoodForm()
        {
            InitializeComponent();
        }

        private SelectMoodResults result;

        public static SelectMoodResults Start()
        {
            SelectMoodForm instance = new SelectMoodForm();
            instance.ShowDialog();
            return instance.result;
        }

        private void AdminSelectBtn_Click(object sender, EventArgs e)
        {
            result = SelectMoodResults.UserSelected;
            Close();
        }

        private void QuizSelectBtn_Click(object sender, EventArgs e)
        {
            result = SelectMoodResults.QuizSelected;
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            result = SelectMoodResults.Exit;
            Close();
        }
    }

    public enum SelectMoodResults
    {
        Exit, UserSelected, QuizSelected
    }
}