using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;
using System.Resources;
using System.Windows.Controls;

namespace Mock.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM(SettingsVM settingsVM, 
                      GamePadVM gamePadVM, 
                      LaptopVM laptopVM, 
                      DesktopVM desktopVM,
                      MobileVM mobileVM,
                      ResourceManager resourceManager)
        {
            _gamepadVM = gamePadVM;
            _settingsVM = settingsVM;
            _laptopVM = laptopVM;
            _desktopVM = desktopVM;
            _mobileVM = mobileVM;
            _resourceManager = resourceManager;

            CurrentViewModel = settingsVM;
            SetupMenuItems();
            SetupMenuOptions();
            _desktopVM = desktopVM;
            _laptopVM = laptopVM;
        }

        public void SetupMenuItems()
        {

            HamburgerItems = new ObservableCollection<HamburgerMenuIconItem>()
            {

            new HamburgerMenuIconItem()
            {
                Label = _resourceManager.GetString("labelGamepad"),
                Icon = PackIconFontAwesomeKind.GamepadSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _gamepadVM; }),
            },

             new HamburgerMenuIconItem()
            {
                Label = _resourceManager.GetString("labelLaptop"),
                Icon = PackIconFontAwesomeKind.LaptopSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _laptopVM; }),
            },

             new HamburgerMenuIconItem()
            {
                Label = _resourceManager.GetString("labelDesktop"),
                Icon = PackIconFontAwesomeKind.DesktopSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _desktopVM; }),
            },

             new HamburgerMenuIconItem()
            {
                Label = _resourceManager.GetString("labelMobile"),
                Icon = PackIconFontAwesomeKind.MobileSolid,
                Command = new RelayCommand(()=> {CurrentViewModel = _mobileVM; }),
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
        private LaptopVM _laptopVM;
        private DesktopVM _desktopVM;
        private MobileVM _mobileVM;
        private SettingsVM _settingsVM;
        private ResourceManager _resourceManager;

        private int _selectedViewModel = -1;
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuItems = new();
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuOptions = new();
    }
}
