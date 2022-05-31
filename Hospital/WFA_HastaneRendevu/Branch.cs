using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Branch
    {
        public string Name { get; set; }
        public List<Doctor> DoctorList { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
