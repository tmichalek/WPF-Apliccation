using program_ewidencyjny.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using program_ewidencyjny.ViewModel.Command;
using program_ewidencyjny.View;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace program_ewidencyjny.ViewModel
{
    class Login:BaseViewModel 
    {
        private PracaIzynierskaDBContext _LogVM { get; set; }
        public PracaIzynierskaDBContext LogVM
        {
            get { return _LogVM; }
            set { _LogVM = value; }
        }


        public Login()
        {
            _LogVM = new PracaIzynierskaDBContext();
           
            
                check = new CommandHandler(Takepassword, PasswordLenght);
        }



        private string _login { get; set; }
        public string login
        {
            get { return _login; }
            set
            {
                _login = value;
               OnPropertyChanged();
               // check.RaiseCanExecuteChanged();
                
            }
        }

        private string _password { get; set; }
        public string password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
                
            }
        }



        private string passwordFromDB { get; set; } 
        private string loginFromDB { get; set; }
        private string passwordFromText { get; set; }

        
        private List<Uzytkownik> _users { get; set; }
        public CommandHandler check { get; }


        private void Takepassword()
        {
            try
            {
                _users = _LogVM.Uzytkownik.ToList();
                if (_users.Count != 0)
                {
                    loginFromDB = _users.First(p => p.Login == _login).Login.ToString();
                    passwordFromDB = _users.First(p => p.Login == _login).Haslo.ToString();
                    passwordFromText = Hashstring(password);



                    if (passwordFromDB == passwordFromText) 
                    {
                        JobView zglosz = new JobView();
                        zglosz.Show();

                        Application.Current.MainWindow.Close();


                    }
                    else MessageBox.Show("Błędny login lub hasło!");
                }
                
            }
            catch ( SqlException e )
            {
                MessageBox.Show("Użytkownik nie istnieje lub błędnie skonfigurowano połączenie z bazą" + e.Message);
            }

            
        }


        private  string Hashstring(string tohash)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            
            return BitConverter.ToString(sha1.ComputeHash(utf8.GetBytes(tohash)));


        }

        private bool PasswordLenght()
        {
            
            return (_login.Length>=2 & _password.Length >=6);
            //    return true;
            //else return false;
            




        }


    }
}
