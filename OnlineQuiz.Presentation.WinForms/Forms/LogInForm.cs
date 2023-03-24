using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class LogInForm : Form
    {
        private LogInForm()
        {
            InitializeComponent();
        }

        private LogInResults result;
        public string username { private set; get; }

        public static LogInResults Start()
        {
            LogInForm instance = new LogInForm();
            instance.ShowDialog();

            return instance.result;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            result = LogInResults.OK;
            Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            result = LogInResults.Back;
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            result = LogInResults.Exit;
            Close();
        }
    }


    public enum LogInResults
    {
        Exit, Back, OK
    }
}
