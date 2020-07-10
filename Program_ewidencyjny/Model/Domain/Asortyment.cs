using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Asortyment
    {
        public int AsortymentId { get; set; }
       // public RodzajPracy RodzajPracy { get; set; }
        public CelPracy CelPracy { get; set; }

        public virtual ObservableCollection<Praca> Praca { get; set; }

    }
}
