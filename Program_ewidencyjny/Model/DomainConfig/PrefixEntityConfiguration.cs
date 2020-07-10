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
    class PrefixEntityConfiguration : EntityTypeConfiguration<Prefix>
    {
        public PrefixEntityConfiguration()
        {
            HasKey(k => k.PrefiksId);
            Property(p => p.PrefiksId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Prefiks");
        }
    }
}
