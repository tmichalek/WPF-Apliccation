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
    class PdWspolEntityConfiguration : EntityTypeConfiguration<PdWspol>
    {
        public PdWspolEntityConfiguration()
        {
            HasKey(k => k.PdId);
            Property(p => p.PdId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("PdWspol");
        }
    }
}
