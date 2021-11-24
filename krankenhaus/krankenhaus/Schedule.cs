using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krankenhaus
{
    class Schedule : Employee
    {
        public Schedule(string name, string surname,string PESEL,string PWZ)/* : base(string name, string surname, string PESEL, string PWZ)*/ {
            this.name = name;
            this.surname = surname;
            this.PESEL = PESEL;
            this.PWZ = PWZ;
        }
    }
}
