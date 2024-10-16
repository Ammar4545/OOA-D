using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    public class BarkRecognizer
    {
        private DogDoor door;
        public BarkRecognizer(DogDoor door)
        {
            this.door = door;
        }

        public void Recognizer(string bark)
        {
            Console.WriteLine($"BarkRecognizer: heard a {bark}");
            door.Open();
        }
    }
}
