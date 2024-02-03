using MahApps.Metro.Controls;
using Microsoft.Extensions.DependencyInjection;
using Mock.ViewModels;
using System;

namespace Mock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = App.Current.Services.GetService<MainVM>();
        }
    }
}