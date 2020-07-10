using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace program_ewidencyjny.Model.Domain
{
    class Cennik

    {
        public Cennik()
        {
            this.Kosztorys = new ObservableCollection<Kosztorys>();
        }

        public int CennikId { get; set; }
        public Int16 NrCennika { get; set; }
        public double Pozycja { get; set;}
        public string Nazwa { get; set; }
        public string SkNazwa { get; set; }
        public string Jednostka { get; set; }
        public double Cena { get; set; }
        public double Wspolczynnik { get; set; }

        public virtual ObservableCollection<Kosztorys> Kosztorys { get; set; }



    }
}
