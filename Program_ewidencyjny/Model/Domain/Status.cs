using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Status
    {
        public int StatusId { get; set; }
        public string NazwaStatus { get; set; }

        public virtual ObservableCollection<Praca> Praca { get; set; }



    }
}
