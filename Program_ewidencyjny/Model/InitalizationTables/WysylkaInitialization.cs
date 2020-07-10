using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class WysylkaInitialization
    {
        IList<Wysylka> Wysylka = new List<Wysylka>();

        public IList<Wysylka> WysylkaInit()
        {
            Wysylka.Add(new Wysylka() { Cena = 0, Opis =  "brak wysylki" });
            Wysylka.Add(new Wysylka() { Cena = 10, Opis = "jeżeli waga przesyłki jest mniejsza od 1 kg" });
            Wysylka.Add(new Wysylka() { Cena = 15, Opis = "jeżeli waga przesyłki wynosi od 1 kg do 5 kg" });
            Wysylka.Add(new Wysylka() { Cena = 20, Opis = "jeżeli waga przesyłki jest większa niż 5 kg" });

            return Wysylka;
        }


    }
}
