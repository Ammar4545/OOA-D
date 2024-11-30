using CH5.Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.Part2
{
    public class Mandoline : Instrument
    {
        public Mandoline(string serialNumber,double price, MandolineSpec spec):base(serialNumber, price, spec)
        {
            
        }
    }
}
