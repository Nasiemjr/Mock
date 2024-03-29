﻿using MahApps.Metro.Converters;
using System.Globalization;
using System.IO;

namespace Mock.Converters
{
    public class FilepathToFilenameConverter : MarkupConverter
    {
        protected override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string path)
            {
                return Path.GetFileNameWithoutExtension(path);
            }
            return null;
        }

        protected override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}