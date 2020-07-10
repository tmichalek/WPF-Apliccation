﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace program_ewidencyjny.Converters
{
    class EmptyStringToPercentConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {


            if (value == null || string.IsNullOrWhiteSpace(value.ToString()) || (string)value=="wszystkie")
                return "";
            else
                return value;
        }
    }
}

