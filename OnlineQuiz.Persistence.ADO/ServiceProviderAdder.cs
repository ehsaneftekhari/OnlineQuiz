using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Persistence.ADO.Repositories;

namespace OnlineQuiz.Persistence.ADO
{
    public class ServiceProviderAdder
    {
        public static void Add(IServiceCollection serviceProvider)
        {
            if (serviceProvider != null)
            {
                serviceProvider.AddTransient<IBaseUserRepository, BaseUserRepository>();
                serviceProvider.AddTransient<IAppMessageRepository, AppMessageRepository>();
                serviceProvider.AddTransient<IUserRepository, UserRepository>();
                serviceProvider.AddTransient<ITestRepository, TestRepository>();
                serviceProvider.AddTransient<ISectionRepository, SectionRepository>();
                serviceProvider.AddTransient<IQuestionRepository, QuestionRepository>();
            }
        }
    }
}
