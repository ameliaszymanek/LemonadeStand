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
        //public List<Customer> customers;

        //constructor (BUILD)
        public Day()
        {
            weather = new Weather();
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

        public void RunDay(Player player)
        {
            PlayerMenu(player);
           
            //display weather again to determine price
            //determine recipe
            //customers come
            //end of day recap display
            //next day...
        }

        public void PlayerMenu(Player player)
        {
            Console.WriteLine("What would you like to do to prepare for your day?\nTo view your inventory type 'inventory'\nTo see how much money you have type 'wallet'\nTo purchase items for your lemonade stand type 'store'\nTo move on type 'move on'");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "inventory":
                    player.inventory.DisplayInventory();
                    PlayerMenu(player);
                    break;
                case "wallet":
                    player.wallet.displayMoneyInWallet();
                    PlayerMenu(player);
                    break;
                case "store":
                    player.PurchaseItems();
                    PlayerMenu(player);
                    break;
                case "move on":
                    break;
            }

        }
    }
}
