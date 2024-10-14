using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3_Requirements_Change
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
            open = true;
            Console.WriteLine("The dog door opens");
        }
        public void Close()
        {
            open = false;
            Console.WriteLine("The dog door closes");
        }
        public bool IsOpen() => this.open;
    }
}
