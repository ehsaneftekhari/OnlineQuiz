using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Logic.Abstractions.IControllers;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Controllers;
using OnlineQuiz.Business.Logic.Validators;

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

                Persistence.ADO.ServiceProviderAdder.Add(serviceProvider);
            }
        }
    }
}
