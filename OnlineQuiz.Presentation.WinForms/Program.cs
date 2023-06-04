using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Presentation.WinForms.Forms;
using OnlineQuiz.Presentation.WinForms.Helpers;

namespace OnlineQuiz.Presentation.WinForms
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        private static void Config()
        {
            ServiceCollection serviceDescriptors = new ServiceCollection();

            Business.Logic.ServiceProviderAdder.RegisterServices(serviceDescriptors);
            Persistence.ADO.ServiceProviderAdder.Add(serviceDescriptors);

            serviceDescriptors.AddTransient(LoginRegister.Create);
            serviceDescriptors.AddSingleton<MainMDIParent>();
            serviceDescriptors.AddTransient<IFormHelper, FormHelper>();
            serviceDescriptors.AddSingleton<IDelegateContainer, DelegateContainer>();
            serviceDescriptors.AddSingleton<ICurrentUserInfoContainer, CurrentUserInfoContainer>();


            ServiceProvider = serviceDescriptors.BuildServiceProvider();
        }

        private static void ShoutDown()
        {
            ServiceProvider?.Dispose();
        }

        [STAThread]
        static void Main()
        {
            Config();

            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<MainMDIParent>());

            ShoutDown();
        }
    }
}