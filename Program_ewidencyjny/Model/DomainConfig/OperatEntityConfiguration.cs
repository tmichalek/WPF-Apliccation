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
    class OperatEntityConfiguration : EntityTypeConfiguration<Operat>
    {
        public OperatEntityConfiguration()
        {
            HasKey(k => k.OperatId);
            Property(p => p.OperatId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Operat");
            Property(p => p.SposobPozyskania).IsOptional();
            //HasMany(d => d.Dokument)
            //    .WithRequired(o => o.Operat)
            //    .HasForeignKey(d => d.DokumentId);
        }
    }
}
