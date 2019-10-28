using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        //member variables (HAS A)
        public Store store;

        //constructor (BUILD)
        public Human()
        {
            ChooseName();
            PurchaseItems();
        }

        //member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public override void PurchaseItems()
        {
            Console.WriteLine("What do you need to buy?");
            string ItemsAtStore = Console.ReadLine().ToLower();
            switch (ItemsAtStore)
            {
                case "cups"
                    Console.WriteLine("How many cups do you need?");

                {

                }

            }


        }

        public override void DetermineRecipe()
        {
            //logic to determind recipe
        }

    }
}
