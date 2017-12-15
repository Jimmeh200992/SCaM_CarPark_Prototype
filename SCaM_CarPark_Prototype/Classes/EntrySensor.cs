using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class EntrySensor : Sensor
    {
        // ATTRIBUTES

        // CONSTRUCTORS
        public EntrySensor(CarPark carPark)
            : base()
        {
            this.carPark = carPark;
        }

        //OPERATIONS;
        public override void CarDetected()
        {
            CarOnSensor = true;
            carPark.CarArrivedAtEntrance();
        }

        public override void CarLeftSensor()
        {
            CarOnSensor = false;
            carPark.CarEnteredCarpark();
        }
    }
}
