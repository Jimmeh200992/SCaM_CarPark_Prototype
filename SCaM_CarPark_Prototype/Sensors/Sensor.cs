using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype
{
    class Sensor
    {
        // variables
        public bool isCarOnSensor = false;

        // methods
        public bool checkSensor()
        {
            return isCarOnSensor;
        }
        public void carApproachesSensor()
        {
            isCarOnSensor = true;
        }
        public void carLeavesSensor()
        {
            isCarOnSensor = false;
        }
    }
}
