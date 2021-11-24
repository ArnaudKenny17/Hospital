using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krankenhaus
{
    class Doctor : Schedule
    {
        public List<String> doctorList(Doctor Mynewdoctor)
        {
            List<String> doctoradd = new List<String>();
           doctoradd.Add(Mynewdoctor.NAME);
            string Name = Mynewdoctor.NAME;

            doctoradd.Add(Mynewdoctor.SURNAME);
            string Surname = Mynewdoctor.SURNAME;

            doctoradd.Add(Mynewdoctor.PESELNUMBER);
            string Peselnumber = Mynewdoctor.PESELNUMBER;


            return doctoradd;
        }
    }
}
