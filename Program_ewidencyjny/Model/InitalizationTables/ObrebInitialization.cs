using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class ObrebInitialization
    {
        IList<Obreb> Obreb = new List<Obreb>();

        public IList<Obreb> ObrebInit()
        {
            Obreb.Add(new Obreb() { NazwaObreb = "Miasto Sława", GminaId = 1, Nr_teryt="081201_4.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Bagno", GminaId = 2, Nr_teryt = "081201_5.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Ciosaniec", GminaId = 2, Nr_teryt = "081201_5.0002" });
            Obreb.Add(new Obreb() { NazwaObreb = "Droniki", GminaId = 2, Nr_teryt = "081201_5.0003" });
            Obreb.Add(new Obreb() { NazwaObreb = "Gola", GminaId = 2, Nr_teryt = "081201_5.0004" });
            Obreb.Add(new Obreb() { NazwaObreb = "Krążkowo", GminaId = 2, Nr_teryt = "081201_5.0005" });
            Obreb.Add(new Obreb() { NazwaObreb = "Krzepielów", GminaId = 2, Nr_teryt = "081201_5.0006" });
            Obreb.Add(new Obreb() { NazwaObreb = "Kuźnica Głogowska", GminaId = 2, Nr_teryt = "081201_5.0007" });
            Obreb.Add(new Obreb() { NazwaObreb = "Lipinki", GminaId = 2, Nr_teryt = "081201_5.0008" });
            Obreb.Add(new Obreb() { NazwaObreb = "Lubiatów", GminaId = 2, Nr_teryt = "081201_5.0009" });
            Obreb.Add(new Obreb() { NazwaObreb = "Lubogoszcz", GminaId = 2, Nr_teryt = "081201_5.0010" });
            Obreb.Add(new Obreb() { NazwaObreb = "Łupice", GminaId = 2, Nr_teryt = "081201_5.0011" });
            Obreb.Add(new Obreb() { NazwaObreb = "Nowe Strącze", GminaId = 2, Nr_teryt = "081201_5.0012" });
            Obreb.Add(new Obreb() { NazwaObreb = "Przybyszów", GminaId = 2, Nr_teryt = "081201_5.0013" });
            Obreb.Add(new Obreb() { NazwaObreb = "Radzyń", GminaId = 2, Nr_teryt = "081201_5.0014" });          
            Obreb.Add(new Obreb() { NazwaObreb = "Stare Strącze", GminaId = 2, Nr_teryt = "081201_5.0015" });
            Obreb.Add(new Obreb() { NazwaObreb = "Spokojna", GminaId = 2, Nr_teryt = "081201_5.0016" });
            Obreb.Add(new Obreb() { NazwaObreb = "Szreniawa", GminaId = 2, Nr_teryt = "081201_5.0017" });
            Obreb.Add(new Obreb() { NazwaObreb = "Śmieszkowo", GminaId = 2, Nr_teryt = "081201_5.0018" });
            Obreb.Add(new Obreb() { NazwaObreb = "Tarnów Jezierny", GminaId = 2, Nr_teryt = "081201_5.0019" });
            Obreb.Add(new Obreb() { NazwaObreb = "Wróblów", GminaId = 2, Nr_teryt = "081201_5.0020" });

            Obreb.Add(new Obreb() { NazwaObreb = "Szlichtyngowa Miasto", GminaId = 3, Nr_teryt = "081202_4.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Dryżyna", GminaId = 4, Nr_teryt = "081202_5.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Gola", GminaId = 4, Nr_teryt = "081202_5.0002" });
            Obreb.Add(new Obreb() { NazwaObreb = "Górczyna", GminaId = 4, Nr_teryt = "081202_5.0003" });
            Obreb.Add(new Obreb() { NazwaObreb = "Jędrzychowice", GminaId = 4, Nr_teryt = "081202_5.0004" });
            Obreb.Add(new Obreb() { NazwaObreb = "Kowalewo", GminaId = 4, Nr_teryt = "081202_5.0005" });
            Obreb.Add(new Obreb() { NazwaObreb = "Nowe Drzewce", GminaId = 4, Nr_teryt = "081202_5.0006" });
            Obreb.Add(new Obreb() { NazwaObreb = "Stare Drzewce", GminaId = 4, Nr_teryt = "081202_5.0007" });
            Obreb.Add(new Obreb() { NazwaObreb = "Zamysłów", GminaId = 4, Nr_teryt = "081202_5.0008" });
            Obreb.Add(new Obreb() { NazwaObreb = "Wyszanów", GminaId = 4, Nr_teryt = "081202_5.0009" });

            Obreb.Add(new Obreb() { NazwaObreb = "Wschowa Miasto", GminaId = 5, Nr_teryt = "081203_4.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Dębowa Łęka", GminaId = 6, Nr_teryt = "081203_5.0001" });
            Obreb.Add(new Obreb() { NazwaObreb = "Hetmanice", GminaId = 6, Nr_teryt = "081203_5.0002" });
            Obreb.Add(new Obreb() { NazwaObreb = "Kandlewo", GminaId = 6, Nr_teryt = "081203_5.0003" });
            Obreb.Add(new Obreb() { NazwaObreb = "Konradowo", GminaId = 6, Nr_teryt = "081203_5.0004" });
            Obreb.Add(new Obreb() { NazwaObreb = "Lgiń", GminaId = 6, Nr_teryt = "081203_5.0005" });
            Obreb.Add(new Obreb() { NazwaObreb = "Łęgoń", GminaId = 6, Nr_teryt = "081203_5.0006" });
            Obreb.Add(new Obreb() { NazwaObreb = "Łysiny", GminaId = 6, Nr_teryt = "081203_5.0007" });
            Obreb.Add(new Obreb() { NazwaObreb = "Nowa Wieś", GminaId = 6, Nr_teryt = "081203_5.0008" });
            Obreb.Add(new Obreb() { NazwaObreb = "Olbrachcice", GminaId = 6, Nr_teryt = "081203_5.0009" });
            Obreb.Add(new Obreb() { NazwaObreb = "Osowa Sień", GminaId = 6, Nr_teryt = "081203_5.0010" });
            Obreb.Add(new Obreb() { NazwaObreb = "Przyczyna Dolna", GminaId = 6, Nr_teryt = "081203_5.0011" });
            Obreb.Add(new Obreb() { NazwaObreb = "Przyczyna Górna", GminaId = 6, Nr_teryt = "081203_5.00012" });
            Obreb.Add(new Obreb() { NazwaObreb = "Siedlnica", GminaId = 6, Nr_teryt = "081203_5.0013" });
            Obreb.Add(new Obreb() { NazwaObreb = "Tylewice", GminaId = 6, Nr_teryt = "081203_5.0014" });
            Obreb.Add(new Obreb() { NazwaObreb = "Wygnańczyce", GminaId = 6, Nr_teryt = "081203_5.0015" });

            return Obreb;

        }

    }
}
