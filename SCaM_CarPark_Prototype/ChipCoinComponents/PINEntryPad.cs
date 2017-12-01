using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype
{
    class PINEntryPad
    {
        public int PIN, newPIN;

        public int getPIN()
        {
            return PIN;
        }

        public void createPIN()
        {
            PIN = newPIN;
        }
    }
}
