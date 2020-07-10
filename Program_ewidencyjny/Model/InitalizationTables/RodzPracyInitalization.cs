
using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Domain;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class RodzPracyInitalization
    {

        IList<RodzPracy> RodzPracy = new List<RodzPracy>();

        public IList<RodzPracy> RodzPracyInit()
        {
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.Inne });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiaryOsnowGeod });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiaryOsnowGraw });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiaryOsnowMagn });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiarySyt });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiarySytWys });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.pomiaryWys });
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.skaningLaserowy});
            RodzPracy.Add(new RodzPracy() { RodzajPracy = Enum.RodzajPracy.zobrazowaniaLotnicze });
            return RodzPracy;
        }
    }
}
