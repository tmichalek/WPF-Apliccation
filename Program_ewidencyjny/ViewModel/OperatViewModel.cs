using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using program_ewidencyjny.Others;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_ewidencyjny.ViewModel
{
    class OperatViewModel : BaseJobViewModel, INotifyDataErrorInfo
    {
        public OperatViewModel()
        {
            SetDokumentsName();
            SetCarrierKind();
            SetOperatCharacter();
            SetTypeOfMaterial();
            SetArchivesTypes();
            SetAccessKind();
            SetGainInfo();
            SetNumberOfJob();
            AddNewOperat = new CommandHandler(AddOperat, CanAddOperat);

        }
        private Operat _operat;
        protected string _currentYear = DateTime.Today.Year.ToString();//bierzący rok do operatu
        public string currentYear
        {
            get { return _currentYear; }
            set { _currentYear = value; }
        }
        private int _numberOfOperat { get; set; }
        public int numberOfOperat
        {
            get { return _numberOfOperat; }
            set { _numberOfOperat = value; }
        }


        private List<String> _documentsName { get; set; }// nazwa dokumentu
        public List<String> documentsName
        {
            get { return _documentsName; }
            set
            {
                _documentsName = value;
                OnPropertyChanged();
            }
        }
        private String _documentsNameReceive { get; set; }// odbiera wybraną nazwę dokumentu
        public String documentsNameReceive
        {
            get { return _documentsNameReceive; }
            set
            {
                _documentsNameReceive = value;
                OnPropertyChanged();
            }
        }


        private List<String> _carrierKind { get; set; }// rodzaj nośnika
        public List<String> carrierKind
        {
            get { return _carrierKind; }
            set
            {
                _carrierKind = value;
                OnPropertyChanged();
            }
        }
        private String _carrierKindReceive { get; set; }// dane odbierajace wybrany rodzaj nośnika
        public String carrierKindReceive
        {
            get { return _carrierKindReceive; }
            set
            {
                _carrierKindReceive = value;
                OnPropertyChanged();
            }
        }


        private List<String> _operatCharackter { get; set; }// rodzaj nośnika
        public List<String> operatCharackter
        {
            get { return _operatCharackter; }
            set
            {
                _operatCharackter = value;
                OnPropertyChanged();
            }
        }
        private String _operatCharackterRecieve { get; set; }// rodzaj nośnika
        public String operatCharackterRecieve
        {
            get { return _operatCharackterRecieve; }
            set
            {
                _operatCharackterRecieve = value;
                Validate("operatCharackterRecieve");
                OnPropertyChanged();
            }
        }

        private List<String> _typeOfMaterial { get; set; }// typ materialu
        public List<String> typeOfMaterial
        {
            get { return _typeOfMaterial; }
            set
            {
                _typeOfMaterial = value;
                OnPropertyChanged();
            }
        }
        private String _typeOfMaterialRecieve { get; set; }// typ materialu
        public String typeOfMaterialRecieve
        {
            get { return _typeOfMaterialRecieve; }
            set
            {
                _typeOfMaterialRecieve = value;
                Validate("typeOfMaterialRecieve");
                OnPropertyChanged();
            }
        }

        private List<String> _archivesTypes { get; set; }// kategoria archiwum
        public List<String> archivesTypes
        {
            get { return _archivesTypes; }
            set
            {
                _archivesTypes = value;
                OnPropertyChanged();
            }
        }
        private String _archivesTypesRecieve { get; set; }// kategoria archiwum
        public String archivesTypesRecieve
        {
            get { return _archivesTypesRecieve; }
            set
            {
                _archivesTypesRecieve = value;
                OnPropertyChanged();
            }
        }

        private List<String> _accessKind { get; set; }// kategoria archiwum
        public List<String> accessKind
        {
            get { return _accessKind; }
            set
            {
                _accessKind = value;
                OnPropertyChanged();
            }
        }
        private String _accessKindRecieve { get; set; }//odbiera wybrane  kategoria archiwum
        public String accessKindRecieve
        {
            get { return _accessKindRecieve; }
            set
            {
                _accessKindRecieve = value;
                OnPropertyChanged();
            }
        }

        private List<String> _gainInfo { get; set; }// kategoria archiwum
        public List<String> gainInfo
        {
            get { return _gainInfo; }
            set
            {
                _gainInfo = value;
                OnPropertyChanged();
            }
        }

        private String _gainInfoRecieve { get; set; }// odbiera wybrane kategoria archiwum
        public String gainInfoRecieve
        {
            get { return _gainInfoRecieve; }
            set
            {
                _gainInfoRecieve = value;
                OnPropertyChanged();
            }
        }

        private DateTime _dateOfOperat { get; set; }
        public DateTime dateofOperat
        {
            get { return _dateOfOperat; }
            set
            {
                _dateOfOperat = value;
                OnPropertyChanged();
            }
        }

        private string _languageRecieve { get; set; }
        public string languageRecieve
        {
            get { return _languageRecieve; }
            set
            {
                _languageRecieve = value;
                OnPropertyChanged();
            }
        }

        private void SetDokumentsName()// ustawia nazwę nośnika
        {
            documentsName = new List<string>();
            NazwaMat Mat = new NazwaMat();
            documentsName = Mat.GetType().GetEnumNames().ToList();
        }

        private void SetCarrierKind()// ustawia nazwę nośnika
        {
            carrierKind = new List<string>();
            RodzajNosnikaNielektroniczny RN = new RodzajNosnikaNielektroniczny();
            carrierKind = RN.GetType().GetEnumNames().ToList();
        }

        private void SetOperatCharacter()// ustawia postac materialu
        {
            operatCharackter = new List<string>();
            Postac Pos = new Postac();
            operatCharackter = Pos.GetType().GetEnumNames().ToList();
        }

        private void SetTypeOfMaterial()// ustawia postac materialu
        {
            typeOfMaterial = new List<string>();
            TypMaterialu TM = new TypMaterialu();
            typeOfMaterial = TM.GetType().GetEnumNames().ToList();
        }

        private void SetArchivesTypes()// ustawia postac materialu
        {
            archivesTypes = new List<string>();
            KatArchiw KA = new KatArchiw();
            archivesTypes = KA.GetType().GetEnumNames().ToList();
        }

        private void SetAccessKind()// ustawia informacje o dostępie
        {
            accessKind = new List<string>();
            InfoODostepie AI = new InfoODostepie();
            accessKind = AI.GetType().GetEnumNames().ToList();
        }

        private void SetGainInfo()// ustawia informacje o dostępie
        {
            gainInfo = new List<string>();
            SposobPozyskania SP = new SposobPozyskania();
            gainInfo = SP.GetType().GetEnumNames().ToList();
        }

        private void SetNumberOfJob()
        {

            int currentNumberInDatabase = (from n in _zgloszenie
                                             .Operat
                                             .OrderByDescending(n => n.Rok).ThenByDescending(n => n.Numer)
                                           select n.Numer)
                                             .FirstOrDefault();
            int currentYearInDatabase = (from n in _zgloszenie
                                              .Operat
                                              .OrderByDescending(n => n.Rok)
                                         select n.Rok)
                                             .FirstOrDefault();

            if ((short.Parse(currentYear)) - (currentYearInDatabase) == 0)
            {
                currentNumberInDatabase++;
                _numberOfOperat = currentNumberInDatabase;
            }
            else
                numberOfOperat = (1);

        }
        JobToViewAndEdit _jobEditOperat;
        private void AddOperat()
        {
            _jobEditOperat = (JobToViewAndEdit)App.Current.Windows.OfType<JobView>().First().ViewJobGrid.SelectedItem;
            SposobPozyskania? temporary;
            if (gainInfoRecieve != null)
            {
                temporary = (SposobPozyskania)Enum.Parse(typeof(SposobPozyskania), gainInfoRecieve);
            }
            else
            {
                temporary = null;
            }
            _operat = new Operat
            {
                

            OznCzesciZasobu = (OznCzesciZasobu)Enum.Parse(typeof(OznCzesciZasobu), "P"),
                Oznaczenie2 = 0812,
                Rok = int.Parse(currentYear),
                Numer = numberOfOperat,
                NazwaMat = (NazwaMat)Enum.Parse(typeof(NazwaMat), documentsNameReceive),
                RodzajNosnikaNielektroniczny = (RodzajNosnikaNielektroniczny)Enum.Parse(typeof(RodzajNosnikaNielektroniczny), carrierKindReceive),
                Postac = (Postac)Enum.Parse(typeof(Postac), operatCharackterRecieve),
                TypMaterialu = (TypMaterialu)Enum.Parse(typeof(TypMaterialu), typeOfMaterialRecieve),
                KatArchiw = (KatArchiw)Enum.Parse(typeof(KatArchiw), archivesTypesRecieve),
                DataArch = dateofOperat,
                SposobPozyskania = temporary,
                InfoODostepie = (InfoODostepie)Enum.Parse(typeof(InfoODostepie),  accessKindRecieve),
                Jezyk = languageRecieve,
                   PracaId=_jobEditOperat.PracaId,
            };
            try
            {
                _zgloszenie.Operat.Add(_operat);
                _zgloszenie.SaveChanges();
                MessageBox.Show("Dodano nowy rekord");
                OperatView win = App.Current.Windows.OfType<OperatView>().First();// zamknięcie okna zapisu
                win.Close();
                // zmiana w parca na aktualne 0 sprawdzic czy działa
                Praca _changeActiveField = new Praca();
                _changeActiveField = _zgloszenie.Praca.Find(_jobEditOperat.PracaId);
                _changeActiveField.Aktualne = false;
                _zgloszenie.SaveChanges();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        private bool CanAddOperat()
        {
            return true;
        }

        public CommandHandler AddNewOperat { get; }

        private readonly Dictionary<string, List<string>> _errorsByPropertyName = new Dictionary<string, List<string>>();

        public bool HasErrors => _errorsByPropertyName.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errorsByPropertyName.ContainsKey(propertyName) ?
                _errorsByPropertyName[propertyName] : null;
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        private void Validate(string propertyName)
        {
            switch (propertyName)
            {
                case "operatCharackterRecieve":
                    ValidateoperatCharackterRecieve();
                    break;
                case "typeOfMaterialRecieve":
                    ValidatetypeOfMaterialRecieve();
                    break;
            }


            }

            private void ValidateoperatCharackterRecieve()
        {
            ClearErrors(nameof(operatCharackterRecieve));
            if (string.IsNullOrWhiteSpace("operatCharackterRecieve"))
                AddError(nameof(operatCharackterRecieve), "Username cannot be empty.");

            if (operatCharackterRecieve == null || operatCharackterRecieve?.Length <= 5)
                AddError(nameof(operatCharackterRecieve), "Username must be at least 6 characters long.");
        }

        private void ValidatetypeOfMaterialRecieve()
        {
            ClearErrors(nameof(typeOfMaterialRecieve));
            if (string.IsNullOrWhiteSpace("typeOfMaterialRecieve"))
                AddError(nameof(typeOfMaterialRecieve), "Username cannot be empty.");

            if (typeOfMaterialRecieve == null)
                AddError(nameof(typeOfMaterialRecieve), "Username must be at least 6 characters long.");
        }

        private void AddError(string propertyName, string error)
        {
            if (!_errorsByPropertyName.ContainsKey(propertyName))
                _errorsByPropertyName[propertyName] = new List<string>();

            if (!_errorsByPropertyName[propertyName].Contains(error))
            {
                _errorsByPropertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }

        private void ClearErrors(string propertyName)
        {
            if (_errorsByPropertyName.ContainsKey(propertyName))
            {
                _errorsByPropertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }



    }
}
    

