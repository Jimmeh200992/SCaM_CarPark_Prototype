using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class ExitSensor : Sensor
    {
        // ATTRIBUTES

        // CONSTRUCTORS
        public ExitSensor(CarPark carPark)
            : base()
        {
            this.carPark = carPark;
        }

        //OPERATIONS
        public override void CarDetected()
        {
            CarOnSensor = true;
            carPark.CarArrivedAtExit();
        }

        public override void CarLeftSensor()
        {
            CarOnSensor = false;
            carPark.CarExitedCarpark();
        }
    }
}
