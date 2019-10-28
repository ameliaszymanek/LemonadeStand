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

        //constructor (BUILD)
        public Weather()
        {
            weatherConditions = new List<string>() {"sunny", "cloudy", "rainy"};
        }

        //member methods (CAN DO)


    }
}
