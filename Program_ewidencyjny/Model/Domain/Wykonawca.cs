using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Wykonawca
    {
        public int WykonawcaId { get; set; }
        public string NazwaFirmy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string AdresMiejscowosc { get; set; }
        public int AdresKod { get; set; }
        public string AdresUlica { get; set; }
        public Int16 NumerBudynku { get; set; }
        public Int16? NumerLokalu { get; set; }
        public int Nip { get; set; }
        public int Regon { get; set; }
        public int NrTelefonu { get; set; }
        public string AdresEmail { get; set; }
        public Int16 NrUprawnien { get; set; }
        public string ZakresUprawnien { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public virtual ObservableCollection<Praca> Praca { get; set; }


    }
}
