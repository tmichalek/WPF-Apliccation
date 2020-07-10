using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.ViewModel
{
    class BaseViewModel : INotifyPropertyChanged//, INotifyDataErrorInfo
    {

        private DbContext _context { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        
        

        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //protected Dictionary<string, List<string>> propErrors = new Dictionary<string, List<string>>();

        //public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        //protected virtual void OnErrorsChanged([CallerMemberName] String propertyName = "")
        //{
        //    if (ErrorsChanged != null)
        //        ErrorsChanged(this, new DataErrorsChangedEventArgs(propertyName));
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

        //private void DataValidation()
        //{
        //    //Validate Name property
        //    List<string> listErrors;
        //    if (propErrors.TryGetValue(Name, out listErrors) == false)
        //        listErrors = new List<string>();
        //    else
        //        listErrors.Clear();

        //    if (string.IsNullOrEmpty(Name))
        //        listErrors.Add("Name should not be empty!!!");
        //    else if (string.Equals(Name, "Srini"))
        //        listErrors.Add("Enter a different name!!!");
        //    propErrors["Name"] = listErrors;

        //    if (listErrors.Count > 0)
        //    {
        //        OnErrorsChanged();
        //    }
        //}
    }
}
