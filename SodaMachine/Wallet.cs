using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //variables
        public List<Coin> coins;
        public Card card;


        //constructor
        public Wallet()
        {
            coins = new List<Coin>();
            Coin Penny = new Coin();
            Coin Nickle = new Coin();
            Coin Dime = new Coin();
            Coin Quarter = new Coin();
            coins.Add(Penny);
            coins.Add(Nickle);
            coins.Add(Dime);
            coins.Add(Quarter);
        }

        //methods
    }
}
