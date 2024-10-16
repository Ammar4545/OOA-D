﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    public class Remote
    {
        private DogDoor door;
        public Remote(DogDoor door)
        {
            this.door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote contorl bittonn");

            if (door.IsOpen())
            {
                door.Close();
            }

            else
            {
                door.Open();
            }


        }

    }
}
