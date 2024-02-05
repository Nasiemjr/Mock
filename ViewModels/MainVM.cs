using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Mock.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM(SettingsVM settingsVM, GamePadVM gamePadVM)
        {
            _gamepadVM = gamePadVM;
            _settingsVM = settingsVM;

            CurrentViewModel = settingsVM;
            SetupMenuItems();
            SetupMenuOptions();
        }

        public void SetupMenuItems()
        {

            HamburgerItems = new ObservableCollection<HamburgerMenuIconItem>()
            {

            new HamburgerMenuIconItem()
            {
                Label = "Gamepad",
                Icon = PackIconFontAwesomeKind.GamepadSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _gamepadVM; }),
            },

             new HamburgerMenuIconItem()
            {
                Label = "Laptop",
                Icon = PackIconFontAwesomeKind.LaptopSolid,
            },

             new HamburgerMenuIconItem()
            {
                Label = "Desktop",
                Icon = PackIconFontAwesomeKind.DesktopSolid,
            },

             new HamburgerMenuIconItem()
            {
                Label = "Mobile",
                Icon = PackIconFontAwesomeKind.MobileSolid,
            },
        };
        }

        public void SetupMenuOptions()
        {

            HamburgerOptions = new ObservableCollection<HamburgerMenuIconItem>()
            {

            new HamburgerMenuIconItem()
            {
                Label = "Settings",
                Icon = PackIconFontAwesomeKind.WrenchSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _settingsVM; }),
            },
        };
        }

        public ObservableCollection<HamburgerMenuIconItem> HamburgerItems
        {
            get => _hamburgerMenuItems;
            set
            {
                SetProperty(ref _hamburgerMenuItems, value);
            }
        }

        public ObservableCollection<HamburgerMenuIconItem> HamburgerOptions
        {
            get => _hamburgerMenuOptions;
            set
            {
                SetProperty(ref _hamburgerMenuOptions, value);
            }
        }

        public BaseVM CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                SetProperty(ref _currentViewModel, value);
            }
        }

        public int SelectedMenuItem
        {
            get => _selectedViewModel;
            set
            {
                SetProperty(ref _selectedViewModel, value);
            }
        }


        private BaseVM _currentViewModel;
        private GamePadVM _gamepadVM;
        private SettingsVM _settingsVM;
        private int _selectedViewModel = -1;
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuItems = new();
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuOptions = new();
    }
}
