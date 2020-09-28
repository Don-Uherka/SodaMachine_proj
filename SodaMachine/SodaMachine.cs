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
            for (int i = 0; i < 20; i++)
            {
                Can Cola = new Can();
                Can RootBeer = new Can();
                Can OrangeSoda = new Can();
                inventory.Add(Cola);
                inventory.Add(RootBeer);
                inventory.Add(OrangeSoda);
            }
            register = new List<Coin>();
            for (int i = 0; i < 50; i++)
            {
                Coin Penny = new Coin();
                register.Add(Penny);
            }
            for (int i = 0; i < 20; i++)
            {
                Coin Nickle = new Coin();
                register.Add(Nickle);
            }
            for (int i = 0; i < 10; i++)
            {
                Coin Dime = new Coin();
                register.Add(Dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Coin Quarter = new Coin();
                register.Add(Quarter);
            }
            
        }

        //methods
        public bool EnoughMoneyForPurchase(double moneyCustomerPaid, Can canselected)
        {
            if (moneyCustomerPaid > canselected.Cost)
            {
                return true;
            }
            return false;
        }
        public void ReturnMoneyToCustomer(List<Coin> coinsGivenByCustomer, Customer customer)
        {
            customer.wallet.coins.AddRange(coinsGivenByCustomer);
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
