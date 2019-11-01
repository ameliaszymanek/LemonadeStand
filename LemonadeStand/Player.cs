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
            pitcher = new Pitcher();
            

        }

        //member methods (CAN DO)
        public void ChooseName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public void MakePitcher()
        {
            if (inventory.lemonsInInv >= recipe.amountOfLemons  && inventory.sugarCubesInInv >= recipe.amountOfSugarCubes && inventory.iceCubesInInv >= recipe.amountOfIceCubes && inventory.cupsInInv > 0 )
            {
                inventory.lemonsInInv -= recipe.amountOfLemons;
                inventory.sugarCubesInInv -= recipe.amountOfSugarCubes;
                inventory.iceCubesInInv -= recipe.amountOfIceCubes;
                pitcher.cupsLeftInPitcher = 15;
            }
            else
            {
                Console.WriteLine("You do not have enough ingredients in your inventory to make a new pitcher.");
            }
        }

        








    }
}
