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

        public void Recognizer(Bark bark)
        {
            foreach (var allowedBark in door.allowedBark)
            {
                if (allowedBark.Equals(bark))
                {
                    Console.WriteLine($"BarkRecognizer: heard a {bark.GetSound()}");
                    door.Open();
                    return;
                }
                //else
                //{
                //    Console.WriteLine("This dog is not allowed ");
                //}
            }
            
            
        }
    }
}
