﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables (HAS A)
        public int cupsLeftInPitcher;

        //constructor (BUILD)
        public Pitcher()
        {
            cupsLeftInPitcher = 15;
        }

        //member methods (CAN DO)
        public void PourCup(Player player)
        {
            if (cupsLeftInPitcher > 0)
            {
                cupsLeftInPitcher--;
                player.inventory.cupsInInv--;
            }
            else if (cupsLeftInPitcher == 0)
            {
                player.MakePitcher();
            }
        }



    }
}
