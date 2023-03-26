using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Business.Abstractions.IRepositories;
using OnlineQuiz.Persistence.ADO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }
        }
    }
}
