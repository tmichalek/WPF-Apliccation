using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Enum;

namespace program_ewidencyjny.Model.Domain
{
    class RodzPracy
    {
        public int RodzPracyId { get; set; }
        public  RodzajPracy RodzajPracy { get; set; }

        public virtual ObservableCollection <Praca> Praca { get; set; }

    }
}
