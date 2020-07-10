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
    class SuWspolEntityConfiguration : EntityTypeConfiguration<SuWspol>
    {
        public SuWspolEntityConfiguration()
        {
            HasKey(k => k.SuId);
            Property(p => p.SuId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("SuWspol");
        }
    }
}
