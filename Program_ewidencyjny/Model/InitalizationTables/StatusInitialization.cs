using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program_ewidencyjny.Model.InitalizationTables
{
    class StatusInitialization
    {

        IList<Status> Status = new List<Status>();

        public IList<Status> StatusInit()
        {
            Status.Add(new Status() { NazwaStatus = "Zgłoszenie zarejestrowano" });
            Status.Add(new Status() { NazwaStatus = "Materiały gotowe do wydania" });
            Status.Add(new Status() { NazwaStatus = "Operat wpłynął" });
            Status.Add(new Status() { NazwaStatus = "Operat po kontroli-pozytywna" });
            Status.Add(new Status() { NazwaStatus = "Operat po kontroli-do poprawy" });
            Status.Add(new Status() { NazwaStatus = "Poprawiony operat wpłynął" });
            Status.Add(new Status() { NazwaStatus = "Przyjęcie operatu" });
            Status.Add(new Status() { NazwaStatus = "Zarejestrowano wpłatę" });
            Status.Add(new Status() { NazwaStatus = "Wydanie materiałów" });
            Status.Add(new Status() { NazwaStatus = "Aktualizacja mapy zasadniczej" });
            Status.Add(new Status() { NazwaStatus = "Aktualizacja mapy zasadniczej II etap" });
            Status.Add(new Status() { NazwaStatus = "Aktualizacja mapy zasadniczej kolejny etap" });
            Status.Add(new Status() { NazwaStatus = "Przekazanie dokumentacji do ewidencji gruntów" });
            Status.Add(new Status() { NazwaStatus = "Przekazanie dokumentacji do ewidencji gruntów II etap" });
            Status.Add(new Status() { NazwaStatus = "Operat wpłynął" });
            Status.Add(new Status() { NazwaStatus = "Operat wpłynął II etap" });
            Status.Add(new Status() { NazwaStatus = "Operat wpłynął kolejny etap" });
            Status.Add(new Status() { NazwaStatus = "Operat po kontroli II etap" });
            Status.Add(new Status() { NazwaStatus = "Operat po kontroli kolejny etap" });
            Status.Add(new Status() { NazwaStatus = "Anulowanie zgłoszenia" });
            return Status;

        }

    }
}
