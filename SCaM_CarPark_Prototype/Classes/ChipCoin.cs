using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class ChipCoin
    {
        //ATTRIBUTES
        private bool paid;

        //CONSTRUCTORS
        public ChipCoin()
        {
            paid = false;
        }
        //FUNCTIONS
        public bool IsPaid()
        {
            return paid;
        }

        public void SetPaid(bool paid)
        {
            this.paid = paid;
        }
    }
}
