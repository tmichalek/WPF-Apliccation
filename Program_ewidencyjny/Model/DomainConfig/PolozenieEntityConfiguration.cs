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
    class PolozenieEntityConfiguration : EntityTypeConfiguration<Polozenie>
    {
        public PolozenieEntityConfiguration()
        {
            HasKey(k => k.PolozenieId);
            Property(p => p.PolozenieId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Polozenie");

            //HasMany(x => x.X_Y)
            //    .WithRequired(p => p.Polozenie)
            //    .HasForeignKey(x => x.X_YId);
            HasRequired(p => p.Praca)
                .WithMany(p => p.Polozenie)
                .HasForeignKey(p => p.PracaId);
        }
    }
}
