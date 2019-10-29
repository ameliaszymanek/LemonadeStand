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
        public Wallet wallet;
        //public Inventory inventory;
        //public Recipe recipe;
        //public Pitcher pitcher;

        //constructor (BUILD)
        public Player()
        {
            wallet = new Wallet();

        }

        //member methods (CAN DO)
        public abstract void ChooseName();
        public abstract void PurchaseItems();

        public void ViewInv()
        {
            //logic to display inv
        }

        //AddItemsToInv();???
        public abstract void DetermineRecipe();


   


    }
}
