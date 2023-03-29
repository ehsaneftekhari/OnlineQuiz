using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Controllers;
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
                serviceProvider.AddTransient<IUserController, UserController>();
                serviceProvider.AddTransient<IUserVerifier, UserVerifier>();
            }
        }
    }
}
