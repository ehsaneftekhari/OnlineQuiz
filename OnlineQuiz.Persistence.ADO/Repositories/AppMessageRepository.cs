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
        }
        public string GetMessage(string messageTitle)
        {
            return Messages[messageTitle];
        }
    }
}
