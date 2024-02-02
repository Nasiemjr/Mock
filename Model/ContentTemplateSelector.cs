using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Mock.Model
{
    public class ContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate? ImageTemplate { get; set; }
        public DataTemplate? HamburgerMenuItemTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is HamburgerMenuIconItem)
            {
                return HamburgerMenuItemTemplate;
            }

            else if (item is string)
            {
                return ImageTemplate;
            }
            return base.SelectTemplate(item, container);
        }
    }
}