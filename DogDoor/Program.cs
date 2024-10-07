using System.ComponentModel;

namespace DogDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            remote.PressButton();
            Console.WriteLine("Fido’s all done...");
            remote.PressButton();
            Console.WriteLine("Fido’s back inside...");
            remote.PressButton();
        }
    }
}
