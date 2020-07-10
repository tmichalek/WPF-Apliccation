using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using program_ewidencyjny.Others;
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
    class EditJobViewModel:AddEditJobBaseViewModel
    {

        public EditJobViewModel()
        {

            SetJobToEdit();
            setStatus();
            LoadContractors = new CommandHandler(AddContractorList, CanLoadContarctors);
            UpdateJob = new CommandHandler(JobUpdating, CanUpdate);
        }
        

        private JobToViewAndEdit _jobEdit { get; set; } 
        public  JobToViewAndEdit jobEdit
        {
            get { return _jobEdit; }
            set {
                _jobEdit = value;
                OnPropertyChanged();
                 }
        }

        private Praca _edit { get; set; }
        
        public Praca edit
        {
            get { return _edit; }
            set
            {
                _edit = value;
                OnPropertyChanged();
            }
        }

        
        int idJob { get; set; }

        private void SetJobToEdit()
        {
            // _JobEdit = new JobToViewAndEdit();
            jobEdit = (JobToViewAndEdit)App.Current.Windows.OfType<JobView>().First().ViewJobGrid.SelectedItem;
            idJob = int.Parse(_jobEdit.PracaId.ToString());
            _edit = _zgloszenie.Praca.Find(idJob);//(from a in _zgloszenie.Praca 
            //  .Where(i => i.PracaId == idJob)
            //         select a).First();
            _numberOfJob = _edit.Numer.ToString();
            _currentYear = _edit.Rok.ToString();
            _dateOfJob = _edit.DataZgloszenia;
            _dateOfJobEnd = _edit.DataZakonczeniaPrac;
            _kindOfJob = _edit.RodzpracyId;
            _charOfJob = _edit.CharakterOb.ToString();
            _jobTarget = _edit.AsortymentId;
            _plotJob = _edit.NumerDzialki;
            _gminaJob = _edit.GminaId;
            _obrebJob = _edit.ObrebId;
            _jobLocality = _edit.PolozenieOpis;
            _jobContractor = _edit.WykonawcaId;
            _contractor = (_zgloszenie.Wykonawca.Where(i => i.WykonawcaId == _edit.WykonawcaId)).ToList();
            _jobStatus = _edit.StatusId;
            ValidateJobLocality();
            ValidatePlotOfJob();
        }

       private void setStatus()
        {
            _setStatusJob = _zgloszenie.Status.ToList();
        }

        //Status
        private List<Status> _setStatusJob { get; set; }//lista statusów do dodawania pracy
        public List<Status> setStatusJob
        {
            get { return _setStatusJob; }
            set { _setStatusJob = value; }
        }
        private int _jobStatus { get; set; }
        public int jobStatus
        {
            get { return _jobStatus; }
            set
            {
                _jobStatus = value;
                OnPropertyChanged();
            }
        }

        private void AddContractorList()
        {
            _contractor = _zgloszenie.Wykonawca.ToList();
            OnPropertyChanged("contractor");
            
        }

        private bool CanLoadContarctors()
        {
            return true;
        }

        private void JobUpdating()
        {

            _edit.DataZgloszenia = _dateOfJob;
            _edit.DataZakonczeniaPrac = _dateOfJobEnd;
            _edit.PolozenieOpis = _jobLocality;
                _edit.CharakterOb = (CharakterOb)Enum.Parse(typeof(CharakterOb), _charOfJob);
           

            _edit.GminaId = _gminaJob;
            _edit.ObrebId = _obrebJob;

            _edit.WykonawcaId = _jobContractor;
            _edit.AsortymentId = _jobTarget;
            _edit.StatusId = _jobStatus;
            _edit.PolozenieId = 0;//poprawić
            _edit.RodzpracyId = _kindOfJob;
            _edit.NumerDzialki = _plotJob;
            _zgloszenie.SaveChanges();
            MessageBox.Show("Zmodyfikowano rekord");
            
            EditJobViev win = App.Current.Windows.OfType<EditJobViev>().First();// zamknięcie okna zapisu
            win.Close();
           
        }
        private bool  CanUpdate()
        {
            return true;
        }

        public CommandHandler LoadContractors { get; }
        public CommandHandler UpdateJob { get; }
    }
}
