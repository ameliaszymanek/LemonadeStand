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

        public void RunDay()
        {
            PlayerMenu();
            //view inventory (day 1 everything is at 0)
            //ask if player wants to purchase items at store
            //purchase items at store
            //display weather again to determine price
            //determine recipe
            //customers come
            //end of day recap display
            //next day...
        }

        public void PlayerMenu()
        {
            Console.WriteLine("What would you like to do to prepare for your day?\nTo view your inventory type 'inventory'\nTo see how much money you have type 'wallet'\nTo purchase items for your lemonade stand type 'store'");
            string playerChoice = Console.ReadLine().ToLower();
            switch (playerChoice)
            {
                case "inventory";
                    //display inventory;
                case "wallet";
                    //display amount of money in wallet;
                case "store";
                    //purchase items;
            }

        }
    }
}
