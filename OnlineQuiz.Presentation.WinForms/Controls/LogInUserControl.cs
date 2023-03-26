using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Presentation.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz.Presentation.WinForms.Forms.Controls
{
    public partial class LogInUserControl : UserControl
    {
        IVerifier verifier;
        IFormHelper formHelper;
        public LogInUserControl(IVerifier verifier, IFormHelper formHelper)
        {
            InitializeComponent();
            this.verifier = verifier;
            this.formHelper = formHelper;
        }

        public LogInResults result { get; private set; }

        public User User { get; private set; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserCredential credential = new UserCredential(UsernameTB.Text, PasswordTB.Text);
            User user = verifier.VerifyUser(credential);
            if (user.BaseUserId > 0)
            {
                result = LogInResults.LoggedIn;
                this.User = user;
            }
            else
            {
                formHelper.SetFromFieldModel(user.Username, UsernameTB, messageLb);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            result = LogInResults.Back;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            result = LogInResults.Exit;
        }
    }
    public enum LogInResults
    {
        Exit, Back, LoggedIn
    }
}
