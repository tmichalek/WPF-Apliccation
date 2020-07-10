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
    class GminaEntityConfiguration : EntityTypeConfiguration<Gmina>
    {
        public GminaEntityConfiguration()
        {
            HasKey(k => k.GminaId);
            Property(p => p.GminaId)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Gmina");

            Property(p => p.Nr_teryt)
                .HasMaxLength(12);

            HasMany(o => o.Obreb)
                .WithRequired(g => g.Gmina)
                .HasForeignKey(g => g.GminaId);
            
        }
    }
}
