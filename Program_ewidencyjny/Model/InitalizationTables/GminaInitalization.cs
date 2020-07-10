using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class GminaInitalization
    {
        IList<Gmina> Gmina = new List<Gmina>();

        public IList<Gmina> GminaInit()
        {
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Sława Miasto", Nr_teryt = "081201_4" });
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Sława Gmina", Nr_teryt = "081201_5" });
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Szlichtyngowa Miasto", Nr_teryt = "081202_4" });
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Szlichtyngowa Gmina", Nr_teryt = "081202_5" });
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Wschowa Miasto", Nr_teryt = "081203_4" });
            Gmina.Add(new Domain.Gmina() { NazwaGmina = "Wschowa Gmina", Nr_teryt = "081203_5" });

            return Gmina;
        }


    }
}
