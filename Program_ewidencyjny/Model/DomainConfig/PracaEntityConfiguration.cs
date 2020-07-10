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
    class PracaEntityConfiguration : EntityTypeConfiguration<Praca>
    {
        public PracaEntityConfiguration()
        {
            HasKey(k => k.PracaId);
            Property(p => p.PracaId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Praca");

            HasMany(g => g.Gmina)
           .WithMany(p => p.Praca)
           .Map(m => m.MapLeftKey("PracaId")
           .MapRightKey("GminaId"));

            HasMany(g => g.Obreb)
           .WithMany(p => p.Praca)
           .Map(m => m.MapLeftKey("PracaId")
           .MapRightKey("ObrebId"));

            HasRequired(p => p.Prefix)
            .WithMany(p => p.Praca).HasForeignKey(p => p.PrefiksId);

           // HasMany(k => k.Kosztorys)
           //.WithRequired(p => p.Praca).HasForeignKey(k => k.KosztorysId);

            HasRequired(u => u.Uzytkownik)
            .WithMany(p => p.Praca).HasForeignKey(p => p.UzytkownikId);

          //  HasMany(p => p.Polozenie)
          //.WithRequired(p => p.Praca).HasForeignKey(p => p.PolozenieId);

            HasRequired(w => w.Wykonawca)
            .WithMany(p => p.Praca).HasForeignKey(w => w.WykonawcaId);


            HasMany(a => a.Asortyment)
           .WithMany(p => p.Praca)
           .Map(m => m.MapLeftKey("PracaId")
           .MapRightKey("AsortymentId"));

            HasMany(s => s.Status)
           .WithMany(p => p.Praca)
           .Map(m => m.MapLeftKey("PracaId")
           .MapRightKey("StatustId"));

            HasRequired(r => r.RodzPracy)
                .WithMany(p => p.Praca)
                .HasForeignKey(p => p.RodzpracyId);
        }
    }
}
