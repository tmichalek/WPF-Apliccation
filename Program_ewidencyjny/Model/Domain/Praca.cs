using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Praca
    {
        public Praca()
        {
            this.Gmina = new ObservableCollection<Gmina>();
            this.Obreb = new ObservableCollection<Obreb>();
            this.Kosztorys = new ObservableCollection<Kosztorys>();
            this.Asortyment = new ObservableCollection<Asortyment>();
            this.Status = new ObservableCollection<Status>();
            this.Polozenie = new ObservableCollection<Polozenie>();
        }

        

        public int PracaId { get; set; }
        public Int16 Numer { get; set; }
        public Int16 Rok { get; set; }
        public DateTime DataZgloszenia { get; set; }
        public DateTime DataZakonczeniaPrac { get; set; }
        public string PolozenieOpis { get; set; }
        public string NumerDzialki { get; set; }
        public CharakterOb CharakterOb { get; set; }
        public bool Aktualne { get; set; }

        public int PrefiksId { get; set; }
        public Prefix Prefix { get; set; }

        public int GminaId { get; set; }
        public virtual ObservableCollection<Gmina> Gmina { get; set; }

        public int ObrebId { get; set; }
        public virtual ObservableCollection<Obreb> Obreb { get; set; }

        
        public virtual ObservableCollection<Kosztorys> Kosztorys { get; set; }



        public int UzytkownikId { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }

        public int WykonawcaId { get; set; }
        public virtual Wykonawca Wykonawca { get; set; }


        public int RodzpracyId { get; set; }
        public virtual RodzPracy RodzPracy { get; set; }

        public int AsortymentId { get; set; }
        public virtual ObservableCollection<Asortyment> Asortyment { get; set; }

        public int StatusId { get; set; }
        public virtual ObservableCollection<Status> Status { get; set; }

        public int PolozenieId { get; set; }
        public virtual ObservableCollection<Polozenie> Polozenie { get; set; }

        
    }
}
