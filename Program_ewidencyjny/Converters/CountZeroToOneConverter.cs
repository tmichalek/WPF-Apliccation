using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace program_ewidencyjny.Converters
{
    class CountZeroToOneConverter :IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is List<AjWspol>)
            {
                if (value == null || ((value as List<AjWspol>).Count == 0))
                {
                    List<AjWspol> temp = new List<AjWspol>();

                    temp.Add(new AjWspol() { Aj = 1, NrTabeli = 0, Opis = "0" });
                    value = temp;
                    return value;
                }
                return value;
            }

            else if (value is List<PdWspol>)
            {
                if (value == null || ((value as List<PdWspol>).Count == 0))
                {
                    List<PdWspol> temp = new List<PdWspol>();

                    temp.Add(new PdWspol() { Pd = 1, NrTabeli = 0, Opis = "0" });
                    value = temp;
                    return value;
                }
                return value;


            }

            else if (value is List<SuWspol>)
            {
                if (value == null || ((value as List<SuWspol>).Count == 0))
                {
                    List<SuWspol> temp = new List<SuWspol>();

                    temp.Add(new SuWspol() { Su = 1, Opis="0" });
                    value = temp;
                    return value;
                }
                return value;
                    }

            else return value;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return value;
            
        }
    }
}
