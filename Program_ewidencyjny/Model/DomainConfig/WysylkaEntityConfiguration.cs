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
    class WysylkaEntityConfiguration :EntityTypeConfiguration<Wysylka>
    {
        public WysylkaEntityConfiguration()
        {
            HasKey(k => k.WysylkaId);
            Property(k => k.WysylkaId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Wysylka");

            //HasOptional(k => k.Kosztorys)
            //    .WithRequired();

           
               
                
            
                

                
            
            //        .WithOptionalDependent(p => p.Wysylka);
                

        }


    }
}
