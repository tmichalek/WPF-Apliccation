using program_ewidencyjny.Model.DomainConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.InitalizationTables;

namespace program_ewidencyjny.Model.Domain
{
     class PracaIzynierskaDBContext : DbContext
    {
        public PracaIzynierskaDBContext() : base("program_ewidencyjny")
        {
           Database.SetInitializer(new PracaInzynierskaDBConextInitalization());

        } 

        public virtual DbSet<AjWspol> AjWspol {get; set;}
        public virtual DbSet<Asortyment> Asortyments { get; set; }
        public virtual DbSet<Cennik> Cennik { get; set; }
        public virtual DbSet<ClWspol> ClWspol { get; set; }
        public virtual DbSet<Dokument> Dokuments { get; set; }
        public virtual DbSet<Gmina> Gmina { get; set; }
        public virtual DbSet<Kosztorys> Kosztorys { get; set; }
        public virtual DbSet<KWspol> Kwspol { get; set; }
        public virtual DbSet<Obreb> Obreb { get; set; }
        public virtual DbSet<Operat> Operat { get; set; }
        public virtual DbSet<PdWspol> PdWspol { get; set; }
        public virtual DbSet<Polozenie> Polozenie { get; set; }
        public virtual DbSet<Praca> Praca { get; set; }
        public virtual DbSet<Prefix> Prefix { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<SuWspol> SuWspol { get; set; }
        public virtual DbSet<TWspol> TWspol { get; set; }
        public virtual DbSet<Uzytkownik> Uzytkownik { get; set; }
        public virtual DbSet<Wykonawca> Wykonawca { get; set; }
        public virtual DbSet<X_Y> X_Y { get; set; }
        public virtual DbSet<RodzPracy> RodzPracy { get; set; }
        public virtual DbSet<Wysylka> Wysylka { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AjEntityConfiguration());
            modelBuilder.Configurations.Add(new AsortymentEntityConfiguration());
            modelBuilder.Configurations.Add(new CennikEntityConfiguration());
            modelBuilder.Configurations.Add(new ClEntityConfiguration());
            modelBuilder.Configurations.Add(new DokumentEntityConfiguration());
            modelBuilder.Configurations.Add(new GminaEntityConfiguration());
            modelBuilder.Configurations.Add(new KosztorysEntityConfiguration());
           
            modelBuilder.Configurations.Add(new KWspolEntityConfiguration());
            modelBuilder.Configurations.Add(new ObrebEntityConfiguration());
            modelBuilder.Configurations.Add(new OperatEntityConfiguration());
            modelBuilder.Configurations.Add(new PdWspolEntityConfiguration());
            modelBuilder.Configurations.Add(new PolozenieEntityConfiguration());
            modelBuilder.Configurations.Add(new PracaEntityConfiguration());
            modelBuilder.Configurations.Add(new PrefixEntityConfiguration());
            modelBuilder.Configurations.Add(new StatusEntityConfiguration());
            modelBuilder.Configurations.Add(new SuWspolEntityConfiguration());
            modelBuilder.Configurations.Add(new TWspolEntityConfiguration());
            modelBuilder.Configurations.Add(new UzytkownikEntityConfiguration());
            modelBuilder.Configurations.Add(new WykonawcaEntityConfiguration());
            modelBuilder.Configurations.Add(new X_YEntityConfiguration());
            modelBuilder.Configurations.Add(new RodzPracyEntityConfiguration());
            modelBuilder.Configurations.Add(new WysylkaEntityConfiguration());
            

        }


    }
}
