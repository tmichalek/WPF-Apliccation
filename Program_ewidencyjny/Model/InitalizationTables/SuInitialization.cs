using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class SuInitialization
    {
        IList<SuWspol> SuWspol = new List<SuWspol>();

        public IList<SuWspol> SuWspolInit()
        {
            SuWspol.Add(new SuWspol() { Su = 1, Opis= "w przypadku udostępniania materiału zasobu na zewnętrznym nośniku danych elektronicznych lub w postaci plików danych przekazywanych drogą elektroniczną albo w postaci drukowanej" });
            SuWspol.Add(new SuWspol() { Su = 0.8, Opis = "w przypadku udostępniania materiałów zasobu w postaci elektronicznej za pomocą usług sieciowych" });

            return SuWspol;
        }



    }
}
