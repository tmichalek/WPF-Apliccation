using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Wysylka
    {
        public int WysylkaId { get; set; }
        public double Cena { get; set; }
        public string Opis { get; set; }


        public virtual ObservableCollection<Kosztorys> Kosztorys { get; set; }



    }
}
