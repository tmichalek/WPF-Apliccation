using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Model.InitalizationTables
{
    class UzytkownikInitalization
    {
        
        IList<Uzytkownik> Uzytkownik = new List<Uzytkownik>();
        // { Add(new Uzytkownik() { Imie = "Admin", Nazwisko = "Admin", Login = "Admin", Haslo = haslo }) };



        public IList<Uzytkownik> InitUzytkownik()
        {
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();


            string haslo = BitConverter.ToString(sha.ComputeHash(utf8.GetBytes("master")));
            Uzytkownik.Add(new Uzytkownik() { Imie = "Admin", Nazwisko = "Admin", Login = "Admin", Haslo = haslo });
            return Uzytkownik;
        }
    }

}

