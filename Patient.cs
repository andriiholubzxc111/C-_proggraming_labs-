using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Patient
    {
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Diagnosis { get; set; }
        public string DoctorLastName { get; set; }
        public string Department { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
    }

}
