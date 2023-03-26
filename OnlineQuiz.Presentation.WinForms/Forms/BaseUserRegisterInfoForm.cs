using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class BaseUserRegisterInfoForm : Form
    {
        IUserController userController;
        IFormHelper formHelper;

        BaseUserRegisterInfoResults result;
        BaseUser? baseUser;

        private BaseUserRegisterInfoForm(IUserController userController, IFormHelper formHelper, BaseUser? baseUser = null)
        {
            InitializeComponent();
            this.userController = userController;
            this.formHelper = formHelper;

            this.baseUser = baseUser;
            SetFields(baseUser);
        }

        public static (BaseUserRegisterInfoResults result, BaseUser? baseUser) Start(IServiceProvider serviceProvider, BaseUser? baseUser = null)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            IUserController? UserController = serviceProvider.GetRequiredService<IUserController>();
            if (UserController == null)
                throw new Exception();

            IFormHelper formHelper = serviceProvider.GetRequiredService<IFormHelper>();
            if (formHelper == null)
                throw new Exception();

            BaseUserRegisterInfoForm instance = new BaseUserRegisterInfoForm(UserController, formHelper, baseUser);

            instance.ShowDialog();
            return (instance.result, instance.baseUser);
        }

        private void SetFields(BaseUser? baseUser)
        {
            if (baseUser != null)
            {
                formHelper.SetFromFieldModel(baseUser.FirstName, FirstNameTB, FirstNameMessageLbl);
                formHelper.SetFromFieldModel(baseUser.LastName, LastNameTB, LastNameMessageLbl);
                formHelper.SetFromFieldModel(baseUser.Email, EmailTB, EmailMessageLbl);
                formHelper.SetFromFieldModel(baseUser.PhoneNumber, PhoneNumberTB, PhoneNumberMessageLbl);
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            BaseUser newUserInfo = new BaseUser(FirstNameTB.Text, LastNameTB.Text, EmailTB.Text, PhoneNumberTB.Text);
            if (baseUser == null || !baseUser.HasEqualFieldsValues(newUserInfo))
            {
                baseUser = userController.AddBaseUser(newUserInfo);
                SetFields(baseUser);
            }

            if (baseUser.HasId())
            {
                result = BaseUserRegisterInfoResults.Registered;
                Close();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            result = BaseUserRegisterInfoResults.Back;
            Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            result = BaseUserRegisterInfoResults.Exit;
            Close();
        }
    }

    public enum BaseUserRegisterInfoResults
    {
        Exit, Back, Registered
    }
}
