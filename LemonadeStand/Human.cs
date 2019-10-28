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


        //constructor (BUILD)


        //member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public override void PurchaseItems()
        {
            //logic to purchase items
        }

        public override void DetermineRecipe()
        {
            //logic to determind recipe
        }

    }
}
