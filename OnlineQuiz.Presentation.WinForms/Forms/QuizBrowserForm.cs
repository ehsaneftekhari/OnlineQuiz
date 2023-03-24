using System.Diagnostics;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class QuizBrowserForm : Form
    {

        private QuizBrowserForm()
        {
            InitializeComponent();
            Result = QuizBrowserFormResults.Exit;
        }

        private QuizBrowserFormResults Result { get; set; }

        private int QuizId { get; set; }

        public static (QuizBrowserFormResults result, int quizId) Start()
        {
            QuizBrowserForm instance = new QuizBrowserForm();
            instance.ShowDialog();

            return (instance.Result, instance.QuizId);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Result = QuizBrowserFormResults.Exit;
            Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Result = QuizBrowserFormResults.Back;
            Close();
        }
    }

    public enum QuizBrowserFormResults
    {
        Exit, Back, SelectQuiz
    }
}
