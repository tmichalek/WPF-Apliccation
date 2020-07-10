using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Enum;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class AsortzmentInitialization
    {
        IList<Asortyment> Asortyment = new List<Asortyment>();

        public IList<Asortyment> AsortymentInit()
        {
            Asortyment.Add(new Asortyment() { CelPracy= CelPracy.aktualizacjaBDOT10k });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaBDOT500 });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaBDSOG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaEGiB });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaGESUT });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaKGESUT });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaPRG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaPRNG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaPRPOG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizacjaZBDOT10k });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.aktualizcjaBDOO });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.geodInwPowykObBud });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.innaMapaDoCelowPr });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.innyCel });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.mapaDoCelowProj });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.mapaZProjPodzialu });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.mapaZProjPodzialuRL });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.mapaZProjScalenia });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.modernizacjaEGiB });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.projScaleniaGruntow });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.projWymianyGruntow });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.rozgrNieruchomosci });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.tyczenieObBud });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDNMT });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDOO });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDOrto });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDOT10k });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDOT500 });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieBDSOG});
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieGESUT });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzeniePRG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzeniePRNG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzeniePRPOG });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieZBDOT10k });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.wznZnakowGrWyznPGr});
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.zalozenieEGiB });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.utworzenieKGESUT });
            Asortyment.Add(new Asortyment() { CelPracy = CelPracy.wszystkie });

            return Asortyment;
        }


    }
}
