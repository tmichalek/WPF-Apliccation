using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Net.Mime.MediaTypeNames;

namespace program_ewidencyjny.ViewModel
{
    class AddJobViewModel : AddEditJobBaseViewModel

    {
        public  AddJobViewModel()
           
        {
            
            AddJobToDatabase = new CommandHandler(AddNewJob, CanAddJob);
            
           

        }
        //private void DataValidation()
        //{
        //    //Validate Name property
        //    List<string> listErrors;
        //    if (propErrors.TryGetValue("charOfJob", out listErrors) == false)
        //        listErrors = new List<string>();
        //    else
        //        listErrors.Clear();

        //    if (charOfJob ==null)
        //        listErrors.Add("Name should not be empty!!!");

        //    propErrors["charOfJob"] = listErrors;

        //    if (listErrors.Count > 0)
        //    {
        //        OnErrorsChanged();
        //    }
        //}

        private void AddNewJob()
        {
           
            _job = new Praca
            {
                Numer = short.Parse(_numberOfJob),
                Rok = short.Parse(currentYear),
                DataZgloszenia = _dateOfJob,
                DataZakonczeniaPrac = _dateOfJobEnd,
                PolozenieOpis = _jobLocality,
                CharakterOb = (CharakterOb)Enum.Parse(typeof(CharakterOb), _charOfJob),
                Aktualne = true,
                PrefiksId = 2,
                GminaId = _gminaJob,
                ObrebId = _obrebJob,
                UzytkownikId = 1,//poprawic
                WykonawcaId = _jobContractor,
                AsortymentId = _jobTarget,
                StatusId = 1,
                PolozenieId = 0,//poprawić
                RodzpracyId = _kindOfJob,
                NumerDzialki = _plotJob
            };
            try
            {
                _zgloszenie.Praca.Add(_job);
                _zgloszenie.SaveChanges();
                MessageBox.Show("Dodano nowy rekord");
                AddJob win = App.Current.Windows.OfType<AddJob>().First();// zamknięcie okna zapisu
                win.Close();

            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private bool CanAddJob()
        {
            if (HasErrors == true)
                return false;
            else
                return true;
           
        }

        public CommandHandler AddJobToDatabase { get; }
        

    }
}
