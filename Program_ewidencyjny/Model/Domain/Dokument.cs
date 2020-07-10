using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Dokument
    {
        public int DokumentId { get; set; }
        public NazwaDok NazwaDok { get; set; }
        public string NumerDokumentu { get; set; }

        public int OperatId { get; set; }
        public virtual Operat Operat { get; set; }


    }
}
