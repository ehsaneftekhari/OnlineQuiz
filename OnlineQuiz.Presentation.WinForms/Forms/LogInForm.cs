using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Presentation.WinForms.FormHelpers;
using User = OnlineQuiz.Business.Models.Users.User;
namespace OnlineQuiz.Presentation.WinForms
{
    public partial class LogInForm : Form
    {
        IVerifier verifier;
        IFormHelper formHelper;

        private LogInForm(IVerifier verifier, IFormHelper formHelper)
        {
            InitializeComponent();
            this.verifier = verifier;
            this.formHelper = formHelper;
        }

        private LogInResults result;

        public static LogInResults Start(IServiceProvider serviceProvider)
        {
            IVerifier verifier = serviceProvider.GetRequiredService<IVerifier>();
            IFormHelper formHelper = serviceProvider.GetRequiredService<IFormHelper>();

            LogInForm instance = new LogInForm(verifier, formHelper);
            instance.ShowDialog();

            return instance.result;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserCredential credential = new UserCredential(UsernameTB.Text, PasswordTB.Text);
            User user = verifier.VerifyUser(credential);
            if (user.BaseUserId > 0)
            {
                result = LogInResults.LoggedIn;
                Close();
            }
            else
            {
                formHelper.SetFromFieldModel(user.Username, UsernameTB, messageLb);
            }
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
        Exit, Back, LoggedIn
    }
}
