﻿using OnlineQuiz.Business.Models.Models.Users;

namespace OnlineQuiz.Business.Logic.Abstractions.IVerifiers
{
    public interface IUserVerifier
    {
        User VerifyUserCredential(UserCredential credential);

        public bool VerifyUserFields(User newUser);
    }
}