using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables (HAS A)
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        Random randomWeatherCondition;
        //private Random randomWeatherCondition;

        //constructor (BUILD)
        public Weather(Random rng)
        {
            randomWeatherCondition = rng;
            weatherConditions = new List<string>() { "sunny", "cloudy", "rainy" };
            DayTemperature();
            DayWeatherCondition();
          
        }

        //member methods (CAN DO)
        public void DayWeatherCondition()
        {
            int weatherConditionGenerator = randomWeatherCondition.Next(0, weatherConditions.Count);
            condition = weatherConditions[weatherConditionGenerator];
          

        }

        public void DayTemperature()
        {
            
            temperature = randomWeatherCondition.Next(50, 101);
         


        }

        


    }
}
