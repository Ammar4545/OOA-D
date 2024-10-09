namespace DogDoorUseCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.PressButton();
            Thread.Sleep(6000);

            Console.WriteLine("Fido has gone outside...");
          
            Console.WriteLine("Fido’s all done...");
         
            Console.WriteLine("Fido’s back inside...");

            var opened = door.IsOpen();
            Console.WriteLine(opened);
        }
    }
}
