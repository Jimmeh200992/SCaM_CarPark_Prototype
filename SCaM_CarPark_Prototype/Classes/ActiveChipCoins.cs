using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCaM_CarPark_Prototype.Classes
{
    class ActiveChipCoins
    {
        //ATTRIBUTES
        private List<ChipCoin> chipCoin;       //List to hold all ChipCoins.

        //CONSTRUCTOR
        public ActiveChipCoins()
        {
            chipCoin = new List<ChipCoin>();      //Creates a new list.
        }

        //OPERATIONS
        public void AddChipCoin()
        {
            chipCoin.Add(new ChipCoin());          //Creates a new ChipCoin and adds to list.
        }

        public List<ChipCoin> GetChipCoins()
        {
            return chipCoin;                     //Returns the list.
        }

        public void RemoveChipCoin(int ChipCoinCode)
        {
            //Checks all ChipCoins currenty active.
            foreach (ChipCoin ChipCoin in chipCoin)
            {
                //Checks if the Hashcodes match.
                if (ChipCoinCode == ChipCoin.GetHashCode())
                {
                    //Removes that ChipCoin from the list
                    chipCoin.Remove(ChipCoin);
                    break;
                }
            }
        }
    }
}
