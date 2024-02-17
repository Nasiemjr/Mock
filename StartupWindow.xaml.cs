using MahApps.Metro.Controls;
using Microsoft.Extensions.DependencyInjection;
using Mock.ViewModels;
using System;

namespace Mock
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : MetroWindow
    {
        public StartupWindow()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService<StartupVM>();
        }
    }
}
