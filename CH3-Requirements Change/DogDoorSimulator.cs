﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3_Requirements_Change
{
    public class DogDoorSimulator
    {
        public static void DogDoorTestPath()
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            //var opened=false;
            Console.WriteLine("Fido barks to go outside for 6s");
            remote.PressButton();
           
            Console.WriteLine($"is Door opend {door.IsOpen()}");

            Console.WriteLine("Fido has gone outside...");

            Console.WriteLine("Fido’s all done...");

            //you see that door still open for 5s but fido take 6s now door is closed
            Thread.Sleep(6000);

            Console.WriteLine("Fido stuck ouside");
            Console.WriteLine("Fido barking ...");
            door.IsOpen(); //false
            Console.WriteLine($"is Door opend {door.IsOpen()}");
            Console.WriteLine("Gina use the remote contoll to open the door.");

            remote.PressButton();
            Console.WriteLine($"is Door opend {door.IsOpen()}");
            Console.WriteLine("Fido has back insid...");
        }
     }
}
