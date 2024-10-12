namespace DogDoorUseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside for 6s");
            remote.PressButton();


            Console.WriteLine("Fido has gone outside...");

            Console.WriteLine("Fido’s all done...");

            //you see that door still open for 5s but fido take 6s now door is closed
            Thread.Sleep(6000);

            Console.WriteLine("Fido stuck ouside");
            Console.WriteLine("Fido barking ...");
            var opened = door.IsOpen(); //false
            Console.WriteLine($"is Door opend {opened}");
            Console.WriteLine("Gina use the remote contoll to open the door.");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
        }
    }
}
