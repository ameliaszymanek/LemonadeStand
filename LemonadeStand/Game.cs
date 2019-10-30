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
        public Store store;
        public List<Day> DaysInOneWeek;
        public int currentDay;


        //constructor (BUILD)
        public Game()
        {
            DaysInOneWeek = new List<Day>();
            player = new Player();
            store = new Store(player);
        }

        //member methods (CAN DO)
        public void CreateDays()
        {
            Console.WriteLine("For how many days would you like to play?");
            int result = int.Parse(Console.ReadLine());
            Random rng = new Random();
            for (int i = 0; i < result; i++)
            {
                Day day = new Day(rng);
                DaysInOneWeek.Add(day);
            }
        }
        public void RunGame()
        {
            DisplayInstructions();
            player.recipe.CreateRecipe();
            CreateDays();
            for (int i = 0; i < DaysInOneWeek.Count; i++)
            {
                Console.WriteLine("Today's forecast is: " + DaysInOneWeek[i].weather.temperature + " and " + DaysInOneWeek[i].weather.condition);
                DaysInOneWeek[i].RunDay(player, store);
            }
           


        }


        public void CreatePlayer()
        {
            player = new Player();
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Instructions:\nYour goal is to make as much money as you can in seven days by selling lemonade at your lemonade stand.\nYou will have an initial budget of $20.00 enabling you to purchase cups, lemons, sugar, and ice cubes.\nYou will be able to set your own recipe and price for a cup of lemonade.\nAfter you determine your plan you will be able to buy the inventory needed at the store.\nBe sure to keep the weather and conditions in mind when determining your recipe and the price per cup.\nYou will see how well your stand did at the end of each day.");
        }

        





    }
}
