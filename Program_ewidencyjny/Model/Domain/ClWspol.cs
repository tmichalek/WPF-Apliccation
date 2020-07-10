using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class ClWspol
    {
        public int ClId { get; set; }
        public double Cl { get; set; }
        public string Zakres1 { get; set; }
        public string Zakres2 { get; set; }
        public string Opis { get; set; }

        public virtual ObservableCollection<Kosztorys> Kosztorys { get; set; }
    }
}
