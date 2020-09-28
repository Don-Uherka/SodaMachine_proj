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
            Coin Nickle = new Coin();
            Coin Dime = new Coin();
            Coin Quarter = new Coin();
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }
            for (int i = 0; i < 10; i++)
            {
                coins.Add(Nickle);
            }
            for (int i = 0; i < 20; i++)
            {
                coins.Add(Dime);
            }
            for (int i = 0; i < 8; i++)
            {
                coins.Add(Quarter);
            }
            
            
           
        }

        //methods
    }
}
