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
        /// Called during startup of application
        /// </summary>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            CurrentMainWindow = new MainWindow();
            CurrentStartupWindow = new StartupWindow();

            CurrentStartupWindow.Show();
        }

        /// <summary>
        /// Called during exit of application
        /// </summary>
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }

        /// <summary>
        /// Closes the Startup Window
        /// </summary>
        public void CloseStartupWindow()
        {
            CurrentStartupWindow.Close();
        }

        /// <summary>
        /// Opens the Main Window
        /// </summary>
        public void OpenMainWindow()
        {
            CurrentMainWindow.Show();
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
        /// Instance of the Startup Window
        /// </summary>
        public StartupWindow CurrentStartupWindow { get; set; }

        /// <summary>
        /// Instance of the Main Window
        /// </summary>
        public MainWindow CurrentMainWindow { get; set; }

        /// <summary>
        /// Configures the services for the application.
        /// </summary>
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // View Models
            services.AddSingleton<StartupVM>();
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
