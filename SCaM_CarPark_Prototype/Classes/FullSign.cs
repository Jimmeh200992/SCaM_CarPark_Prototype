﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class FullSign
    {
        //ATTRIBUTES
        private bool lit;

        // CONSTRUCTORS
        public FullSign()
        {
            lit = false;
        }

        //OPERATIONS
        public bool IsLit()
        {
            return lit;
        }

        public void SetLit(bool lit)
        {
            this.lit = lit;
        }
    }
}
