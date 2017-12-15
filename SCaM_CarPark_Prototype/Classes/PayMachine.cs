using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCaM_CarPark_Prototype.Classes
{
    class PayMachine
    {
        //ATTRIBUTES
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public PayMachine(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }

        //OPERATIONS
        public void AssignCarPark(CarPark carPark)  //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void PayForChipCoin(int ChipCoinCode)
        {
            if (ChipCoins.GetChipCoins().Count() > 0)
            {
                //Checks every active ChipCoin
                foreach (ChipCoin ChipCoin in ChipCoins.GetChipCoins())
                {
                    //Checks if the Hashcodes match.
                    if (ChipCoinCode == ChipCoin.GetHashCode())
                    {
                        //Removes that ChipCoin from the list
                        MessageBoxManager.OK = "Cash"; MessageBoxManager.Cancel = "Card"; MessageBoxManager.Register();

                        //ask to select a payment, if cash is pressed set paid to true
                        if (MessageBox.Show("Please select payment method. \n\nCard payments will be processed at the barrier.", "Payment type", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            ChipCoin.SetPaid(true);

                        }
                        MessageBoxManager.Unregister();
                        break;
                    }
                }
            }
        }
    }
}
