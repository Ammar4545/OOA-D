using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH4_Analysis
{
    //this class representing the owner's dog's bark then check if it is equal the bark object from Dougs hardware
    public class Bark
    {
        private string sound;
        public Bark(string sound)
        {
            this.sound=sound;
        }
        public string GetSound()
        {
            return sound;
        }
        public override bool Equals(object? bark)
        {
            if (bark is null || GetType() != bark.GetType())
            {
                return false;
            }

            Bark otherBark = (Bark)bark;
            return sound.Equals(otherBark.sound, StringComparison.OrdinalIgnoreCase);
        }
    }
}
