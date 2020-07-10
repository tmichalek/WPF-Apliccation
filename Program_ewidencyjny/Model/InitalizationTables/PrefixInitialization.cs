using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Domain;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class PrefixInitialization
    {
        IList<Prefix> Prefix = new List<Prefix>();

        public IList<Prefix> PrefixInit()
        {
            Prefix.Add(new Prefix() { Prefiks = "6621", NazwaAtrubutu = "Informacje, wypisy oraz wyrysy z operatu ewidencyjnego" });
            Prefix.Add(new Prefix() { Prefiks = "6640", NazwaAtrubutu = "Obsługa państwowego zasobu geodezyjnego i kartograficznego" });
            Prefix.Add(new Prefix() { Prefiks = "6642", NazwaAtrubutu = "Udostępnianie państwowego zasobu geodezyjnego i kartograficznego" });

            return Prefix;
        }



    }
}
