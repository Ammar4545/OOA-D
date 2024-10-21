using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    public class DogDoorSimulator
    {
        public static void DogDoorTestPath(bool ownerResponsive)
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("rowlf"));
            door.AddAllowedBark(new Bark("rooowlf"));
            door.AddAllowedBark(new Bark("rawlf"));
            door.AddAllowedBark(new Bark("woof"));
            Remote remote = new Remote(door);
            BarkRecognizer barkRecognizer = new BarkRecognizer(door);

            //flag
            bool isOwnerDog = true;
            Console.WriteLine("fido start barking ..rowlf rowlf");
            DoorOpenInitialization(ownerResponsive, isOwnerDog, remote, barkRecognizer);

            Console.WriteLine("fido all is done ...back to home");
            Thread.Sleep(6000);

            Console.WriteLine("our door is closed");

            bool firstBark=true;
            if (!door.IsOpen())
            {
                if (firstBark)
                {
                    //another dog bark
                    Console.WriteLine("fido stuck outside ...");
                    firstBark = false;

                    if (!ownerResponsive)
                    {
                        DoorOpenInitialization(ownerResponsive, !isOwnerDog, remote, barkRecognizer);
                        if (door.IsOpen())
                        {
                            Console.WriteLine("\nAnother dog besides Bruce has come inside! ...");
                        }
                        Console.WriteLine("\nThis dog is not allowed ...");
                    }

                    // fido barks
                    DoorOpenInitialization(ownerResponsive, isOwnerDog, remote, barkRecognizer);
                    if (door.IsOpen())
                    {
                        Console.WriteLine("\nBruce is back inside ...");
                    }
                }
            }
            

            ////simulate Bark Recognizer hard ware
            //Console.WriteLine("Fido start barcking ...");
            //barkRecognizer.Recognizer(barkOfOurDog);

            //Console.WriteLine("Fido has gone outside...");
            //Console.WriteLine("Fido’s all done...");

            ////you see that door still open for 5s but fido take 6s now door is closed
            //Thread.Sleep(6000);

            //Console.WriteLine("yip stuck ouside");
            //Console.WriteLine("yip barking ...");
            //barkRecognizer.Recognizer(barkOfNeighborDog);
            //Console.WriteLine($"is Door opend {door.IsOpen()}"); //no it is closed

            //Console.WriteLine("Fido stuck ouside");
            //Console.WriteLine("Fido barking ...");
            //barkRecognizer.Recognizer(barkOfOurDog);
            //Console.WriteLine($"is Door opend {door.IsOpen()}"); //yes it is opened

            //Console.WriteLine("Gina use the remote contoll to open the door.");
            //Console.WriteLine("Fido has back insid...");
        }

        private static void DoorOpenInitialization(bool ownerResponsive, bool isOwnersDoog, Remote remote, BarkRecognizer barkRecognizer)
        {
            if (ownerResponsive)
            {
                Console.WriteLine("use remote control to open the door");
                remote.PressButton();
            }
            else
            {
                if (isOwnersDoog)
                {
                    //when dog bark BarkRegonizer will indicates the sound

                    Console.WriteLine("fido start barking ...rowlf rowlf");
                    barkRecognizer.Recognizer(new Bark("rowlf"));
                }
                else
                {
                    Console.WriteLine("another doog start barking .... yip yip");
                    barkRecognizer.Recognizer(new Bark("yip"));
                }
            }
            
        }
    }
}
