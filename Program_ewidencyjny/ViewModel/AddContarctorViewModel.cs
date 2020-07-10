using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_ewidencyjny.ViewModel
{
    class AddContarctorViewModel:BaseJobViewModel// stworzono poniewarz bindig nie obługiwał typów anonimowych (jobview)
    {
        public AddContarctorViewModel()
        {
            NewContract = new CommandHandler(AddNewContractor, CanAddContarctor);
            CloseContract = new CommandHandler(CloseNewCantractWin, CanCloseContarctor);
        }

        private string _businessName { get; set; }
        public string businessName {
            get {return _businessName; }
            set {_businessName=value;
                OnPropertyChanged();
            }
        }


        private string _contractorName { get; set; }
        public string contractorName
        {
            get=>  _contractorName; 
            set { _contractorName = value;
                OnPropertyChanged();
            }
        }

        private string _contractorSurname { get; set; }
        public string contractorSurname
        {
            get { return _contractorSurname; }
            set { _contractorSurname = value;
                OnPropertyChanged();
            }
        }

        private string _city { get; set; }
        public string city
        {
            get { return _city; }
            set { _city = value;
                OnPropertyChanged();
            }
        }

        private int _code { get; set; }
        public int code
        {
            get { return _code; }
            set { _code = value;
                OnPropertyChanged();
            }
        }


        private string _street { get; set; }
        public string street
        {
            get { return _street; }
            set { _street = value;
                OnPropertyChanged();
            }
        }

        private short _buildingNumber { get; set; }
        public short buildingNumber
        {
            get { return _buildingNumber; }
            set { _buildingNumber = value;
                OnPropertyChanged();
            }
        }

        private short _roomNumber { get; set; }
        public short roomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value;
                OnPropertyChanged();
            }
        }


        private int _phoneNumber { get; set; }
        public int phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value;
                OnPropertyChanged();
            }
        }

        private int _regonNumber { get; set; }
        public int regonNumber
        {
            get { return _regonNumber; }
            set { _regonNumber = value;
                OnPropertyChanged();
            }
        }


        private int _nipNumber { get; set; }
        public int nipNumber
        {
            get { return _nipNumber; }
            set { _nipNumber = value;
                OnPropertyChanged();
            }
        }


        private string _email { get; set; }
        public string email
        {
            get { return _email; }
            set { _email = value;
                OnPropertyChanged();
            }
        }

        private short _permissionNumber { get; set; }
        public short permissionNumber
        {
            get { return _permissionNumber; }
            set { _permissionNumber = value;
                OnPropertyChanged();
            }
        }

        private string _permissionRange { get; set; }
        public string permissionRange
        {
            get { return _permissionRange; }
            set { _permissionRange = value;
                OnPropertyChanged();
            }
        }

        private void AddNewContractor()
        {
            Wykonawca Wyk = new Wykonawca
            {

                NazwaFirmy = businessName,
                Imie = contractorName,
                Nazwisko = contractorSurname,
                AdresMiejscowosc = city,
                AdresKod = code,
                AdresUlica = street,
                NumerBudynku = buildingNumber,
                NumerLokalu = roomNumber,
                NrTelefonu = phoneNumber,
                Regon = regonNumber,
                Nip = nipNumber,
                AdresEmail = email,
                NrUprawnien = permissionNumber,
                ZakresUprawnien = permissionRange
            };
            try
            {
                _zgloszenie.Wykonawca.Add(Wyk);
                _zgloszenie.SaveChanges();
                MessageBox.Show("Dodano wykonawce");
                App.Current.Windows.OfType<AddContractorView>().First().Close();
            }

            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private bool CanAddContarctor()
        {
            return true;
        }

        private void CloseNewCantractWin()
        {
           AddContractorView NewWin=  App.Current.Windows.OfType<AddContractorView>().First();
            NewWin.Close();
        }

        private bool CanCloseContarctor()
        {
            return true;
        }

        public CommandHandler NewContract { get; }
        public CommandHandler CloseContract { get; }
    }
}
