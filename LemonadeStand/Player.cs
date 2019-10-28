using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Player
    {
        //member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        //constructor (BUILD)


        //member methods (CAN DO)
        public abstract void ChooseName();
        public abstract void PurchaseItems();
        public abstract void DetermineRecipe();


   


    }
}
