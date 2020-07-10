using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace program_ewidencyjny.Converters
{
    class StringToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((value == null) || (string.IsNullOrWhiteSpace(value.ToString())))
                return 1;
            else
            {
                double temporary = double.Parse(value.ToString());
                return temporary;
            }
        }
    }
}
