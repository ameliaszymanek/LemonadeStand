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
            pricePerCup = .05;
            pricePerLemon = .25;
            pricePerSugarCube = .10;
            pricePerIceCube = .02;
            this.player = player;
            
        }

      

        //member methods (CAN DO)
        public void SellItems()
        {
            Console.WriteLine("What would you like to buy? type 'cups'($0.05 each), 'lemons'($0.25 each), 'sugar'($0.10 each), or 'ice cubes'($0.02 each). If you are done shopping type 'done'.");
            string ItemsAtStore = Console.ReadLine().ToLower();
            switch(ItemsAtStore)
            {
                case "cups":
                    SellCups();
                    SellItems();
                    break;
                case "lemons":
                    SellLemons();
                    SellItems();
                    break;
                case "sugar":
                    SellSugar();
                    SellItems();
                    break;
                case "ice cubes":
                    SellIceCubes();
                    SellItems();
                    break;
                case "done":
                    break;
            }
        }

        public void SellCups()
        {
            Console.WriteLine("How many cups do you need?");
            int cups = int.Parse(Console.ReadLine().ToLower());
            double CostOfCups = pricePerCup * cups;
            player.wallet.money -= CostOfCups;
            player.inventory.cupsInInv += cups;
            player.wallet.investedMoney += CostOfCups;
        }

        public void SellLemons()
        {
            Console.WriteLine("How many lemons do you need?");
            try
            {
                int lemons = int.Parse(Console.ReadLine());
                double CostOfLemons = pricePerLemon * lemons;
                player.wallet.money -= CostOfLemons;
                player.inventory.lemonsInInv += lemons;
                player.wallet.investedMoney += CostOfLemons;
            }
            catch(FormatException)
            {
                Console.WriteLine("Not a number! Please enter a number.");
            }
        }

        public void SellSugar()
        {
            Console.WriteLine("How many sugar cubes do you need?");
            try
            {
                int sugarCubes = int.Parse(Console.ReadLine());
                double CostOfSugar = pricePerSugarCube * sugarCubes;
                player.wallet.money -= CostOfSugar;
                player.inventory.sugarCubesInInv += sugarCubes;
                player.wallet.investedMoney += CostOfSugar;
            }
            catch(FormatException)
            {
                Console.WriteLine("Not a number! Please enter a number.");
            }
            
        }

        public void SellIceCubes()
        {
            Console.WriteLine("How many ice cubes do you need?");
            try
            {
                int iceCubes = int.Parse(Console.ReadLine());
                double CostOfIceCubes = pricePerIceCube * iceCubes;
                player.wallet.money -= CostOfIceCubes;
                player.inventory.iceCubesInInv += iceCubes;
                player.wallet.investedMoney += CostOfIceCubes;
            }
            catch(FormatException)
            {
                Console.WriteLine("Not a number! Please enter a number.");
            }
            
        }

    }
}
