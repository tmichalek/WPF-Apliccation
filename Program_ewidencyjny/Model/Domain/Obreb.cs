using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Obreb
    {
        public int ObrebId { get; set; }
        public string Nr_teryt { get; set; }      
        public string NazwaObreb { get; set; }

        public int GminaId { get; set; }
        public virtual Gmina Gmina { get; set; }

        
        public virtual ObservableCollection<Praca> Praca { get; set; }
    }
    
}
