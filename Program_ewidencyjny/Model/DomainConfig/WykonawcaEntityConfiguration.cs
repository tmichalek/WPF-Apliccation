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
    class WykonawcaEntityConfiguration : EntityTypeConfiguration<Wykonawca>
    {
        public WykonawcaEntityConfiguration()
        {
            HasKey(k => k.WykonawcaId);
            Property(p => p.WykonawcaId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Wykonawca");
        }
    }
}
