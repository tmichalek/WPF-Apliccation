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
    class UzytkownikEntityConfiguration : EntityTypeConfiguration<Uzytkownik>
    {
        public UzytkownikEntityConfiguration()
        {
            HasKey(k => k.UzytkownikId);
            Property(p => p.UzytkownikId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Uzytkownik");
            Property(p => p.Login).IsRequired();
            Property(p => p.Haslo).IsRequired();
        }
    }
}
