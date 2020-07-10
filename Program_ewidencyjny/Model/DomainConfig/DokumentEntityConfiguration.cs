using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace program_ewidencyjny.Model.DomainConfig
{
    class DokumentEntityConfiguration :EntityTypeConfiguration<Dokument>
    { 
        public DokumentEntityConfiguration()
        {
            HasKey(k => k.DokumentId);
            Property(p => p.DokumentId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Dokument");

            HasRequired(o => o.Operat)
                .WithMany(d => d.Dokument)
                .HasForeignKey(o => o.OperatId);

        }

    }

    
}

