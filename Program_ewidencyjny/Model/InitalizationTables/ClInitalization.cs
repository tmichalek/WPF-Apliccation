using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class ClInitalization
    {
       
        
            IList<ClWspol> ClWspol = new List<ClWspol>();
             public IList<ClWspol> ClInit()
            {
                ClWspol.Add(new ClWspol() { Cl = 1.0, Zakres1 = "0", Zakres2 = "0", Opis = "Brak współczynnika" });
                ClWspol.Add(new ClWspol() { Cl = 1.1, Zakres1 = "10", Zakres2 = "500", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 1 000 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 1.2, Zakres1 = "100", Zakres2 = "2000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 1.3, Zakres1 = "500", Zakres2 = "5000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 1.4, Zakres1 = "1000", Zakres2 = "10000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 1.7, Zakres1 = "10000", Zakres2 = "50000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 2.0, Zakres1 = "60000", Zakres2 = "200000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 2.5, Zakres1 = "200000", Zakres2 = "500000", Opis = "Pojedyńczy obraz statyczny o rozmairze maksimum 2 100 000 pikseli" });
                ClWspol.Add(new ClWspol() { Cl = 3.0, Zakres1 = "Bez ograniczeń", Zakres2 = "Bez ograniczeń", Opis = "Bez ograniczeń" });

                return ClWspol;
            }

        

    }
}
