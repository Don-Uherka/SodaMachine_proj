using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //variables
        public Wallet wallet;
        public Backpack backpack;

        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
        }

        //methods
        public void DispenseCoins()
        {

        }
        //this method will be used to put the coins into the machine via user input the coins will have to be taken out of the wallet.
    }
}
