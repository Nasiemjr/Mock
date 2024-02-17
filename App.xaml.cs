using Microsoft.Extensions.DependencyInjection;
using Mock.ViewModels;
using System.Reflection;
using System.Resources;
using System.Windows;

namespace Mock
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object. This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            Services = ConfigureServices();

            this.InitializeComponent();
        }

        /// <summary>
        /// Gets the current <see cref="App"/> instance in use
        /// </summary>
        public new static App Current => (App)Application.Current;

        /// <summary>
        /// Gets the <see cref="IServiceProvider"/> instance to resolve application services.
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // View Models
            services.AddSingleton<MainVM>();
            services.AddSingleton<GamePadVM>();
            services.AddSingleton<LaptopVM>();
            services.AddSingleton<DesktopVM>();
            services.AddSingleton<MobileVM>();
            services.AddSingleton<SettingsVM>();

            // Resource Manager
            services.AddSingleton<ResourceManager>(sp => new ResourceManager("Mock.Resources.SystemStrings", Assembly.GetExecutingAssembly()));


            return services.BuildServiceProvider();
        }
    }

}
