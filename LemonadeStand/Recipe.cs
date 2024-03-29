﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        //constructor (BUILD)
        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
        }

        //member methods (CAN DO)
        public string GetStringInput(string amount)
        {
            Console.WriteLine($"Enter {amount}");
            string input = Console.ReadLine().ToLower();
            return input;
        }
        public void CreateRecipe()
        {
            amountOfLemons = int.Parse(GetStringInput("amount of lemons"));
            amountOfSugarCubes = int.Parse(GetStringInput("amount of sugar cubes"));
            amountOfIceCubes = int.Parse(GetStringInput("amount of ice cubes"));
        }

        public void SetPrice()
        {
            Console.WriteLine("What would you like the price per cup of lemonade to be?");
            pricePerCup = Double.Parse(Console.ReadLine().ToLower());
        }

       
    }
}
