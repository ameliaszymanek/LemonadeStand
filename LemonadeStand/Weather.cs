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
        private Random randomWeatherCondition;

        //constructor (BUILD)
        public Weather()
        {
            weatherConditions = new List<string>() {"sunny", "cloudy", "rainy"};
        }

        //member methods (CAN DO)
        public string DayWeatherCondition()
        {
            int weatherConditionGenerator = randomWeatherCondition.Next(0, weatherConditions.Count);
            condition = weatherConditions[weatherConditionGenerator];
            Console.WriteLine("Today's weather: " + condition);
            return condition;
        }

        public int DayTemperature()
        {
            Random random = new Random();
            int temperature = random.Next(50, 101);
            Console.WriteLine("Today's temperature: " + condition);
            return temperature;

        }

        public  DailyWeatherGenerator(int temperature, int weather)
        {
            DayTemperature();
            DayWeatherCondition();
            return Console.WriteLine("Today's temperature is " + temperature + "degrees Ferenheit with" + weather + "skies");
        }


    }
}
