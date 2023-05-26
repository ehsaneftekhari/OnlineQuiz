using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.Events;
using OnlineQuiz.Business.Logic.Abstractions.IServices;
using OnlineQuiz.Business.Logic.Abstractions.IValidators;
using OnlineQuiz.Business.Logic.Abstractions.IVerifiers;
using OnlineQuiz.Business.Logic.Events.EventAggregators;
using OnlineQuiz.Business.Logic.Services;
using OnlineQuiz.Business.Logic.Validators;
using OnlineQuiz.Business.Logic.Verifiers;
using Prism.Events;
using System.Reflection;

namespace OnlineQuiz.Business.Logic
{
    public class ServiceProviderAdder
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            if (serviceCollection != null)
            {
                serviceCollection.AddTransient<IValidatorFunctions, ValidatorFunctions>();
                serviceCollection.AddTransient<IUserValidator, UserValidator>();
                serviceCollection.AddTransient<IUserService, UserService>();
                serviceCollection.AddTransient<IUserVerifier, UserVerifier>();
                serviceCollection.AddTransient<ITestService, TestService>();
                serviceCollection.AddTransient<ITestValidator, TestValidator>();
                serviceCollection.AddTransient<ISectionService, SectionService>();
                serviceCollection.AddTransient<IQuestionService, QuestionService>();
                serviceCollection.AddTransient<IAppMessageService, AppMessageService>();
                serviceCollection.AddTransient<ISectionValidator, SectionValidator>();
                serviceCollection.AddTransient<ISectionVerifier, SectionVerifier>();
                serviceCollection.AddSingleton<ICustomEventAggregator, CustomEventAggregator>();
            }
        }
        //public static void AddEvents(IServiceProvider serviceProvider)
        //{
        //    IEventAggregator eventAggregator = serviceProvider.GetRequiredService<IEventAggregator>();

        //    var assembly = Assembly.GetExecutingAssembly();
        //    var observers = assembly.GetTypes().Where(x => x.IsAssignableTo(typeof(EventBase)) && !x.IsAbstract).ToList();


        //    observers.ForEach(o => eventAggregator.AddEvent((Activator.CreateInstance(o) as EventBase<TPayload>)!));

        //}
    }
}
