using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables (HAS A)
        public Weather weather;
        public Player player;
        public List<Day> DaysInOneWeek;
        public int currentDay;


        //constructor (BUILD)
        public Game()
        {
            DaysInOneWeek = new List<Day>();
        }

        //member methods (CAN DO)
        public void CreateDays()
        {
            Console.WriteLine("How many days");
            int result = int.Parse(Console.ReadLine());
            for (int i = 0; i < result; i++)
            {
                Day day = new Day();
                DaysInOneWeek.Add(day);
            }
        }
        public void RunGame()
        {
            //GameType(); can always put this in and create new method for different ways to play the game in the future
            CreatePlayer();
            DisplayInstructions();
            for (int i = 0; i < DaysInOneWeek.Count; i++)
            {
                Console.WriteLine("Day: " + (i+1) + DaysInOneWeek[i].weather.temperature + DaysInOneWeek[i].weather.condition);
                DaysInOneWeek[i].RunDay();
            }
           


        }



        /////////////////////

        //public void GameType()
        //{

        //}
        public void CreatePlayer()
        {
            player = new Human();
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Instructions:\nYour goal is to make as much money as you can in seven days by selling lemonade at your lemonade stand.\nYou will have an initial budget of $20.00 enabling you to purchase cups, lemons, sugar, and ice cubes.\nYou will be able to set your own recipe and price for a cup of lemonade.\nAfter you determine your plan you will be able to buy the inventory needed at the store.\nBe sure to keep the weather and conditions in mind when determining your recipe and the price per cup.\nYou will see how well your stand did at the end of each day.");
        }

        public void CycleDays()
        {

        }





    }
}
