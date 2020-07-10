using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Polozenie
    {
        public int PolozenieId { get; set; }

        public int PracaId { get; set; }
        public Praca Praca { get; set; }

        
        public virtual ObservableCollection<X_Y >X_Y { get; set; }

    }
}
