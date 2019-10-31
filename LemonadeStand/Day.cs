using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables (HAS A)
        public Weather weather;
        public List<Customer> customers;

        //constructor (BUILD)
        public Day(Random random)
        {
            weather = new Weather(random);
            customers = new List<Customer>();
            NumOfCustomersForDay(random);

        }

        //member methods (CAN DO)
        public void ActualWeatherOnDay()
        {
            Console.WriteLine("Today's temperature is " + weather.temperature + "degrees Ferenheit with" + weather.condition + "skies");
            
        }

        public void PredictedForecastForDay()
        {
            //
        }

        public void PredictedForecastForWeek()
        {
            //
        }

        public void RunDay(Player player, Store store)
        {
            PlayerMenu(player, store);
            foreach (Customer customer in customers)
            {
                customer.MakeDecision(weather, player);
            }

            //end of day recap display- daily profit/loss, total profit/loss
            DisplayEndOfDayRecap(player);
            //MoveDayEarnings move Money to money in wallet

            //next day...
        }

        public void PlayerMenu(Player player, Store store)
        {
            Console.WriteLine("What would you like to do to prepare for your day?\nTo view your inventory type 'inventory'\nTo see how much money you have type 'wallet'\nTo purchase items for your lemonade stand type 'store'\nSet your price when you are ready to start selling\nTo set the price for a cup of lemonade type 'set price'\nWhen you are ready to open your lemonade stand type 'open'");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "inventory":
                    player.inventory.DisplayInventory();
                    PlayerMenu(player, store);
                    break;
                case "wallet":
                    player.wallet.displayMoneyInWallet();
                    PlayerMenu(player, store);
                    break;
                case "store":
                    store.SellItems();
                    PlayerMenu(player, store);
                    break;
                case "set price":
                    player.recipe.SetPrice();
                    PlayerMenu(player, store);
                    break;
                case "open":
                    break;
            }

        }

        private void NumOfCustomersForDay(Random random)
        {
            int randomGeneratedNumber = random.Next(50, 151);
            for (int i = 0; i < randomGeneratedNumber; i++)
            {
                customers.Add(new Customer(random));
            }
        }

        private void DisplayEndOfDayRecap(Player player)
        {
            Console.WriteLine("You started with $" + player.wallet.money + " today");
            Console.WriteLine("Today's profit= " + player.wallet.Money);
            Console.WriteLine("Total profit= " + (player.wallet.Money + player.wallet.money));
        }
    }
}
