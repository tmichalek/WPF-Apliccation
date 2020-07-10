using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.InitalizationTables;
using program_ewidencyjny.Model.Domain;


namespace program_ewidencyjny.Model.InitalizationTables
{
    class PracaInzynierskaDBConextInitalization : CreateDatabaseIfNotExists<PracaIzynierskaDBContext>

    {
       
        protected override void Seed(PracaIzynierskaDBContext context)
        {

            CennikInitalization Cennik2019 = new CennikInitalization();
            IList<Cennik> Cennik = Cennik2019.CennikInit();

            AjInitalization aj2019 = new AjInitalization();
            IList<AjWspol> AjWspol = aj2019.AjInit();

            PdInitialization Pd2019 = new PdInitialization();
            IList<PdWspol> PdWspol = Pd2019.PdInit();

            TInitialization T2019 = new TInitialization();
            IList<TWspol> TWspol = T2019.TInit();

            KInitalization k2019 = new KInitalization();
            IList<KWspol> KWspol = k2019.KInit();

            AsortzmentInitialization asort2019 = new AsortzmentInitialization();
            IList<Asortyment> Asortyment = asort2019.AsortymentInit();

            ClInitalization cl2019 = new ClInitalization();
            IList<ClWspol> ClWspol = cl2019.ClInit();

            PrefixInitialization Prefix2019 = new PrefixInitialization();
            IList<Prefix> Prefix = Prefix2019.PrefixInit();

            RodzPracyInitalization RodzPracy2019 = new RodzPracyInitalization();
            IList<RodzPracy> RodzPracy = RodzPracy2019.RodzPracyInit();

            StatusInitialization Status2019 = new StatusInitialization();
            IList<Status> Status = Status2019.StatusInit();

            SuInitialization Su2019 = new SuInitialization();
            IList<SuWspol> SuWspol = Su2019.SuWspolInit();

            GminaInitalization Gmina2019 = new GminaInitalization();
            IList<Gmina> Gmina = Gmina2019.GminaInit();

            ObrebInitialization Obreb2019 = new ObrebInitialization();
            IList<Obreb> Obreb = Obreb2019.ObrebInit();

            WysylkaInitialization Wysylka2019 = new WysylkaInitialization();
            IList<Wysylka> Wysylka = Wysylka2019.WysylkaInit();

            UzytkownikInitalization DefaultUser = new UzytkownikInitalization();
            IList<Uzytkownik> Uzytkownik = DefaultUser.InitUzytkownik();
           


            context.Cennik.AddRange(Cennik);
            context.AjWspol.AddRange(AjWspol);
            context.PdWspol.AddRange(PdWspol);
            context.TWspol.AddRange(TWspol);
            context.Kwspol.AddRange(KWspol);
            context.Asortyments.AddRange(Asortyment);
            context.ClWspol.AddRange(ClWspol);
            context.Prefix.AddRange(Prefix);
            context.RodzPracy.AddRange(RodzPracy);
            context.Status.AddRange(Status);
            context.SuWspol.AddRange(SuWspol);
            context.Gmina.AddRange(Gmina);
            context.Obreb.AddRange(Obreb);
            context.Wysylka.AddRange(Wysylka);
            context.Uzytkownik.AddRange(Uzytkownik);

            base.Seed(context);

        }

       

    }
}
