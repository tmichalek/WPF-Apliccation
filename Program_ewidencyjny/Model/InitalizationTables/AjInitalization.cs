using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Domain;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class AjInitalization
    {
        IList<AjWspol> AjWspol = new List<AjWspol>();

        public IList<AjWspol> AjInit()
        {
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 2.5, Opis = "dla ploterowego wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 2.5, Opis = "dla ploterowego wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 0.4, NrTabeli = 2.5, Opis = "dla druku poligraficznego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 2.6, Opis = "dla ploterowego wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 2.6, Opis = "dla ploterowego wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 0.4, NrTabeli = 2.6, Opis = "dla druku poligraficznego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 3.2, Opis = "1,0, jeżeli terenowa wielkoć piksela jest nie większa niż 1,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.9, NrTabeli = 3.2, Opis = "0,9, jeżeli terenowa wielkoć piksela jest większa niż 1,0 m, ale nie większa niż 5,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.8, NrTabeli = 3.2, Opis = "0,8, jeżeli terenowa wielkoć piksela jest większa niż 5,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 3.3, Opis = "1,0, jeżeli wartoć błędu redniego wysokoci nie jest większa niż 0,80 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.9, NrTabeli = 3.3, Opis = "0,9, jeżeli wartoć błędu redniego wysokoci jest większa niż 0,80 m, ale nie większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.8, NrTabeli = 3.3, Opis = "0,8, jeżeli wartoć błędu redniego wysokoci jest większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 3.4, Opis = "1,0, jeżeli wartoć błędu redniego wysokoci nie jest większa niż 0,80 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.9, NrTabeli = 3.4, Opis = "0,9, jeżeli wartoć błędu redniego wysokoci jest większa niż 0,80 m, ale nie większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.8, NrTabeli = 3.4, Opis = "0,8, jeżeli wartoć błędu redniego wysokoci jest większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 3.5, Opis = "1,0, jeżeli wartoć błędu redniego wysokoci nie jest większa niż 0,80 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.9, NrTabeli = 3.5, Opis = "0,9, jeżeli wartoć błędu redniego wysokoci jest większa niż 0,80 m, ale nie większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 0.8, NrTabeli = 3.5, Opis = "0,8, jeżeli wartoć błędu redniego wysokoci jest większa niż 2,0 m" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 4.6, Opis = "1,0 - jeżeli zbiór zawiera obserwacje zgromadzone przez okres powyżej 30 dób" });
            AjWspol.Add(new AjWspol() { Aj = 0.5, NrTabeli = 4.6, Opis = "0,5 - jeżeli zbiór zawiera obserwacje zgromadzone przez okres dłuższy niż 1 doba, a niedłuższy niż 30 dób" });
            AjWspol.Add(new AjWspol() { Aj = 0.3, NrTabeli = 4.6, Opis = "0,3 - jeżeli zbiór zawiera obserwacje zgromadzone przez okres nie dłuższy niż 1 doba" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.1, Opis = "1,0 - dla wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 10.1, Opis = "0,7 - dla wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.2, Opis = "1,0 - dla wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 10.2, Opis = "0,7 - dla wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.3, Opis = "1,0 - dla mapy w skali 1:500" });
            AjWspol.Add(new AjWspol() { Aj = 0.3, NrTabeli = 10.3, Opis = "0,3 - dla mapy w skali 1:1 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.1, NrTabeli = 10.3, Opis = "0,1 - dla mapy w skali 1:2 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.02, NrTabeli = 10.3, Opis = "0,02 - dla mapy w skali 1:5 000" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.4, Opis = "1,0 - dla mapy w skali 1:500" });
            AjWspol.Add(new AjWspol() { Aj = 0.3, NrTabeli = 10.4, Opis = "0,3 - dla mapy w skali 1:1 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.1, NrTabeli = 10.4, Opis = "0,1 - dla mapy w skali 1:2 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.02, NrTabeli = 10.4, Opis = "0,02 - dla mapy w skali 1:5 000" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.5, Opis = "1,0 - w przypadku udostępniania kopii rejestru o pełnej treci" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 10.5, Opis = "0,7 - w przypadku udostępniania kopii rejestru bez danych osobowych" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 10.6, Opis = "1,0 - w przypadku udostępniania kopii rejestru o pełnej treci" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 10.6, Opis = "0,7 - w przypadku udostępniania kopii rejestru bez danych osobowych" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 13.1, Opis = "1,0 - dla mapy zasadniczej w skalach 1:500" });
            AjWspol.Add(new AjWspol() { Aj = 0.3, NrTabeli = 13.1, Opis = "0,3 - dla mapy zasadniczej w skalach 1:1 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.1, NrTabeli = 13.1, Opis = "0,1 - dla mapy zasadniczej w skalach 1:2 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.02, NrTabeli = 13.1, Opis = "0,02 - dla mapy zasadniczej w skalach 1:5 000" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 13.2, Opis = "1,0 - dla mapy zasadniczej w skalach 1:500" });
            AjWspol.Add(new AjWspol() { Aj = 0.3, NrTabeli = 13.2, Opis = "0,3 - dla mapy zasadniczej w skalach 1:1 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.1, NrTabeli = 13.2, Opis = "0,1 - dla mapy zasadniczej w skalach 1:2 000" });
            AjWspol.Add(new AjWspol() { Aj = 0.02, NrTabeli = 13.2, Opis = "0,02 - dla mapy zasadniczej w skalach 1:5 000" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 13.3, Opis = "1,0 - dla wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 13.3, Opis = "0,7 - dla wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 13.4, Opis = "1,0 - dla wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 13.4, Opis = "0,7 - dla wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 1.0, NrTabeli = 14.3, Opis = "1,0 - dla ploterowego wydruku kolorowego" });
            AjWspol.Add(new AjWspol() { Aj = 0.7, NrTabeli = 14.3, Opis = "0,7 - dla ploterowego wydruku czarno-białego" });
            AjWspol.Add(new AjWspol() { Aj = 0.4, NrTabeli = 14.3, Opis = "0,4 - dla druku poligraficznego" });

            return AjWspol;
        }


    }
}
