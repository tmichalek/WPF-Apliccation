using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;
using program_ewidencyjny.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_ewidencyjny.ViewModel
{
    class AddEditJobBaseViewModel:BaseJobViewModel, INotifyDataErrorInfo
    {
        protected AddEditJobBaseViewModel()
        {
            setGmina();
            setObreb();
            SetCharOb();
            SetRodzPr();
            setContractor();
            setAsortAddJob();
            SetNumberOfJob();
            dateOfJob = DateTime.Now;
            CloseAddEditJobWin = new CommandHandler(CloseAddJob, CanClose);
            OpenNewContractorWin = new CommandHandler(AddNewContarctorWin, CanOpenNewContrWin);
            ValidateJobLocality();
            ValidatePlotOfJob();
        }

        protected string _currentYear = DateTime.Today.Year.ToString();//bierzący rok do zgłoszenia roboty
        public string currentYear
        {
            get { return _currentYear; }
            set { _currentYear = value; }
        }


        protected List<Gmina> _gmina { get; set; }//lista gmin do dodawania pracy
        public List<Gmina> gmina
        {
            get { return _gmina; }
            set { _gmina = value; }
        }

        private void setGmina()
        {
            
            _gmina = (from g in _zgloszenie.Gmina select g).ToList();

        }

        protected List<Obreb> _setObrebJob { get; set; }//lista gmin do dodawania pracy
        public List<Obreb> setObrebJob
        {
            get { return _setObrebJob; }
            set { _setObrebJob = value; }
        }

        private void setObreb()
        {
            
            _setObrebJob = (from o in _zgloszenie.Obreb select o).ToList();

        }

        protected List<Asortyment> _setAsortbJob { get; set; }//lista gmin do dodawania pracy
        public List<Asortyment> setAsortJob
        {
            get { return _setAsortbJob; }
            set { _setAsortbJob = value; }
        }

        protected void setAsortAddJob()// lista asortymentów do dodania pracy
        {
            
            _setAsortbJob = (from o in _zgloszenie.Asortyments select o).ToList();

        }

        protected List<String> _charakterOb { get; set; } // charakter obiektu do dodawania pracy
        public List<String> charakterOb
        {
            get { return _charakterOb; }
            set { _charakterOb = value; }
        }

        protected void SetCharOb()
        {
            _charakterOb = new List<String>();
            CharakterOb charOb = new CharakterOb();

            _charakterOb = charOb.GetType().GetEnumNames().ToList();
        }



        protected List<RodzPracy> _rodzajPracy { get; set; } // rodzaj pracy do dodawania pracy
        public List<RodzPracy> rodzajPracy
        {
            get { return _rodzajPracy; }
            set
            {
                _rodzajPracy = value;

            }
        }

        protected void SetRodzPr()
        {
            _rodzajPracy = new List<RodzPracy>();
           

            _rodzajPracy = _zgloszenie.RodzPracy.ToList(); //rodzPrac.GetType().GetEnumNames().ToList();
        }

        protected List<Wykonawca> _contractor { get; set; }//lista wykonawców do dodania roboty
        public List<Wykonawca> contractor
        {
            get { return _contractor; }
            set { _contractor = value; }
        }

        private void setContractor()
        {
            _contractor = new List<Wykonawca>();
            _contractor = _zgloszenie.Wykonawca.ToList();
        }

        // ODEBRANIE DANYCH OD DODANIA ZGLOSZENIA

        // numer pracy
        protected String _numberOfJob { get; set; }
        public String numberOfJob
        {
            get { return _numberOfJob; }
            set
            {
                _numberOfJob = value;
                //ValidateDateOfJob();
                //ValidatePlotOfJob();
                OnPropertyChanged();
            }
        }

        private void SetNumberOfJob()
        {
            
            short currentNumberInDatabase = (from n in _zgloszenie
                                             .Praca
                                             .OrderByDescending(n => n.Rok).ThenByDescending(n => n.Numer)
                                             select n.Numer)
                                             .FirstOrDefault();
            short currentYearInDatabase = (from n in _zgloszenie
                                              .Praca
                                              .OrderByDescending(n => n.Rok)
                                           select n.Rok)
                                             .FirstOrDefault();

            if ((short.Parse(currentYear)) - (currentYearInDatabase) == 0)
            {
                currentNumberInDatabase++;
                _numberOfJob = currentNumberInDatabase.ToString();
            }
            else
                numberOfJob = (1).ToString();

        }

        // rok
        protected int _yearOfJob { get; set; }
        public int yearOfJob
        {
            get { return _yearOfJob; }
            set
            {
                _yearOfJob = value;
                OnPropertyChanged();
            }
        }
        //data zgloszenia
        protected DateTime _dateOfJob { get; set; }
        public DateTime dateOfJob
        {
            get { return _dateOfJob; }
            set
            {
                _dateOfJob = value;
               // ValidatePlotOfJob();
                OnPropertyChanged();
            }
        }
        //data zakonczenia pracy
        protected DateTime _dateOfJobEnd { get; set; }
        public DateTime dateOfJobEnd
        {
            get { return _dateOfJobEnd; }
            set
            {
                _dateOfJobEnd = value;
                //Validate("dateOfJobEnd");
                OnPropertyChanged();
            }
        }
        //rodzaj pracy
        protected int _kindOfJob { get; set; }
        public int kindOfJob
        {
            get { return _kindOfJob; }
            set
            {
                _kindOfJob = value;
                ValidateKindOfJob();
                OnPropertyChanged();
                
            }
        }
        //charakter obiekty
        protected string _charOfJob { get; set; }
        public string charOfJob
        {
            get { return _charOfJob; }
            set
            {
                _charOfJob = value;
                

                OnPropertyChanged();
            }
        }
        //cel pracy/asortyment
        protected int _jobTarget { get; set; }
        public int jobTarget
        {
            get { return _jobTarget; }
            set
            {
                _jobTarget = value;
                OnPropertyChanged();
            }
        }
        //dzialka
        protected String _plotJob { get; set; }
        public String plotJob
        {
            get { return _plotJob; }
            set
            {
                _plotJob = value;
                // Validate("plotOfJob");
                ValidatePlotOfJob();
                OnPropertyChanged();
            }
        }
        //gmina
        protected int _gminaJob { get; set; }
        public int gminaJob
        {
            get { return _gminaJob; }
            set
            {
                _gminaJob = value;
                OnPropertyChanged();
            }
        }
        //obreb
        protected int _obrebJob { get; set; }
        public int obrebJob
        {
            get { return _obrebJob; }
            set
            {
                _obrebJob = value;
                OnPropertyChanged();
                ValidatePlotOfJob();
                
            }
        }
        //położenie
        protected String _jobLocality { get; set; }
        public String jobLocality
        {
            get { return _jobLocality; }
            set
            {
                _jobLocality = value;
                ValidateJobLocality();
                OnPropertyChanged();
            }
        }
        //wykonawca
        protected int _jobContractor { get; set; }
        public int jobContractor
        {
            get { return _jobContractor; }
            set
            {
                _jobContractor = value;
                OnPropertyChanged();
            }
        }

       
        protected Praca _job;

        

        private void AddNewContarctorWin()// okno dodania nowego wykonawce
        {
            AddContractorView newContactowWindow = new AddContractorView();
            newContactowWindow.ShowDialog();
            if (newContactowWindow.Focusable)
            {
                setContractor();
            }
        }
        private bool CanOpenNewContrWin()
        {
            return true;
        }

        private void CloseAddJob()
        {
            AddJob win = App.Current.Windows.OfType<AddJob>().First();
            win.Close();
        }


        private bool CanClose()
        {
            return true;
        }

        

        public CommandHandler CloseAddEditJobWin { get; }
        
        public CommandHandler OpenNewContractorWin { get; }

        //private void DataCharOfJobValidation()
        //{
        //    //Validate Name property
        //    List<string> listErrors;
        //    if (propErrors.TryGetValue("charOfJob", out listErrors) == false)
        //        listErrors = new List<string>();
        //    else
        //        listErrors.Clear();

        //    if (charOfJob == null)
        //        listErrors.Add("Name should not be empty!!!");

        //    propErrors["charOfJob"] = listErrors;

        //    if (listErrors.Count > 0)
        //    {
        //        OnErrorsChanged();
        //    }
        //}
        //private void DataplotJobValidation()
        //{
        //    //Validate Name property
        //    List<string> listErrors;
        //    if (propErrors.TryGetValue("plotJob", out listErrors) == false)
        //        listErrors = new List<string>();
        //    else
        //        listErrors.Clear();

        //    if (plotJob == string.Empty)
        //        listErrors.Add("Name should not be empty!!!");

        //    propErrors["plotJob"] = listErrors;

        //    if (listErrors.Count > 0)
        //    {
        //        OnErrorsChanged("plotJob");
        //    }
        //}

        //#region INotyfyDataErrorInfo
        //private Dictionary<string, List<string>> propErrors = new Dictionary<string, List<string>>();

        //public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        //protected virtual void OnErrorsChanged(string p)
        //{
        //    if (ErrorsChanged != null)
        //        ErrorsChanged.Invoke(this, new DataErrorsChangedEventArgs(p));
        //}
        //public IEnumerable GetErrors(string propertyName)
        //{
        //    List<string> errors = new List<string>();
        //    if (propertyName != null)
        //    {
        //        propErrors.TryGetValue(propertyName, out errors);
        //        return errors;
        //    }

        //    else
        //        return null;
        //}
        //public bool HasErrors
        //{
        //    get
        //    {
        //        var propErrorsCount = propErrors.Values.FirstOrDefault(r => r.Count > 0);
        //        if (propErrorsCount != null)
        //            return true;
        //        else
        //            return false;
        //    }
        //}




//#endregion INotyfyDataErrorInfo

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

        protected void ValidatePlotOfJob()
        {
            ClearErrors(nameof(plotJob));
            if (plotJob == null || plotJob==string.Empty)
                AddError(nameof(plotJob), "Pole działka musi być wypełnione.");
        }

        protected void ValidateJobLocality()
        {
            ClearErrors(nameof(jobLocality));
            
            if (jobLocality == null || jobLocality == string.Empty)
                AddError(nameof(jobLocality), "Pole położenie musi być wypełnione");
        }

        protected void ValidateKindOfJob()
        {
            ClearErrors(nameof(kindOfJob));

            if (kindOfJob == null || kindOfJob == 0)
                AddError(nameof(kindOfJob), "Pole położenie musi być wypełnione");
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

