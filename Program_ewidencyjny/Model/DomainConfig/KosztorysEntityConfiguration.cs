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
    class KosztorysEntityConfiguration : EntityTypeConfiguration<Kosztorys>
    {
        public KosztorysEntityConfiguration ()
        {
            HasKey(k => k.KosztorysId);
            Property(p => p.KosztorysId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Kosztorys");

            HasRequired(p => p.Praca)
                .WithMany(k => k.Kosztorys)
                .HasForeignKey(p => p.PracaId);

             HasMany(c => c.Cennik)
            .WithMany(k => k.Kosztorys)
            .Map(m => m.MapLeftKey("KosztorysId")
            .MapRightKey("CennikId"));


            HasMany(k => k.KWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("KId"));

            HasMany(c => c.ClWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("ClId"));

            HasMany(s => s.SuWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("SuId"));

            HasMany(p => p.PdWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("PdId"));

            HasMany(a => a.AjWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("AjId"));

            HasMany(t => t.TWspol)
           .WithMany(k => k.Kosztorys)
           .Map(m => m.MapLeftKey("KosztorysId")
           .MapRightKey("TId"));

            HasRequired(p => p.Wysylka)
               .WithMany(k => k.Kosztorys)
              
               .HasForeignKey(k => k.WysylkaId);
               

        }
    }
}
