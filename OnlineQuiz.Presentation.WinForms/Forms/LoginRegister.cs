using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Models.Models;
using OnlineQuiz.Business.Models.Models.Users;
using OnlineQuiz.Presentation.WinForms.Helpers;
using User = OnlineQuiz.Business.Models.Models.Users.User;

namespace OnlineQuiz.Presentation.WinForms.Forms
{
    public partial class LoginRegister : Form
    {
        IUserVerifier verifier;
        IFormHelper formHelper;
        IUserController userController;
        IAppMessageRepository appMessageRepository;

        static LoginRegister instance;

        private LoginRegister(IUserVerifier verifier, IFormHelper formHelper, IUserController userController, IAppMessageRepository appMessageRepository)
        {
            InitializeComponent();
            this.verifier = verifier;
            this.formHelper = formHelper;
            this.userController = userController;
            this.appMessageRepository = appMessageRepository;
        }

        public static LoginRegister Create(IServiceProvider serviceProvider)
        {
            IUserVerifier verifier = serviceProvider.GetRequiredService<IUserVerifier>();
            IFormHelper formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            IUserController userController = serviceProvider.GetRequiredService<IUserController>();
            IAppMessageRepository appMessageRepository = serviceProvider.GetRequiredService<IAppMessageRepository>();

            if (instance == null || instance.IsDisposed)
                instance = new LoginRegister(verifier, formHelper, userController, appMessageRepository);

            return instance;
        }

        public Action<User> OnLogIn;

        public Action<BaseUser> OnBaseUserRegister;

        public Action<User> OnUserRegister;

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserCredential credential = new UserCredential(LoginUsernameTB.Text, LoginPasswordTB.Text);
            User user = verifier.VerifyUserCredential(credential);

            formHelper.SetFromFieldModel(user.Username, LoginUsernameTB, LoginMessageLb);

            if (user.HasId())
                InvokeOnLogIn(user);
        }

        private void InvokeOnLogIn(User user)
        {
            if (OnLogIn != null)
                OnLogIn.Invoke(user);

            Close();
        }

        private void RegisterBaseUserBtn_Click(object sender, EventArgs e)
        {
            BaseUser newUserInfo = new BaseUser(
                RegisterFirstNameTB.Text,
                RegisterLastNameTB.Text,
                RegisterEmailTB.Text,
                RegisterPhoneNumberTB.Text
                );

            newUserInfo = userController.AddBaseUser(newUserInfo);

            clearBaseUserRegisterFields();
            SetBaseUserRegisterFields(newUserInfo);

            if (newUserInfo.HasId())
                InvokeOnBaseUserRegister(newUserInfo);
        }

        private void InvokeOnBaseUserRegister(BaseUser baseUser)
        {
            if (OnBaseUserRegister != null)
                OnBaseUserRegister.Invoke(baseUser);

            Close();
        }

        private void clearBaseUserRegisterFields()
        {
            BaseUser emptyBaseUser = new BaseUser();
            SetBaseUserRegisterFields(emptyBaseUser);
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

        private void RegisterUserBtn_Click(object sender, EventArgs e)
        {
            User newUser = new User(
                RegisterFirstNameTB.Text,
                RegisterLastNameTB.Text,
                RegisterEmailTB.Text,
                RegisterPhoneNumberTB.Text,
                RegisterUsernameTB.Text
                );

            Field<string> tempPasswordField = new Field<string>(RegisterPasswordTB.Text);
            Field<string> tempPasswordVerifyField = new Field<string>(RegisterPasswordVerifyTB.Text);

            newUser = userController.AddUser(newUser, tempPasswordField, tempPasswordVerifyField);

            clearUserRegisterFields();
            SetUserRegisterFields(newUser, tempPasswordField, tempPasswordVerifyField);

            if (newUser.HasId())
                InvokeOnLogIn(newUser);
        }

        private void clearUserRegisterFields()
        {
            User tempEmptyUser = new User();
            Field<string> tempEmptyPasswordField = new Field<string>(string.Empty);
            Field<string> tempEmptyPasswordVerifyField = new Field<string>(string.Empty);

            SetUserRegisterFields(tempEmptyUser, tempEmptyPasswordField, tempEmptyPasswordVerifyField);
        }

        private void SetUserRegisterFields(User? user, Field<string> password, Field<string> passwordVerify)
        {
            if (user != null)
            {
                SetBaseUserRegisterFields(user);
                formHelper.SetFromFieldModel(user.Username, RegisterUsernameTB, RegisterUsernameMessageLbl);
                formHelper.SetFromFieldModel(password, RegisterPasswordTB, RegisterPasswordMessageLbl);
                formHelper.SetFromFieldModel(passwordVerify, RegisterPasswordVerifyTB, RegisterPasswordVerifyMessageLbl);
            }
        }
    }
}
