using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Operat
    {
        public int OperatId { get; set; }
        public OznCzesciZasobu OznCzesciZasobu  { get; set; }
        public Int16 Oznaczenie2 { get; set; }
        public int Rok { get; set; }
        public int Numer { get; set;}
        public NazwaMat NazwaMat { get; set; }
        public RodzajNosnikaNielektroniczny RodzajNosnikaNielektroniczny { get; set; }
        public string Jezyk { get; set;}
        public Postac Postac { get; set; }
        public TypMaterialu TypMaterialu { get; set; }
        public KatArchiw KatArchiw { get; set; }
        public DateTime DataArch { get; set; }
        
        public SposobPozyskania? SposobPozyskania { get; set; }
        public InfoODostepie InfoODostepie { get; set; }

        public int PracaId { get; set; }
        public Praca Praca { get; set; }

        
        public ObservableCollection<Dokument> Dokument { get; set; }

    }
}

    