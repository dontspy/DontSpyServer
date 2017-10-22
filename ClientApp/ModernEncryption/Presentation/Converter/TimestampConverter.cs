﻿using System;
using System.Globalization;
using ModernEncryption.Utils;
using Xamarin.Forms;

namespace ModernEncryption.Presentation.Converter
{
    internal class TimestampConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return TimeManagement.UnixTimestampToDateTime((int)value).ToString(culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
