using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Model.Enum;
using program_ewidencyjny.Others;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;

namespace program_ewidencyjny.ViewModel
{
    class JobViewModel:BaseJobViewModel
    {

        
        public JobViewModel()

        {
            tabelaZgl();
            numerPracy = new CommandHandlerAsync(findingjob, AlwaysTrue);
            AddJobWindow = new CommandHandler(OpenNewJobWindow, AlwaysTrue);
            SetAsort();           
            _obreby = new List<String>();
            SetObr();
            EditJob = new CommandHandler(EditJobNewWin, AlwaysTrue);
            AddPriceList = new CommandHandler(PriceListWin,CanAddPriceListWindow);
            AddOperatWindow = new CommandHandler(OperatNewWindow, CanAddOperatWindow);
        }
  
        private IEnumerable<object> _jobView;

        public IEnumerable<object> jobView
        {
            get { return _jobView; }
            set {
                _jobView = value;
                OnPropertyChanged();
            }

        }
        

        public void tabelaZgl()
        {
            IEnumerable<object> tabela = (from pr in _zgloszenie.Praca
                                          join ob in _zgloszenie.Obreb on pr.ObrebId equals ob.ObrebId
                                          join gm in _zgloszenie.Gmina on pr.GminaId equals gm.GminaId
                                          join wk in _zgloszenie.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
                                          join sa in _zgloszenie.Asortyments on pr.AsortymentId equals sa.AsortymentId
                                          join px in _zgloszenie.Prefix on pr.PrefiksId equals px.PrefiksId
                                          join st in _zgloszenie.Status on pr.StatusId equals st.StatusId
                                          select new JobToViewAndEdit()
                                          {
                                              Prefiks = px.Prefiks,
                                              Numer = pr.Numer,
                                              Rok = pr.Rok,
                                              NazwaFirmy = wk.NazwaFirmy,
                                              NazwaGmina = gm.NazwaGmina,
                                              NazwaObreb = ob.NazwaObreb,
                                              PolozenieOpis = pr.PolozenieOpis,
                                              NumerDzialki = pr.NumerDzialki,
                                              CelPracy = sa.CelPracy,
                                              DataZgloszenia = pr.DataZgloszenia,
                                              DataZakonczeniaPrac = pr.DataZakonczeniaPrac,
                                              NazwaStatus = st.NazwaStatus,
                                              CharakterOb = pr.CharakterOb,
                                              PracaId = pr.PracaId,
                                              Aktualne = pr.Aktualne,
                                              UzytkownikId = pr.UzytkownikId,
                                              PolozenieId = pr.PolozenieId,
                                              RodzpracyId = pr.RodzpracyId
                                          }).ToList();
            _jobView = tabela.ToList();
            
        }

        private string _findJob { get; set; }//odbiera text z pola szukajacego
        public string findJob
        {
            get { return _findJob; }
            set
            {
                _findJob = value;
                OnPropertyChanged();
            }
        }

        private List<CelPracy> _asortyment { get; set; }// rodzaje asortymentów w robocie
        public List<CelPracy> asortyment
        {
            get { return _asortyment; }
            set
            {
                _asortyment = value;
                OnPropertyChanged();
            }
        }

        private void SetAsort()
        {

            asortyment = (from s in _zgloszenie.Asortyments
                          select s.CelPracy).ToList();

        }

        private List<String> _obreby { get; set; }// lista z obrebami do wyswietlenia w szukanie i dodaniu zgloszenia

        public List<String> obreby
        {
            get { return _obreby; }

            set
            {
                _obreby = value;
                OnPropertyChanged();
            }
        }

        private void SetObr()
        {
            _obreby = (from ob in _zgloszenie.Obreb select ob.NazwaObreb).ToList();

            _obreby.Add("wszystkie");//dodatkowa opcja przy wyszukiwaniu aby móc wyświetlić wszystkie obreby
        }

        private string _survey { get; set; }//odbiera dane z pola wykonawca

        public string survey
        {
            get { return _survey; }
            set
            {
                _survey = value;
                OnPropertyChanged();
            }
        }

        private string _plot { get; set; } // pobiera numer dzialki od uzytkownika
        public string plot
        {
            get
            { return _plot; }

            set
            {
                _plot = value;
                OnPropertyChanged();
            }
        }

        private string _findYear { get; set; }//odbiera rok z pola szukajacego
        public string findYear
        {
            get { return _findYear; }
            set
            {

                _findYear = value;
                OnPropertyChanged();
            }
        }

       
        private string _asort { get; set; }// odbiera dane z pola asortyment

        public string asort
        {
            get { return _asort; }
            set
            {
                _asort = value;
                OnPropertyChanged();
            }
        }

       
        private string _obr { get; set; }// pobranie ustawionego obrebu

        public string obr
        {
            get { return _obr; }

            set
            {
                _obr = value;
                OnPropertyChanged();
            }
        }


        private async Task findingjob()// funkcja do command binding filtrujaca
        {
            IEnumerable<object> tabela = await (from pr in _zgloszenie.Praca
                                          join ob in _zgloszenie.Obreb on pr.ObrebId equals ob.ObrebId
                                          join gm in _zgloszenie.Gmina on pr.GminaId equals gm.GminaId
                                          join wk in _zgloszenie.Wykonawca on pr.WykonawcaId equals wk.WykonawcaId
                                          join sa in _zgloszenie.Asortyments on pr.AsortymentId equals sa.AsortymentId
                                          join px in _zgloszenie.Prefix on pr.PrefiksId equals px.PrefiksId
                                          join st in _zgloszenie.Status on pr.StatusId equals st.StatusId
                                          where (pr.Numer.ToString().StartsWith(_findJob))
                                          && (pr.Rok.ToString().StartsWith(_findYear))
                                          && (wk.NazwaFirmy.StartsWith(_survey))
                                           && (sa.CelPracy.ToString().Contains(_asort))
                                          && (pr.NumerDzialki == null || pr.NumerDzialki.StartsWith(_plot))
                                          && (ob.NazwaObreb.Contains(obr))
                                          orderby pr.Rok, pr.Numer
                                          select new JobToViewAndEdit { Prefiks=px.Prefiks, Numer=pr.Numer, Rok=pr.Rok, NazwaFirmy=wk.NazwaFirmy,
                                          NazwaGmina =gm.NazwaGmina, NazwaObreb=ob.NazwaObreb, PolozenieOpis=pr.PolozenieOpis,
                                          NumerDzialki =pr.NumerDzialki, CelPracy=sa.CelPracy,DataZgloszenia =pr.DataZgloszenia,
                                          DataZakonczeniaPrac =pr.DataZakonczeniaPrac, NazwaStatus=st.NazwaStatus, CharakterOb=pr.
                                          CharakterOb, PracaId=pr.PracaId }).ToListAsync();

            jobView = tabela.ToList();
        }      
        private bool AlwaysTrue()
        {
            return true;// _findJob != null ? true : false;
        }

        private void OpenNewJobWindow()// otwarcie okna zgloszenia pracy
        {
            AddJob AddJobWin = new AddJob();
            AddJobWin.ShowDialog();
            if (AddJobWin.Focusable)
                tabelaZgl();
        }

        private int _selectedJobToEdit { get; set; }// pobiera nr id z zaznaczonej roboty
        public int selectedJobToEdit
        {
            get { return _selectedJobToEdit; }
            set
            {
                _selectedJobToEdit = value;
                OnPropertyChanged();
            }
        }

        //public EventHandler<Praca> editJobHandler;
        //protected virtual void OnEditJobHandler(Praca e) // event i metoda podnosząca event
        //{
        //    editJobHandler?.Invoke(this, new Praca() { });

        //}
       //public Praca JobToEdit { get; set; }
        private void EditJobNewWin()// wlacza okno edycji zgloszonej pracy
        {
            EditJobViev EJVWin = new EditJobViev();
            if (EJVWin.Focusable)
            {
                tabelaZgl();
            }
           
           // JobToEdit = new Praca();
           // EditJobViewModel temp = new EditJobViewModel();
           // JobToEdit = _zgloszenie.Praca.Where(p => p.PracaId == _selectedJobToEdit).Single();

            // OnEditJobHandler(JobToEdit);//podnoszenie eventu i przekazywanie obiektu praca do edycji

            //EJVWin.

            //EJVWin.DataContext = JobToEdit;
            //EJVWin.EditingJob.ItemsSource= JobToEdit.ToString();
            EJVWin.ShowDialog();

        }

        private void PriceListWin()
        {
            PriceListView PLW = new PriceListView();
            PLW.ShowDialog();
        }
        private bool CanAddPriceListWindow()
        { return true; }

        private bool CanAddOperatWindow()
        {
            return true;
        }
        private void OperatNewWindow()
        {
            OperatView OW = new OperatView();
            OW.ShowDialog();
        }

        public CommandHandlerAsync numerPracy { get; }
        public CommandHandler AddJobWindow { get; }
        public CommandHandler EditJob { get; }
        public CommandHandler AddPriceList { get; }
        public CommandHandler AddOperatWindow { get;}


    }
}
