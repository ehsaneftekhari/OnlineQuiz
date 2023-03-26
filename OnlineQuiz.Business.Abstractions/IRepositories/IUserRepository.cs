﻿using OnlineQuiz.Business.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Business.Abstractions.IRepositories
{
    public interface IUserRepository
    {
        int VerifyUser(UserCredential credential);
    }
}