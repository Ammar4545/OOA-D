using CH5_Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.Part2
{
    public class Guitar : Instrument

    {
        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec):base (serialNumber,price, guitarSpec)
        {
           
        }
    }
}
