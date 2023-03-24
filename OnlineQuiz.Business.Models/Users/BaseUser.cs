using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Models.Users
{
    public class BaseUser : BaseUserInfo
    {
        public int BaseUserId { get; set; }

        public BaseUser(int baseUserId, string firstName, string lastName, string email, string phoneNumber) : base(firstName, lastName, email, phoneNumber)
        {
            BaseUserId = baseUserId;
        }

        public BaseUser(int baseUserId, BaseUserInfo baseUserInfo) : base(baseUserInfo)
        {
            BaseUserId = baseUserId;
        }
    }
}
