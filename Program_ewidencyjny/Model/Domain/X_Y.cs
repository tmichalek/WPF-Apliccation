using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Spatial;

namespace program_ewidencyjny.Model.Domain
{
    class X_Y
    {
        public int X_YId { get; set; }
        public DbGeometry X { get; set; }
        public DbGeometry Y { get; set; }
        
        public int PolozenieId { get; set; }
        public virtual Polozenie Polozenie { get; set; }
        
    }
    
}
