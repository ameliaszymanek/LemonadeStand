using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables (HAS A)
        public string name;
        public Wallet wallet;
        public Inventory inventory;
        public Recipe recipe;
        public Pitcher pitcher;
        

        //constructor (BUILD)
        public Player()
        {
            ChooseName();
            wallet = new Wallet();
            inventory = new Inventory();
            recipe = new Recipe();
            

        }

        //member methods (CAN DO)
        public void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        

        






    }
}
