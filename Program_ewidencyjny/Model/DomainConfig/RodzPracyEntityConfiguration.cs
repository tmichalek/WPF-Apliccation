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
    class RodzPracyEntityConfiguration : EntityTypeConfiguration<RodzPracy>
    {
        public RodzPracyEntityConfiguration()
        {

            HasKey(k => k.RodzPracyId);
            Property(k => k.RodzPracyId).IsRequired()
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            ToTable("RodzPracy");
           
        }


    }
}
