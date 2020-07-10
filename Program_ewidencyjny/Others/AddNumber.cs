using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_ewidencyjny.Others
{
    class AddNumber
    {
        int _number { get; set; }
        int _year { get; set; }
        int _id { get; set; }

        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        public int year
        {
            get { return _year; }
            set { _year = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
