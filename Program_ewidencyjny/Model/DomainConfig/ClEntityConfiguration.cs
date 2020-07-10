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
    class ClEntityConfiguration : EntityTypeConfiguration<ClWspol>
    {
        public ClEntityConfiguration()
        {
            HasKey(k => k.ClId);
            Property(p => p.ClId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("ClWspol");
        }

    }
}
