using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class Sensor
    {
        //ATTRIBUTES
        protected bool CarOnSensor;
        protected CarPark carPark;

        // CONSTRUCTORS
        public Sensor()
        {
            CarOnSensor = false;
        }

        // OPERATIONS
        public bool IsCarOnSensor()
        {
            return CarOnSensor;
        }

        public virtual void CarDetected()
        {
            this.CarOnSensor = true;
        }

        public virtual void CarLeftSensor()
        {
            this.CarOnSensor = false;
        }
    }
}
