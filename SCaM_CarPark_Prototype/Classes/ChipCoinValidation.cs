using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCaM_CarPark_Prototype.Classes
{
    class ChipCoinValidator
    {
        //ATTRIBUTES
        private string message;
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public ChipCoinValidator(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)   //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please insert your ChipCoin.";
        }

        public ChipCoinPaid ChipCoinEntered(int ChipCoinCode)
        {

            foreach (ChipCoin ChipCoin in ChipCoins.GetChipCoins())
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)
                {
                    if (ChipCoin.IsPaid() == true)
                    {
                        message = "Thank you, drive safely.";
                        ChipCoins.RemoveChipCoin(ChipCoinCode);
                        carPark.ChipCoinValidated();
                        return ChipCoinPaid.ChipCoin_REMOVED;
                    }
                    else
                    {
                        MessageBoxManager.OK = "Present card"; MessageBoxManager.Cancel = "Pay by cash"; MessageBoxManager.Register();
                        if (MessageBox.Show("Please pay by card.", "PayByCard", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            message = "Thank you, drive safely.";
                            ChipCoins.RemoveChipCoin(ChipCoinCode);
                            carPark.ChipCoinValidated();
                            return ChipCoinPaid.ChipCoin_REMOVED;
                        }

                        else
                            message = "ChipCoin has not been paid.";
                        return ChipCoinPaid.NOT_PAID;
                    }
                }
            }

            message = "Not Valid ChipCoin.";
            return ChipCoinPaid.NOT_VALID;

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

enum ChipCoinPaid
{
    ChipCoin_REMOVED,
    NOT_PAID,
    NOT_VALID
}