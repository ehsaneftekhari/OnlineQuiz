﻿using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Services;
using OnlineQuiz.Business.Logic.Validators;
using OnlineQuiz.Business.Logic.Verifiers;

namespace OnlineQuiz.Business.Logic
{
    public class ServiceProviderAdder
    {
        public static void Add(IServiceCollection serviceProvider)
        {
            if (serviceProvider != null)
            {
                serviceProvider.AddTransient<IValidatorFunctions, ValidatorFunctions>();
                serviceProvider.AddTransient<IUserValidator, UserValidator>();
                serviceProvider.AddTransient<IUserService, UserService>();
                serviceProvider.AddTransient<IUserVerifier, UserVerifier>();
                serviceProvider.AddTransient<ITestService, TestService>();
                serviceProvider.AddTransient<ITestValidator, TestValidator>();
                serviceProvider.AddTransient<ISectionService, SectionService>();
                serviceProvider.AddTransient<IQuestionService, QuestionService>();
                serviceProvider.AddTransient<IAppMessageService, AppMessageService>();
                serviceProvider.AddTransient<ISectionValidator, SectionValidator>();
                serviceProvider.AddTransient<ISectionVerifier, SectionVerifier>();
            }
        }
    }
}
