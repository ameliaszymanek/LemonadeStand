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
        private Player player;
        private List<int> DaysInOneWeek;
        private int currentDay;


        //constructor (BUILD)
        public Game()
        {
            DaysInOneWeek = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        }

        //member methods (CAN DO)
        public void RunGame()
        {
            //GameType(); can always put this in and create new method for different ways to play the game in the future
            CreatePlayer();
            DisplayInstructions();
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

    }
}
