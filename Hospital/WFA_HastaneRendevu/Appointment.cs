using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Appointment
    {
        public string IdNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Time { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Branch Branch { get; set; }
    }
}
