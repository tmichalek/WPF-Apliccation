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
    class CennikEntityConfiguration: EntityTypeConfiguration<Cennik>
    {
        public CennikEntityConfiguration()
        {
            HasKey(k => k.CennikId);
            Property(p => p.CennikId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Cennik");
        }
    }
}
