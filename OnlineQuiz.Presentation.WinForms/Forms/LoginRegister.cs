using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Presentation.WinForms.Helpers;
using User = OnlineQuiz.Business.Models.Users.User;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class LoginRegister : Form
    {
        IVerifier verifier;
        IFormHelper formHelper;
        IUserController userController;

        static LoginRegister instance;

        private LoginRegister(IVerifier verifier, IFormHelper formHelper, IUserController userController)
        {
            InitializeComponent();
            this.verifier = verifier;
            this.formHelper = formHelper;
            this.userController = userController;
        }

        public static LoginRegister Create(IServiceProvider serviceProvider)
        {
            IVerifier verifier = serviceProvider.GetRequiredService<IVerifier>();
            IFormHelper formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            IUserController userController = serviceProvider.GetRequiredService<IUserController>();

            if (instance == null || instance.IsDisposed)
                instance = new LoginRegister(verifier, formHelper, userController);

            return instance;
        }

        public Action<User> OnLogIn;

        public Action<BaseUser> OnBaseUserRegister;


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserCredential credential = new UserCredential(LoginUsernameTB.Text, LoginPasswordTB.Text);
            User user = verifier.VerifyUser(credential);

            if (user.BaseUserId > 0)
                InvokeOnLogIn(user);
            else
                formHelper.SetFromFieldModel(user.Username, LoginUsernameTB, LoginMessageLb);
        }

        private void InvokeOnLogIn(User user)
        {
            if (OnLogIn != null)
                OnLogIn.Invoke(user);
        }

        private void RegisterBaseUserBtn_Click(object sender, EventArgs e)
        {
            BaseUser newUserInfo = new BaseUser(RegisterFirstNameTB.Text, RegisterLastNameTB.Text, RegisterEmailTB.Text, RegisterPhoneNumberTB.Text);

            newUserInfo = userController.AddBaseUser(newUserInfo);

            SetBaseUserRegisterFields(newUserInfo);

            if (newUserInfo.HasId())
                InvokeOnBaseUserRegister(newUserInfo);
        }

        private void InvokeOnBaseUserRegister(BaseUser baseUser)
        {
            if (OnBaseUserRegister != null)
                OnBaseUserRegister.Invoke(baseUser);
        }

        private void SetBaseUserRegisterFields(BaseUser? baseUser)
        {
            if (baseUser != null)
            {
                formHelper.SetFromFieldModel(baseUser.FirstName, RegisterFirstNameTB, RegisterFirstNameMessageLbl);
                formHelper.SetFromFieldModel(baseUser.LastName, RegisterLastNameTB, RegisterLastNameMessageLbl);
                formHelper.SetFromFieldModel(baseUser.Email, RegisterEmailTB, RegisterEmailMessageLbl);
                formHelper.SetFromFieldModel(baseUser.PhoneNumber, RegisterPhoneNumberTB, RegisterPhoneNumberMessageLbl);
            }
        }
    }
}
