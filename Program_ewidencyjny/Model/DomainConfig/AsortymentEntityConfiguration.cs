using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace program_ewidencyjny.Model.DomainConfig
{
    class AsortymentEntityConfiguration: EntityTypeConfiguration<Asortyment>
    {
        public AsortymentEntityConfiguration()
        {
            HasKey(k => k.AsortymentId);
            Property(p => p.AsortymentId).IsRequired()
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Asortyment");
        }

        
    }
}
