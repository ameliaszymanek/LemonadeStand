﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables (HAS A)
        public int lemonsInInv;
        public int sugarCubesInInv;
        public int cupsInInv;
        public int iceCubesInInv;
        //constructor (BUILD)
        public Inventory()
        {
            lemonsInInv = 0;
            sugarCubesInInv = 0;
            cupsInInv = 0;
            iceCubesInInv = 0;
        }

        //member methods (CAN DO)
        public void DisplayInventory()
        {
            Console.WriteLine("You have " + lemonsInInv + " lemons");
            Console.WriteLine("You have " + sugarCubesInInv + " sugar cubes");
            Console.WriteLine("You have " + cupsInInv + " cups");
            Console.WriteLine("You have " + iceCubesInInv + " ice cubes");
        }

    }
}
