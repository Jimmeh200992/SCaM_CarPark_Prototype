using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class CarPark
    {
        //ATTRIBUTES
        private int currentSpaces;
        private const int maxSpaces = 5;

        private ChipCoinMachine ChipCoinMachine;
        private ChipCoinValidator ChipCoinValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;

        //CONSTRUCTOR
        public CarPark(ChipCoinMachine ChipCoinMachine, ChipCoinValidator ChipCoinValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ChipCoinMachine = ChipCoinMachine;
            this.ChipCoinValidator = ChipCoinValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            currentSpaces = maxSpaces;
        }

        //OPERATIONS
        public void CarArrivedAtEntrance()
        {
            ChipCoinMachine.CarArrived();
        }

        public void ChipCoinDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarpark()
        {
            entryBarrier.Lower();
            ChipCoinMachine.ClearMessage();
            currentSpaces = currentSpaces - 1;      //A car takes up a parking space.
            fullSign.SetLit(IsFull());
        }

        public void CarArrivedAtExit()
        {
            ChipCoinValidator.CarArrived();
        }

        public void ChipCoinValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarpark()
        {
            exitBarrier.Lower();
            ChipCoinValidator.ClearMessage();
            currentSpaces = currentSpaces + 1;      //A parking space is now free.
            fullSign.SetLit(IsFull());
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
            {
                return true;
            }
            else
                return false;

        }

        public bool IsEmpty()
        {
            if (currentSpaces == maxSpaces)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSpace()
        {
            if (currentSpaces > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int getCurrentSpaces()
        {
            return currentSpaces;
        }
    }
}
