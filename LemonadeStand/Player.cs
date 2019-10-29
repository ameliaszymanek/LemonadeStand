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
        public Store store;

        //constructor (BUILD)
        public Player()
        {
            wallet = new Wallet();
            ChooseName();
            PurchaseItems();

        }

        //member methods (CAN DO)
        public void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public void PurchaseItems()
        {
            store.SellItems();
        }

        public void DetermineRecipe()
        {
            //logic to determine recipe
        }

        

   


    }
}
