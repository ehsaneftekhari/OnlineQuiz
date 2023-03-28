using OnlineQuiz.Business.Abstractions.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Repositories
{
    internal class AppMessageRepository : IAppMessageRepository
    {
        private IDictionary<string, string> Messages { get; init; }
        public AppMessageRepository()
        {
            Messages = new Dictionary<string, string>();

            Messages.Add("en_BaseUserInfo_EmptyFirstName", "First Name can not be empty");
            Messages.Add("en_BaseUserInfo_EmptyLastName", "Last Name can not be empty");
            Messages.Add("en_BaseUserInfo_EmptyEmail", "Email can not be empty");
            Messages.Add("en_BaseUserInfo_EmptyPhoneNumber", "Phone number can not be empty");
            Messages.Add("en_BaseUserInfo_LongFirstName","First Name can not be longer than 32 characters");
            Messages.Add("en_BaseUserInfo_LongLastName", "Last Name can not be longer than 32 characters");
            Messages.Add("en_BaseUserInfo_EmailWrongFormat", "Email is not in correct format");
            Messages.Add("en_BaseUserInfo_PhoneNumberWrongFormat", "Phone number is not in correct format");

            Messages.Add("en_User_InvalidCredentials", "Username or Password is not valid");
            Messages.Add("en_User_InvalidUsername", "Username is not valid.\n(only a-b A-B 0-9 - _ . (no Space)])");
            Messages.Add("en_User_InvalidLongUsername", "Username is to long");
            Messages.Add("en_User_InvalidShortUsername", "Username is to short");
            Messages.Add("en_User_InvalidEmptyUsername", "Username can not be empty");
            Messages.Add("en_User_UsernameInUse", "Username is in use");
            Messages.Add("en_User_EmailInUse", "Email is in use");
            Messages.Add("en_User_PhoneNumberInUse", "PhoneNumber is in use");
            Messages.Add("en_User_EmptyPassword", "Password can not be empty");
            Messages.Add("en_User_NotEqualPasswordVerify", "Password and it's Verify are not Equal");

        }
        public string GetMessage(string messageTitle)
        {
            return Messages[messageTitle];
        }
    }
}
