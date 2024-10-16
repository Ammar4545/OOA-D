using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    public class DogDoor
    {
        private bool open;
        private Bark allowedBark { get; set; }
        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            open = true;
            Console.WriteLine("The dog door opens");
            Timer timer = new Timer(CloseDoor, null, 5000, Timeout.Infinite);
        }
        public void Close()
        {
            open = false;
            Console.WriteLine("The dog door closes");
        }
        public bool IsOpen() => this.open;
        private void CloseDoor(object state)
        {
            open = false;
        }
    }
}
