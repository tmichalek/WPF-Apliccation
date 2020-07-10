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
    class X_YEntityConfiguration : EntityTypeConfiguration<X_Y>
    {
        public X_YEntityConfiguration()
        {
            HasKey(k => k.X_YId);
            Property(p => p.X_YId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("X_Y");
                
            HasRequired(p => p.Polozenie)
                .WithMany(x => x.X_Y)
                .HasForeignKey(p => p.PolozenieId);
        }
    }
}
