using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.Domain
{
    class Prefix
    {
        public int PrefiksId { get; set; }
        public string Prefiks { get; set; }
        public string NazwaAtrubutu { get; set; }

        public virtual ObservableCollection<Praca> Praca { get; set; }
    }
}
