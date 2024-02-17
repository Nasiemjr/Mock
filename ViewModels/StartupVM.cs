using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mock.ViewModels
{
    public class StartupVM
    {
        #region Constructor

        public StartupVM()
        {
            _finishCommand = new RelayCommand(Finish, CanFinish);
        }

        #endregion Constructor

        #region Command Functions

        /// <summary>
        /// Closes the startup view
        /// </summary>
        private void Finish()
        {
            App.Current.CloseStartupWindow();
            App.Current.OpenMainWindow();
        }

        /// <summary>
        /// Can function for the finish function
        /// </summary>
        private bool CanFinish()
        {
            return true;
        }

        #endregion Command Functions

        #region Commands

        public ICommand FinishCmd=> _finishCommand;

        #endregion Commands

        #region Private Member Variables

        private readonly RelayCommand _finishCommand;

        #endregion Private Member Variables
    }
}
