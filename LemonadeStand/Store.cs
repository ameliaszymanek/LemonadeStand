using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables (HAS A)
        private double pricePerCup;
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        public List<string> ItemsAtStore;

        //constructor (BUILD)
        public Store()
        {
            ItemsAtStore = new List<string>() { "cups", "lemons", "sugar", "ice cubes" };
            pricePerCup = .15;
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            

        }

        //member methods (CAN DO)
        //sell items??
    }
}
