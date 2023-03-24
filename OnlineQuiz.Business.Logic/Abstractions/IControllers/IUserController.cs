using OnlineQuiz.Business.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Logic.Abstractions.IControllers
{
    public interface IUserController
    {
        BaseUser AddBaseUser(BaseUserInfo baseUserInfo);
    }
}
