using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program_ewidencyjny.Model.Domain;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class PdInitialization
    {

        IList<PdWspol> PdWspol = new List<PdWspol>();

        public IList<PdWspol> PdInit()
        {
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 4.1, Opis = "1,0, jeżeli udostępniony zbiór punktów zawiera wszystkie informacje dotyczące tych punktów" });
            PdWspol.Add(new PdWspol() { Pd = 0.8, NrTabeli = 4.1, Opis = "0,8, jeżeli udostępniony zbiór punktów nie zawiera obserwacji" });
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 5.1, Opis = "1,0, jeżeli udostępniony zbiór punktów zawiera wszystkie informacje dotyczące tych punktów" });
            PdWspol.Add(new PdWspol() { Pd = 0.8, NrTabeli = 5.1, Opis = "0,8, jeżeli udostępniony zbiór punktów nie zawiera obserwacji" });
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 9.1, Opis = "1,0 - w przypadku udostępniania pełnego zbioru danych bazy danych EGiB (dane przedmiotowe i podmiotowe" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 9.1, Opis = "0,7 - w przypadku udostępniania tylko danych przedmiotowych (opisowych i geometrycznych) ze zbioru bazy danych EGiB" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 9.1, Opis = "0,5 - w przypadku udostępniania tylko opisowych albo tylko geometrycznych danych przedmiotowych ze zbioru bazy danych EGiB" });
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 9.3, Opis = "1,0 - w przypadku udostępniania pełnego zbioru danych dotyczšcych działek ewidencyjnych" });
            PdWspol.Add(new PdWspol() { Pd = 0.6, NrTabeli = 9.3, Opis = "0,6 - w przypadku udostępniania tylko opisowych lub tylko geometrycznych danych dotyczšcych działek ewidencyjnych albo budynków" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 9.3, Opis = "0,3 - w przypadku w przypadku udostępniania tylko opisowych lub tylko geometrycznych danych dotyczšcych lokali" });
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.1, Opis = "1,00 - dla arkusza mapy w formacie A0" });
            PdWspol.Add(new PdWspol() { Pd = 0.6, NrTabeli = 10.1, Opis = "0,60 - dla arkusza mapy w formacie A1" });
            PdWspol.Add(new PdWspol() { Pd = 0.4, NrTabeli = 10.1, Opis = "0,40 - dla arkusza mapy w formacie A2" });
            PdWspol.Add(new PdWspol() { Pd = 0.25, NrTabeli = 10.1, Opis = "0,40 - dla arkusza mapy w formacie A3" });
            PdWspol.Add(new PdWspol() { Pd = 0.15, NrTabeli = 10.1, Opis = "0,40 - dla arkusza mapy w formacie A4" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.2, Opis = "1,00 - dla arkusza mapy w formacie A0" });
            PdWspol.Add(new PdWspol() { Pd = 0.6, NrTabeli = 10.2, Opis = "0,60 - dla arkusza mapy w formacie A1" });
            PdWspol.Add(new PdWspol() { Pd = 0.4, NrTabeli = 10.2, Opis = "0,40 - dla arkusza mapy w formacie A2" });
            PdWspol.Add(new PdWspol() { Pd = 0.25, NrTabeli = 10.2, Opis = "0,40 - dla arkusza mapy w formacie A3" });
            PdWspol.Add(new PdWspol() { Pd = 0.15, NrTabeli = 10.2, Opis = "0,40 - dla arkusza mapy w formacie A4" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.5, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.5, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.5, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.5, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.6, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.6, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.6, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.6, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.7, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.7, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.7, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.7, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.8, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.8, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.8, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.8, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });						
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.9, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.9, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.9, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.9, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.10, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.10, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.10, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.10, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.11, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.11, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.11, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.11, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });		
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.12, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.12, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.12, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.12, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });						
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.13, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.13, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.13, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.13, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });						
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.14, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.14, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.14, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.14, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });		
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.15, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.15, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.15, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.15, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });						
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.16, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.16, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.16, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.16, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });						
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.17, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.17, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.17, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.17, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 10.18, Opis = "1,0 - dla obrębów ewidencyjnych o powierzchni większej niż 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 10.18, Opis = "0,7 - dla obrębów ewidencyjnych o powierzchni w przedziale 300 - 600 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.5, NrTabeli = 10.18, Opis = "0,5 - dla obrębów ewidencyjnych o powierzchni mniejszej niż 300 ha, ale większej niż 100 ha" });
            PdWspol.Add(new PdWspol() { Pd = 0.3, NrTabeli = 10.18, Opis = "0,3 - dla obrębów ewidencyjnych o powierzchni nie większej niż 100 ha" });		
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 13.3, Opis = "1,00 - dla arkusza mapy w formacie A0" });
            PdWspol.Add(new PdWspol() { Pd = 0.6, NrTabeli = 13.3, Opis = "0,60 - dla arkusza mapy w formacie A1" });
            PdWspol.Add(new PdWspol() { Pd = 0.4, NrTabeli = 13.3, Opis = "0,40 - dla arkusza mapy w formacie A2" });
            PdWspol.Add(new PdWspol() { Pd = 0.25, NrTabeli = 13.3, Opis = "0,25 - dla arkusza mapy w formacie A3" });
            PdWspol.Add(new PdWspol() { Pd = 0.15, NrTabeli = 13.3, Opis = "0,15 - dla arkusza mapy w formacie A4" });		
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 13.4, Opis = "1,00 - dla arkusza mapy w formacie A0" });
            PdWspol.Add(new PdWspol() { Pd = 0.6, NrTabeli = 13.4, Opis = "0,60 - dla arkusza mapy w formacie A1" });
            PdWspol.Add(new PdWspol() { Pd = 0.4, NrTabeli = 13.4, Opis = "0,40 - dla arkusza mapy w formacie A2" });
            PdWspol.Add(new PdWspol() { Pd = 0.25, NrTabeli = 13.4, Opis = "0,25 - dla arkusza mapy w formacie A3" });
            PdWspol.Add(new PdWspol() { Pd = 0.15, NrTabeli = 13.4, Opis = "0,15 - dla arkusza mapy w formacie A4" });			
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 16.1, Opis = "1,0 - dla formatu A4 lub mniejszego" });
            PdWspol.Add(new PdWspol() { Pd = 1.5, NrTabeli = 16.1, Opis = "1,5 - dla formatu A3" });
            PdWspol.Add(new PdWspol() { Pd = 2.0, NrTabeli = 16.1, Opis = "2,0 - dla formatu większego niż A3" });	
            PdWspol.Add(new PdWspol() { Pd = 1.0, NrTabeli = 16.6, Opis = "1,0 - w przypadku gdy przedmiotem wniosku o uzgodnienie są sieci uzbrojenia terenu niebędące przyłączami" });
            PdWspol.Add(new PdWspol() { Pd = 0.7, NrTabeli = 16.6, Opis = "0,7 - w przypadku gdy przedmiotem wniosku o uzgodnienie są przyłącza" });

            return PdWspol;
        }


    }
}
