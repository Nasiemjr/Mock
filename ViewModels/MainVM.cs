using MahApps.Metro.Controls;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Mock.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM(SettingsVM settingsVM)
        {
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

        public HamburgerMenuIconItem SelectedMenuItem { get; set; }


        private BaseVM _currentViewModel;
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuItems = new();
        private ObservableCollection<HamburgerMenuIconItem> _hamburgerMenuOptions = new();
    }
}
