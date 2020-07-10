using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Kosztorys
    {
        public Kosztorys()
        {
            this.KWspol = new ObservableCollection<KWspol>();
            this.ClWspol = new ObservableCollection<ClWspol>();
            this.SuWspol = new ObservableCollection<SuWspol>();
            this.PdWspol = new ObservableCollection<PdWspol>();
            this.AjWspol = new ObservableCollection<AjWspol>();
            this.TWspol = new ObservableCollection<TWspol>();
            this.Cennik = new ObservableCollection<Cennik>();
        }


        public int KosztorysId { get; set; }
        //public int CennikId { get; set; }
        public Int16 NrCennika { get; set; }
        public double Pozycja { get; set; }
        public string Nazwa { get; set; }
        public Int16 Ilosc { get; set; }
        public double Cena { get; set; }
        

        public double Wspolczynnik { get; set; }
        public double Vat { get; set; }
        public double Brutto { get; set; }

        public int KId { get; set; }
        public virtual ObservableCollection<KWspol> KWspol{get; set;}

        public int ClId { get; set; }
        public virtual ObservableCollection<ClWspol> ClWspol { get; set; }

        public int SuId { get; set; }
        public virtual ObservableCollection<SuWspol> SuWspol { get; set; }

        public int PdId { get; set; }
        public virtual ObservableCollection<PdWspol> PdWspol { get; set; }

        public int AjId { get; set; }
        public virtual ObservableCollection<AjWspol> AjWspol { get; set; }

        public int TId { get; set; }
        public virtual ObservableCollection<TWspol> TWspol { get; set; }

        public int CennikId { get; set; }
        public virtual ObservableCollection<Cennik> Cennik { get; set; }

        public int PracaId { get; set; }
        public virtual Praca Praca { get; set; }

        public int WysylkaId { get; set; }
        public virtual Wysylka Wysylka { get; set; }
        public int Numer { get; set; }
        public int Rok { get; set; }
    }
}
