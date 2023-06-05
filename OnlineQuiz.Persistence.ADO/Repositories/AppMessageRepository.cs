using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Library;

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

            Messages.Add("en_Test_EmptyTitle", "Title can not be empty");
            Messages.Add("en_Test_LongTitle", "Title can not be longer than 32 characters");
            Messages.Add("en_Test_SameStart&End", "Start and End can not be same");
            Messages.Add("en_Test_EarlierEnd", "End can not be Earlier than Start");
            Messages.Add("en_Test_LateStart", "Start can not be later than End");
            Messages.Add("en_Test_NotSeatedStart", "Start should be set");
            Messages.Add("en_Test_NotSeatedEnd", "End should be set");
            Messages.Add("en_Test_AddTestUnknownError", "An unknown Error happened while adding the test");

            Messages.Add("en_Section_EmptyTitle", "Title can not be empty");
            Messages.Add("en_Section_LongTitle", "Title can not be longer than 32 characters");
            Messages.Add("en_Section_SameStart&End", "Start and End can not be same");
            Messages.Add("en_Section_EarlierEnd", "End can not be Earlier than Start");
            Messages.Add("en_Section_LateStart", "Start can not be later than Start");
            Messages.Add("en_Section_TestAndSectionNotSameStart", "Start date and time should be equal with sections");
            Messages.Add("en_Section_TestAndSectionNotSameEnd", "End date and time should be equal with sections");
            Messages.Add("en_Section_NotEnoughTestDuration", "xxxx");
            Messages.Add("en_Section_LessThanZeroOrder", "xxxx");
            Messages.Add("en_Section_ZeroAttemptLimit", "xxxx");
            Messages.Add("en_Section_SectionDidNotDeleted", "xxxx");

            Messages.Add("en_Question_EmptyText", "Text of Question can not be Empty");
            Messages.Add("en_Question_LongText", "Text of Question can not be longer than 4000 characters");
            Messages.Add("en_Question_LessThanZeroOrder", "Order of Question can not be less than 0");
            Messages.Add("en_Question_LessThanOneOrderOnNonRandomizeQuestions", "Order of Question can not be less than 1," +
                "\nbecause the section has no randomize question option");
            ///////////

            Messages.Add("en_AddTestForm_TestAddedSuccessfully", "Test added successfully");
        }

        public string GetMessage(string messageTitle)
        {
            ThrowHelper.ThrowNullOrEmptyStringException(messageTitle, nameof(messageTitle));

            return Messages[messageTitle];
        }
    }
}
