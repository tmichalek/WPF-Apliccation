using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class KInitalization
    {
        IList<KWspol> KWspol = new List<KWspol>();

        public IList<KWspol>KInit()
        {

            KWspol.Add(new KWspol() { K = 1, Opis = "" });
            KWspol.Add(new KWspol() { K = 0.5, Opis = "materiały zasobu wykonawcom prac geodezyjnych lub kartograficznych podlegających obowiązkowi zgłoszenia" });
            KWspol.Add(new KWspol() { K = 0.5, Opis = "danych rejestru cen i wartości nieruchomości rzeczoznawcom majątkowym w celu wykonania przez nich wyceny nieruchomości" });
            KWspol.Add(new KWspol() { K = 0.5, Opis = "materiałów zasobu w postaci nieelektronicznej na cele i podmiotom, o których mowa w art. 40a ust. 2 pkt 2" });
            KWspol.Add(new KWspol() { K = 0.8, Opis = " w przypadku udostępniania materiałów zasobu w celu przeprowadzenia szkolenia, w rozumieniu art. 2 pkt 37 ustawy z dnia 20 kwietnia 2004 r. o promocji zatrudnienia i instytucjach rynku pracy (Dz. U. z 2017 r. poz. 1065, 1292, 1321, 1428 i 1543)" });
            KWspol.Add(new KWspol() { K = 0.1, Opis = "w przypadku każdego kolejnego udostępnienia zbiorów danych dotyczących sieci uzbrojenia terenu, o którym mowa w art. 40a ust. 2 pkt 5" });
            return KWspol;
        }

    }
}
