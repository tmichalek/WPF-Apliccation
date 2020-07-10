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
    class KWspolEntityConfiguration : EntityTypeConfiguration<KWspol>
    {
        public KWspolEntityConfiguration()
        {
            HasKey(k => k.KId);
            Property(p => p.KId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("KWspol");
        }
    }
}
