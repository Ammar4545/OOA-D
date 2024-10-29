using CH5.GoodDesgin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5_Analysis
{
    public class Mandoline : Instrument
    {
        public Mandoline(string serialNumber,double price, MandolineSpec spec):base(serialNumber, price, spec)
        {
            
        }
    }
}
