using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class ChipCoinMachine
    {
        //ATTRIBUTES
        private string message;
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public ChipCoinMachine(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)  //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ChipCoin.";
        }

        public void PrintChipCoin()
        {
            message = "Thank you, enjoy your stay.";
            ChipCoins.AddChipCoin();
            carPark.ChipCoinDispensed();
        }

        public void ClearMessage()
        {
            message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
