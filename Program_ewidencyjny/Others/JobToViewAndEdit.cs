using program_ewidencyjny.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Others
{
    class JobToViewAndEdit
    {
        string _Prefiks { get; set; }
        public string Prefiks
        {
            get { return _Prefiks; }
            set { _Prefiks = value; }
        }


        short _Numer { get; set; }   
        public short Numer
        {
            get { return _Numer; }
            set { _Numer = value; }
        }


        short _Rok{get; set;}
        public short Rok
        {
            get { return _Rok; }
            set { _Rok = value; }
        }


        string _NazwaFirmy{get; set;}
        public string NazwaFirmy
        {
            get { return _NazwaFirmy; }
            set { _NazwaFirmy = value; }
        }

        string _NazwaGmina{get; set;}
        public string NazwaGmina
        {
            get { return _NazwaGmina; }
            set { _NazwaGmina = value; }
        }


        string _NazwaObreb{get; set;}
        public string NazwaObreb
        {
            get { return _NazwaObreb; }
            set { _NazwaObreb = value; }
        }

        string _PolozenieOpis{get; set;}
        public string PolozenieOpis
        {
            get { return _PolozenieOpis; }
            set { _PolozenieOpis = value; }
        }

        string _NumerDzialki{get; set;}
        public string NumerDzialki
        {
            get { return _NumerDzialki; }
            set { _NumerDzialki = value; }
        }

        CelPracy _CelPracy{get; set;}
        public CelPracy CelPracy
        {
            get { return _CelPracy; }
            set { _CelPracy = value; }
        }

        DateTime _DataZgloszenia{get; set;}
        public DateTime DataZgloszenia
        {
            get { return _DataZgloszenia; }
            set { _DataZgloszenia = value; }
        }

        DateTime _DataZakonczeniaPrac{get; set;}
        public DateTime DataZakonczeniaPrac
        {
            get { return _DataZakonczeniaPrac; }
            set { _DataZakonczeniaPrac = value; }
        }

        string _NazwaStatus{get; set;}
        public string NazwaStatus
        {
            get { return _NazwaStatus; }
            set { _NazwaStatus = value; }
        }


        CharakterOb _CharakterOb{get; set;}
        public CharakterOb CharakterOb
        {
            get { return _CharakterOb; }
            set { _CharakterOb = value; }
        }

        int _PracaId{get; set;}
        public int PracaId
        {
            get { return _PracaId; }
            set { _PracaId = value; }
        }


        bool _Aktualne{get; set;}
        public bool Aktualne
        {
            get { return _Aktualne; }
            set { _Aktualne = value; }
        }

        int _UzytkownikId{get; set;}
        public int UzytkownikId
        {
            get { return _UzytkownikId; }
            set { _UzytkownikId = value; }
        }

        int _PolozenieId{get; set;}
        public int PolozenieId
        {
            get { return _PolozenieId; }
            set { _PolozenieId = value; }
        }

        int _RodzpracyId{get; set;}
        public int RodzpracyId
        {
            get { return _RodzpracyId; }
            set { _RodzpracyId = value; }
        }

       

    }
}
