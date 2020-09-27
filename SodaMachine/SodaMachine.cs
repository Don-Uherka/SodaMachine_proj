using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //variables
        public List<Coin> register;
        public List<Can> inventory;

        //constructor
        public SodaMachine()
        {
            inventory = new List<Can>();
            Can Cola = new Can();
            Can RootBeer = new Can();
            Can OrangeSoda = new Can();
            for (int i = 0; i < 20; i++)
            {
                inventory.Add(Cola);
                inventory.Add(RootBeer);
                inventory.Add(OrangeSoda);
            }
          

            register = new List<Coin>();
            Coin Penny = new Coin();
            Coin Nickle = new Coin();
            Coin Dime = new Coin();
            Coin Quarter = new Coin();
            for (int i = 0; i < 50; i++)
            {
                register.Add(Penny);
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(Nickle);
            }
            for (int i = 0; i < 10; i++)
            {
                register.Add(Dime);
            }
            for (int i = 0; i < 20; i++)
            {
                register.Add(Quarter);
            }
            
        }

        //methods
        public void Purchase(string sodaSelection, List<Coin> payment)
        {
            //use string parameter to find the cost of that soda
            
        }

       
        public double DetermineCoinValue(List<Coin> coins)
        {
            double moneyPassedIn = 0;
            foreach (Coin coin in coins)
            {
                moneyPassedIn += coin.Value;
            }
            return moneyPassedIn;
            //we need a method that takes in a list of coins as a parameter and returns a double that represents the value of those coins
            //Foreach is the way to go!
            //if 'coins' is 2 quarters, we should return .5
            //if 'coins' is 1 penny and 1 dime, we should return .11

        }

    }
}
