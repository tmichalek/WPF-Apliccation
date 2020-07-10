using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Uzytkownik
    {
        public Uzytkownik()
        {
            this.Praca = new ObservableCollection<Praca>();
        }

        public int UzytkownikId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }



        public virtual ObservableCollection<Praca> Praca { get; set; }

    }
}
