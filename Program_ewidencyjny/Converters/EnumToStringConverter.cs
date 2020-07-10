using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace program_ewidencyjny.Converters
{
    class EnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

        
            string en = Enum.GetName(value.GetType(), (Enum)value);
            return en;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "";
            else
            {
                string en = Enum.GetName(value.GetType(), (Enum)value);
                if (en == "wszystkie")
                    return "";
                else return en;
            }

            
        }
    }
}
