using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorUseCase
{
    public class DogDoor 
    {
        private bool open;
        public DogDoor()
        { 
            this.open = false; 
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens");
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes");
        }
        public bool IsOpen() => this.open;
    }
}
