using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables (HAS A)
        public Random random;

        //constructor (BUILD)
        public Customer(Random random)
        {
            this.random = random;
        }

        //member methods (CAN DO)

        //////SOLID//////I created the GenerateRandomNumber method keeping the Single Responsibility Principle in mind. Instead of nesting a new generate random number method within each if statment in the DecisionBasedOnWeather and DecisionBasedOnPrice methods, the GenerateRandomNumber method can be called. It can also be utilized anywhere. 
        private int GenerateRandomNumber(int min, int max)
        {
            int randomGeneratedNumber = random.Next(min, max);
            return randomGeneratedNumber;
        }
        private int DecisionBasedOnWeather(Weather weather)
        {
            if (weather.temperature > 70 && weather.condition == "sunny")
            {
                return GenerateRandomNumber(40, 100);
            }
            else if (weather.temperature < 70 && weather.condition == "sunny")
            {
                return GenerateRandomNumber(45, 100);
            }
            else if (weather.temperature > 70 && weather.condition == "cloudy")
            {
                return GenerateRandomNumber(30, 100);
            }
            else if (weather.temperature < 70 && weather.condition == "cloudy")
            {
                return GenerateRandomNumber(40, 100);
            }
            else if (weather.temperature >= 90 && weather.condition == "rainy")
            {
                return GenerateRandomNumber(20, 100);
            }
            else 
            {
                return GenerateRandomNumber(0, 0);
            }  
        }

        private int DecisionBasedOnPrice(Player player)
        {
            if (player.recipe.pricePerCup < .25)
            {
                return GenerateRandomNumber(47, 100);
            }
            else if (player.recipe.pricePerCup < .50)
            {
                return GenerateRandomNumber(30, 100);
            }
            else if (player.recipe.pricePerCup < .75)
            {
                return GenerateRandomNumber(20, 100);
            }
            else if (player.recipe.pricePerCup < 1.00)
            {
                return GenerateRandomNumber(10, 100);
            }
            else
            {
                return GenerateRandomNumber(0, 0);
            }
        }

        public void MakeDecision(Weather weather, Player player)
        {
            if (DecisionBasedOnWeather(weather) > 50 && DecisionBasedOnPrice(player) > 50)
            {
                player.pitcher.PourCup(player);
                PayForCupOfLem(player);
                Console.WriteLine("Cup sold!");
            }
            else
            {
                NotBuying(player);
                Console.WriteLine("No thanks!");
            }
        }

        public void PayForCupOfLem(Player player)
        {
            player.wallet.Money += player.recipe.pricePerCup;
        }

        public void NotBuying(Player player)
        {
            player.wallet.Money += 0;
        }

        



    }      
}
