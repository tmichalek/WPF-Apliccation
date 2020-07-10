using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Gmina
    {
        public Gmina ()
        {
          this.Obreb  = new ObservableCollection<Obreb>();
          this.Praca = new ObservableCollection<Praca>();
        }

        public int GminaId { get; set; }
        public string Nr_teryt { get; set; }
        public string NazwaGmina { get; set; }

        //public int ObrebId { get; set; }
        public virtual ObservableCollection<Obreb> Obreb { get; set; }
        public virtual ObservableCollection<Praca> Praca { get; set; }
    }
}
