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

        //member methods (CAN DO)
        public void DailyWeatherGenerator()
        {
            weather.DayTemperature();
            weather.DayWeatherCondition();
            Console.WriteLine("Today's temperature is " + weather.temperature + "degrees Ferenheit with" + weather.condition + "skies");
        }

    }
}
