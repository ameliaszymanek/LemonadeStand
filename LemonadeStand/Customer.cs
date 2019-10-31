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

        private int GenerateRandomNumber(int min, int max)
        {
            int randomGeneratedNumber = random.Next(min, max);
                return randomGeneratedNumber;   
        }


        private void DecisionBasedOnWeather(Weather weather)
        {
            if (weather.temperature > 70 & weather.condition == "sunny")
            {
                GenerateRandomNumber(40, 100);
            }
            else if (weather.temperature < 70 & weather.condition == "sunny")
            {
                GenerateRandomNumber(45, 100);
            }
            else if (weather.temperature > 70 & weather.condition == "cloudy")
            {
                GenerateRandomNumber(30, 100);
            }
            else if (weather.temperature < 70 & weather.condition == "cloudy")
            {
                GenerateRandomNumber(40, 100);
            }
            else if (weather.temperature >= 90 & weather.condition == "rainy")
            {
                GenerateRandomNumber(20, 100);
            }
            else if (weather.temperature < 90 & weather.condition == "rainy")
            {
                GenerateRandomNumber(0, 0);
            }
        }

        private void DecisionBasedOnPrice()
        {
            if ()
        }

        public void MakeDecision()
        {
            //if result of DBoW is greater than 50
            //if result of DBoP is greater than 50
        }



    }      
}
