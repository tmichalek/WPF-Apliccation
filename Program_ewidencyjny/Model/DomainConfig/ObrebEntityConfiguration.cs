using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.DomainConfig
{
    class ObrebEntityConfiguration : EntityTypeConfiguration<Obreb>
    {
        public ObrebEntityConfiguration()
        {
            HasKey(k => k.ObrebId);
            Property(p => p.ObrebId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Obreb");
        }
    }
}
