using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class Barrier
    {
        //ATTRIBUTES;
        private bool lifted;

        //CONSTRUCTORS;
        public Barrier()
        {
            lifted = false;
        }

        //OPERATIONS;
        public void Lower()
        {
            lifted = false;
        }
        public void Raise()
        {
            lifted = true;
        }
        public bool IsLifted()
        {
            return lifted;
        }
    }
}
