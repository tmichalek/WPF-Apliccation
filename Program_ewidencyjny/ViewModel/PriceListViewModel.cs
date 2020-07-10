using Microsoft.Win32;
using program_ewidencyjny.Model.Domain;
using program_ewidencyjny.Others;
using program_ewidencyjny.View;
using program_ewidencyjny.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace program_ewidencyjny.ViewModel
{
    class PriceListViewModel :BaseJobViewModel
    {
        public PriceListViewModel()
        {
             ID = (JobToViewAndEdit)App.Current.Windows.OfType<JobView>().First().ViewJobGrid.SelectedItem;
            
            SetpriceList();
            setK();
            setCl();
            selectedK = 2;
            selectedCl = 1;
            setSend();
            setSu();
            AddPriceListToDataBase = new CommandHandler(AddPriceListToJob, CanAddPriceList);
            SavingDOO = new CommandHandler(SaveDOO, CanSaveDOO);
            ShowListPrice();
            SetNumberOfDOO();
        }

        private Kosztorys PriceListToJob;

        JobToViewAndEdit ID;
        private List<Cennik> _priceList { get; set; } //wczytanie danych z tabeli cennik to wystawienia DOO
        public List<Cennik> priceList
        {
            get { return _priceList; }
            set { _priceList = value; }
        }

        private List<KWspol> _priceListK { get; set; }
        public List<KWspol> priceListK
        {
            get { return _priceListK; }
            set { _priceListK = value;
                OnPropertyChanged();

            } }

        private List<AjWspol> _priceListAj { get; set; }
        public List<AjWspol> priceListAj
        {
            get { return _priceListAj; }
            set
            {
                _priceListAj = value;
                OnPropertyChanged();
            }
        }
        private List<ClWspol> _priceListCl { get; set; }
        public List<ClWspol> priceListCl
        { get
            { return _priceListCl; }
            set { _priceListCl = value;
                OnPropertyChanged();
            } }

        private List<PdWspol> _priceListPd { get; set; }
        public List<PdWspol> priceListPd
        { get { return _priceListPd; }
            set { _priceListPd = value;
                OnPropertyChanged();
            }
        }
        private List<SuWspol> _priceListSu { get; set; }
        public List<SuWspol> priceListSu
        { get { return _priceListSu; }
            set { _priceListSu = value;
                OnPropertyChanged();
            } }
        private TWspol _priceListT { get; set; }
        public TWspol priceListT
        {
            get { return _priceListT; }
            set { _priceListT = value;
                OnPropertyChanged();
            }
        }


        private double _selectedValueWspol { get; set; }// wybór kosztorysu z listy
        public double selectedValueWspol
        {
            get { return _selectedValueWspol; }
            set
            {
                _selectedValueWspol = value;
                OnPropertyChanged();
                setAj();
                setPd();
                
            }
        }

        private List<Wysylka> _priceListSend { get; set; }// lista zawierająca dane ceny wysyłki
        public List<Wysylka> priceListSend
        {
            get { return _priceListSend; }
            set { _priceListSend = value;
                OnPropertyChanged();
            }
        }

        private List<Kosztorys> _addedToDataBase { get; set; }// dane pokazujące kosztorys po dodaniu do bazy
        public List<Kosztorys> addedToDataBase
        {
            get { return _addedToDataBase; }
            set { _addedToDataBase = value;
                OnPropertyChanged();
            }
        }

        private double _sumPrice { get; set; }
        public double sumPrice
        {
            get { return _sumPrice; }
            set { _sumPrice = value;
                OnPropertyChanged();
            }
        }

        private void ShowListPrice()// wczytuje z bazy zapisane dane kosztorysu
        {
            addedToDataBase = new List<Kosztorys>();
            addedToDataBase = (from k in _zgloszenie.Kosztorys where k.PracaId == ID.PracaId select k).ToList();
            // _zgloszenie.Kosztorys.Where(z => z.KosztorysId == ID.PracaId).ToList();
            sumPrice = addedToDataBase.Sum(p => p.Brutto) + sendPrice;
        }

        private void SetpriceList() // wczytanie cen wysyłki
        {
            priceList = new List<Cennik>();
            priceList = (from a in _zgloszenie.Cennik select a).ToList();

           

        }
       
       
        void setAj()// wczytanie wspólczynnika Aj w zaleznisci od kosztorysu
        {
            priceListAj = new List<AjWspol>(); 
            priceListAj = (from a in _zgloszenie.AjWspol where a.NrTabeli == selectedValueWspol select a).ToList();
        }
        void setK() // wczytanie wspólczynnika K w zaleznisci od kosztorysu
        {
            priceListK = new List<KWspol>();
            priceListK = ((from k in _zgloszenie.Kwspol select k).ToList());
        }
        void setCl()
        {
            priceListCl = new List<ClWspol>();
            priceListCl = (from c in _zgloszenie.ClWspol select c).ToList();
        }
        void setPd() // wczytanie wspólczynnika Pd w zaleznisci od kosztorysu
        {
            priceListPd = new List<PdWspol>();
            priceListPd = (from p in _zgloszenie.PdWspol where p.NrTabeli == selectedValueWspol select p).ToList();
            
        }

        void setSu()
        {
            priceListSu = new List<SuWspol>();
            priceListSu = (from s in _zgloszenie.SuWspol select s).ToList();
        }

        void setSend() // wczytanie z bazy kosztów wysyłki
        {
            priceListSend = new List<Wysylka>();
            priceListSend = (from s in _zgloszenie.Wysylka select s).ToList();
        }

        private int _selectedK { get; set; } // z góry ustawiona wartość K przy robotach geodezyjnych zawsze 0.5
        public int selectedK
        {
            get { return _selectedK; }
            set { _selectedK = value;
                OnPropertyChanged();
            }
        }
        private int _selectedCl { get; set; } // z góry ustwiona wartość Cl ( przy robotach geodezyjnych zawsze 1)
        public int selectedCl
        {
            get { return _selectedCl; }
            set { _selectedCl = value;
                OnPropertyChanged();
            }
        }

        private Wysylka _selectedSend { get; set; }
        public Wysylka selectedSend
        {
            get { return _selectedSend; }
            set
            {
                _selectedSend = value;
                OnPropertyChanged();
                if (_selectedSend != null)
                    sendPrice = selectedSend.Cena;
                else sendPrice = 0;
            }
        }
// ilość X cena X Aj X Pd X K
    private Int16 _quantity { get; set; }// pobiera ilość z cennika
        public Int16 quantity
        {
            get { return _quantity; }
            set { _quantity = value;
                OnPropertyChanged();
                countPrice();
            }
        }

    private double _price { get; set; } //odbiera cenę z cennika
        public double price
        {
            get { return _price; }
            set { _price = value;
                OnPropertyChanged();
                countPrice();
            }
        }

        private int _AjPrice { get; set; }//odbiera wartość Aj do wymnozenia ceny
        public int AjPrice
        {
            get { return _AjPrice; }
            set { _AjPrice = value;
                OnPropertyChanged();
                countPrice();
            }
        }

        private PdWspol _selectedPd { get; set; } // odbiera Pd do cennika
        public PdWspol selectedPd
        {
            get { return _selectedPd; }
            set {
                _selectedPd = value;
                OnPropertyChanged();
                countPrice();
            }
        }

        private SuWspol _selectedSu { get; set; }
        public SuWspol selectedSu
        {
            get { return _selectedSu; }
            set
            {
                _selectedSu = value;
                OnPropertyChanged();
                countPrice();
            }
        }

        private double _KPrice { get; set; }
        public double KPrice
        {
            get { return _KPrice; }
            set
            {
                _KPrice = value;
                OnPropertyChanged();
                countPrice();
            }
        }

        private double _sendPrice { get; set; }
        public double sendPrice
        {
            get { return _sendPrice; }
            set
            {
                _sendPrice = value;
                OnPropertyChanged();
                ShowListPrice();
            }
        }

    private double _rowPrice { get; set; }//wyswietlana cena pojedynczego wiersza
        public double rowPrice
        {
            get { return _rowPrice; }
            set { _rowPrice = value;
                OnPropertyChanged();
            }
        }

        private void countPrice()//oblicza cenę w pojedynczym wierszu
            {
            if ((_selectedAj != null) && (_selectedPd !=null) && (_selectedSu!=null))
                rowPrice = (_quantity * _price * _selectedAj.Aj*_selectedPd.Pd *_selectedSu.Su * 0.5);
            else
                rowPrice = 0;
            }
         

        private Cennik _priceListNumber { get; set; }//odbiera nr cennika i przekazuje do kosztorysu
        public Cennik priceListNumber
        {
            get { return _priceListNumber; }
            set { _priceListNumber = value;
                OnPropertyChanged();
                
            } }

        private string _priceListName { get; set; }//odbiera nazwe cennik ai przekazuje do kosztorysu
        public string priceListName
        {
            get { return _priceListName; }
            set { _priceListName = value;
                OnPropertyChanged();
            }
        }

        private AjWspol _selectedAj { get; set; }// wspolczynnik Aj przekazywany do kosztorysu
        public AjWspol selectedAj
        {
            get { return _selectedAj; }
            set {
                _selectedAj = value;
                OnPropertyChanged();
                
            }
        }


        private void AddPriceListToJob()//dodanie kosztorysu
        {
            PriceListToJob = new Kosztorys()
            {
                NrCennika = _priceListNumber.NrCennika,
                Pozycja = selectedValueWspol,
                Nazwa = _priceListName,
                Ilosc = _quantity,
                Cena = price,
                Wspolczynnik = 1,
                Vat = 0,
                Brutto = rowPrice,
                KId = selectedK,
                ClId = selectedCl,
                SuId =selectedSu.SuId,
                PdId = selectedPd.PdId,
                AjId = selectedAj.AjId,
                TId =0,
                CennikId =_priceListNumber.CennikId,
                PracaId = ID.PracaId,
                WysylkaId = selectedSend.WysylkaId,
                Numer= _numberOfDoo,
                Rok=DateTime.Today.Year,

            };

            try
            {
                _zgloszenie.Kosztorys.Add(PriceListToJob);
                _zgloszenie.SaveChanges();
                ShowListPrice();
                //PriceListView win = App.Current.Windows.OfType<PriceListView>().First();
                //win.Close();
                //var ctentites=_zgloszenie.ChangeTracker.Entries();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private bool CanAddPriceList()
        {
            return true;
        }

       

        private int _numberOfDoo;
        private void SetNumberOfDOO()
        {
           
            int currentNumberInDatabase = (from n in _zgloszenie
                                             .Kosztorys
                                             .OrderByDescending(n => n.Rok).ThenByDescending(n => n.Numer)
                                           select n.Numer)
                                             .First();
            int currentYearInDatabase = (from n in _zgloszenie
                                              .Kosztorys
                                              .OrderByDescending(n =>n.Rok)
                                         select n.Rok)
                                             .First();
            int currentId = (from i in _zgloszenie
                                               .Kosztorys
                                               .OrderByDescending(n => n.Rok).ThenByDescending(n => n.Numer)
                             select i.PracaId)
                                             .First();
           

            if ( (DateTime.Now.Year) - (currentYearInDatabase) == 0)
            {
                if(currentId==ID.PracaId)
                    _numberOfDoo = currentNumberInDatabase;
                else
                currentNumberInDatabase++;
                _numberOfDoo = currentNumberInDatabase;
            }
            else
                _numberOfDoo = 1;

        }

        private void SaveDOO()
        {
            SaveFileDialog SaveDOO = new SaveFileDialog();
            
            SaveDOO.ShowDialog();
            //if (SaveDOO.ShowDialog() == true)
            //{
            //    using (StreamWriter sw = new StreamWriter(SaveDOO.FileName))
            //    {
            //        sw.WriteLine()
            //    }
            //    //File.WriteAllLines()
            //}


        }
        private bool CanSaveDOO()
        {
            return true;
        }

        public CommandHandler AddPriceListToDataBase { get; }//polecenie dodawanie cennika do bazy
        public CommandHandler SavingDOO { get; }// polecenie zapisu DOO
    }
}
