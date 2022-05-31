using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BakiyeIslemi
{
    public class Atm
    {
        private decimal _bakiye;

        public decimal Bakiye
        {
            get { return _bakiye; }
            set
            {
                if (value > 0)
                {
                    _bakiye = value;
                }
            }
        }


        private decimal _withdraw;

        public decimal Withdraw
        {
            get { return _withdraw; }
            set
            {
                if(value > 0 && value <= 100)
                {
                    _withdraw = value;
                }
            }
        }

        private decimal _deposit;

        public decimal Deposit
        {
            get { return _deposit; }
            set
            {
                if(value > 0 && value <= 100)
                {
                    _deposit = value;
                }
            }
        }
    }
}
