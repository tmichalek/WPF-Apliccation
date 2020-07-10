using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class TInitialization
    {
        IList<TWspol> TWspol = new List<TWspol>();

        public IList<TWspol>TInit()
        {
            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 17.1, Opis = "1,0 - jeżeli usługa swiadczona jest przez okres 1 roku" });		

            TWspol.Add(new TWspol() { T = 0.54, NrTabeli = 17.1, Opis = "0,54 - jeżeli usługa swiadczona jest przez okres 6 miesięcy" });

            TWspol.Add(new TWspol() { T = 0.12, NrTabeli = 17.1, Opis = "0,12 -  jeżeli usługa swiadczona jest przez okres 1 miesiąca" });

            TWspol.Add(new TWspol() { T = 0.036, NrTabeli = 17.1, Opis = "0,036 - jeżeli usługa swiadczona jest przez okres 1 tygodnia" });		

            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 17.2, Opis = "1,0 - jeżeli usługa swiadczona jest przez okres 1 roku" });		

            TWspol.Add(new TWspol() { T = 0.54, NrTabeli = 17.2, Opis = "0,54 - jeżeli usługa swiadczona jest przez okres 6 miesięcy" });

            TWspol.Add(new TWspol() { T = 0.12, NrTabeli = 17.2, Opis = "0,12 -  jeżeli usługa swiadczona jest przez okres 1 miesiąca" });

            TWspol.Add(new TWspol() { T = 0.036, NrTabeli = 17.2, Opis = "0,036 - jeżeli usługa swiadczona jest przez okres 1 tygodnia" });			

            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 17.3, Opis = "1,0 - jeżeli usługa swiadczona jest przez okres 1 roku" });		

            TWspol.Add(new TWspol() { T = 0.54, NrTabeli = 17.3, Opis = "0,54 - jeżeli usługa swiadczona jest przez okres 6 miesięcy" });

            TWspol.Add(new TWspol() { T = 0.12, NrTabeli = 17.3, Opis = "0,12 -  jeżeli usługa swiadczona jest przez okres 1 miesiąca" });

            TWspol.Add(new TWspol() { T = 0.036, NrTabeli = 17.3, Opis = "0,036 - jeżeli usługa swiadczona jest przez okres 1 tygodnia" });			

            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 17.4, Opis = "1,0 - jeżeli usługa swiadczona jest przez okres 1 roku,  a łączny limit pobranych obserwacji nie przekracza 3000 godzin" });		

            TWspol.Add(new TWspol() { T = 0.54, NrTabeli = 17.4, Opis = "0,54 - jeżeli usługa swiadczona jest przez 6 miesięcy, a łączny limit pobranych obserwacji nie przekracza 1500 godzin" });

            TWspol.Add(new TWspol() { T = 0.12, NrTabeli = 17.4, Opis = "0,12 - jeżeli usługa swiadczona jest przez okres 1 miesišca, a łączny limit pobranych obserwacji nie przekracza 250 godz" });

            TWspol.Add(new TWspol() { T = 0.036, NrTabeli = 17.4, Opis = "0,036 - jeżeli usługa swiadczona jest przez okres 1 tygodnia, a łączny limit pobranych obserwacji nie przekracza 70 godzin" });			

            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 17.5, Opis = "1,0 - jeżeli usługa swiadczona jest przez okres 1 roku,  a łączny limit pobranych obserwacji nie przekracza 3000 godzin" });		

            TWspol.Add(new TWspol() { T = 0.54, NrTabeli = 17.5, Opis = "0,54 - jeżeli usługa swiadczona jest przez 6 miesięcy, a łączny limit pobranych obserwacji nie przekracza 1500 godzin" });

            TWspol.Add(new TWspol() { T = 0.12, NrTabeli = 17.5, Opis = "0,12 - jeżeli usługa swiadczona jest przez okres 1 miesišca, a łączny limit pobranych obserwacji nie przekracza 250 godz" });

            TWspol.Add(new TWspol() { T = 0.036, NrTabeli = 17.5, Opis = "0,036 - jeżeli usługa swiadczona jest przez okres 1 tygodnia, a łączny limit pobranych obserwacji nie przekracza 70 godzin" });			

            TWspol.Add(new TWspol() { T = 1.0, NrTabeli = 13.1, Opis = "1,0 - okres 1 roku" });

            TWspol.Add(new TWspol() { T = 0.6, NrTabeli = 13.1, Opis = "0,6 - okres 0,5 roku" });

            TWspol.Add(new TWspol() { T = 0.4, NrTabeli = 13.1, Opis = "0,4 - okres 3 miesięcy" });

                return TWspol;
        }

    }
}
