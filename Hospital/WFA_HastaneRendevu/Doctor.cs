using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_HastaneRendevu
{
    public class Doctor
    {
        public string Name { get; set; }
        public Branch Branch { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
