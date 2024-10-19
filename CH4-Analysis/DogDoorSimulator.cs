using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    public class DogDoorSimulator
    {
        public static void DogDoorTestPath()
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("woof"));
            Remote remote = new Remote(door);
            BarkRecognizer barkRecognizer = new BarkRecognizer(door);
            
            Bark barkOfOurDog = new Bark("woof");
            Bark barkOfNeighborDog = new Bark("Yip");

            //simulate Bark Recognizer hard ware
            Console.WriteLine("Fido start barcking ...");
            barkRecognizer.Recognizer(barkOfOurDog);

            Console.WriteLine("Fido has gone outside...");
            Console.WriteLine("Fido’s all done...");

            //you see that door still open for 5s but fido take 6s now door is closed
            Thread.Sleep(6000);

            Console.WriteLine("yip stuck ouside");
            Console.WriteLine("yip barking ...");
            barkRecognizer.Recognizer(barkOfNeighborDog);
            Console.WriteLine($"is Door opend {door.IsOpen()}"); //no it is closed

            Console.WriteLine("Fido stuck ouside");
            Console.WriteLine("Fido barking ...");
            barkRecognizer.Recognizer(barkOfOurDog);
            Console.WriteLine($"is Door opend {door.IsOpen()}"); //yes it is opened

            Console.WriteLine("Gina use the remote contoll to open the door.");
            Console.WriteLine("Fido has back insid...");
        }
    }
}
