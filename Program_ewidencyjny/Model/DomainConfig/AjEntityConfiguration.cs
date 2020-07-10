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
    class AjEntityConfiguration :EntityTypeConfiguration<AjWspol>
    {
        public AjEntityConfiguration()
        {
            
            HasKey(p => p.AjId);
            Property(p => p.AjId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("AjWspol");
           
            

        }

    }
}
