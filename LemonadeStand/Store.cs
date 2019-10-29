﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables (HAS A)
        
        public Player player;
        private double pricePerCup;
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        public List<string> ItemsAtStore;

        //constructor (BUILD)
        public Store(Player player)
        {
            ItemsAtStore = new List<string>() { "cups", "lemons", "sugar", "ice cubes" };
            pricePerCup = .15;
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .05;
            
        }

      

        //member methods (CAN DO)
        public void SellItems()
        {
            Console.WriteLine("What would you like to buy? type 'cups', 'lemons', 'sugar', or 'ice cubes'.");
            string ItemsAtStore = Console.ReadLine().ToLower();
            switch(ItemsAtStore)
            {
                case "cups":
                    SellCups();
                    break;
                case "lemons":
                    SellLemons();
                    break;
                case "sugar":
                    SellSugar();
                    break;
                case "ice cubes":
                    SellIceCubes();
                    break;
            }
        }

        public void SellCups()
        {
            Console.WriteLine("How many cups do you need?");
            int cups = int.Parse(Console.ReadLine());
            double CostOfCups = pricePerCup * cups;
            player.wallet.money -= CostOfCups;
            //add to inventory
        }

        public void SellLemons()
        {
            Console.WriteLine("How many lemons do you need?");
            int lemons = int.Parse(Console.ReadLine());
            double CostOfLemons = pricePerLemon * lemons;
            player.wallet.money -= CostOfLemons;
        }

        public void SellSugar()
        {
            Console.WriteLine("How many sugar cubes do you need?");
            int sugarCubes = int.Parse(Console.ReadLine());
            double CostOfSugar = pricePerSugarCube * sugarCubes;
            player.wallet.money -= CostOfSugar;
        }

        public void SellIceCubes()
        {
            Console.WriteLine("How many ice cubes do you need?");
            int iceCubes = int.Parse(Console.ReadLine());
            double CostOfIceCubes = pricePerIceCube * iceCubes;
            player.wallet.money -= CostOfIceCubes;
        }






    }
}
