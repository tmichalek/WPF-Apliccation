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
    class StatusEntityConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusEntityConfiguration()
        {
            HasKey(k => k.StatusId);
            Property(p => p.StatusId).IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("Status");
        }
    }
}
