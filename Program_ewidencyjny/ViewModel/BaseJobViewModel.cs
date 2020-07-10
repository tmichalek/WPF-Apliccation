using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_ewidencyjny.ViewModel
{
    class BaseJobViewModel:BaseViewModel
    {
        public BaseJobViewModel()

        {
           
                _zgloszenie = new PracaIzynierskaDBContext();
           
        }

        protected PracaIzynierskaDBContext _zgloszenie { get; set; }

        

        


    }
}
