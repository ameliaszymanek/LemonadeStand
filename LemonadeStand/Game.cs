﻿using System;
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
        public abstract void ChooseName();
    }
}
