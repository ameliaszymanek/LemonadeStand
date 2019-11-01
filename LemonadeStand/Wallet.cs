using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        //member variables (HAS A)
        public double money;
        public double Money;
        public double investedMoney;

        //constructor (BUILD)
        public Wallet()
        {
            money = 20.00;
            investedMoney = 0;
            Money = 0;
        }

        //member methods (CAN DO)
        public void displayMoneyInWallet()
        {
            Console.WriteLine("You have $" + money);
        }


    }
}
