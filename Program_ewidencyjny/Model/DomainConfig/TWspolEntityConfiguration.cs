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
    class TWspolEntityConfiguration : EntityTypeConfiguration<TWspol>
    {
        public TWspolEntityConfiguration()
        {
            HasKey(k => k.TId);
            Property(p => p.TId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("TWspol");
        }
    }
}
