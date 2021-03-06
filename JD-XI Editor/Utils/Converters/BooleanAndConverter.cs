﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace JD_XI_Editor.Utils.Converters
{
    internal class BooleanAndConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.OfType<IConvertible>().All(System.Convert.ToBoolean);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}