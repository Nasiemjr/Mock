namespace Mock.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM(SettingsVM settingsVM)
        {
            CurrentViewModel = settingsVM;
        }

        public BaseVM CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }

        private BaseVM _currentViewModel;
    }
}
