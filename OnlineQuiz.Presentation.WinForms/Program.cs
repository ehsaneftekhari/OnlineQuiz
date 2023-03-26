using Microsoft.Extensions.DependencyInjection;
using OnlineQuiz.Presentation.WinForms.FormHelpers;
using OnlineQuiz.Presentation.WinForms.Forms.Controls;
using System;

namespace OnlineQuiz.Presentation.WinForms
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }

        private static void Config()
        {
            ServiceCollection serviceDescriptors = new ServiceCollection();

            Business.Logic.ServiceProviderAdder.Add(serviceDescriptors);
            Persistence.ADO.ServiceProviderAdder.Add(serviceDescriptors);

            serviceDescriptors.AddSingleton<BaseUserRegisterInfoForm>();
            serviceDescriptors.AddSingleton<LogInUserControl>();
            serviceDescriptors.AddTransient<IFormHelper, FormHelper>();

            ServiceProvider = serviceDescriptors.BuildServiceProvider();
        }

        private static void ShoutDown()
        {
            ServiceProvider?.Dispose();
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainPanelFrom(ServiceProvider));
            Application.Run(new QuizDesignerMDIParent());
            ShoutDown();
        }
    }
}