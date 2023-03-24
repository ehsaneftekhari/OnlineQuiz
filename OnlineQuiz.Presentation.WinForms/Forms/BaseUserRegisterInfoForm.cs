using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Models;
using OnlineQuiz.Business.Models.Users;
using OnlineQuiz.Presentation.WinForms.FormHelpers;

namespace OnlineQuiz.Presentation.WinForms
{
    public partial class BaseUserRegisterInfoForm : Form
    {
        IUserController userController;
        IFormHelper formHelper;
        public BaseUserRegisterInfoForm(IUserController userController, IFormHelper formHelper)
        {
            InitializeComponent();
            this.userController = userController;
            this.formHelper = formHelper;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            BaseUserInfo userInfo = new BaseUserInfo(FirstNameTB.Text, LastNameTB.Text, EmailTB.Text, PhoneNumberTB.Text);
            
            userController.AddBaseUser(userInfo);

            formHelper.SetTextFormValue(userInfo.FirstName, FirstNameTB, FirstNameMessageLbl);
            formHelper.SetTextFormValue(userInfo.LastName, LastNameTB, LastNameMessageLbl);
            formHelper.SetTextFormValue(userInfo.Email, EmailTB, EmailMessageLbl);
            formHelper.SetTextFormValue(userInfo.PhoneNumber, PhoneNumberTB, PhoneNumberMessageLbl);
        }


    }
}
