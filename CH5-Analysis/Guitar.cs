using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.GoodDesgin
{
    public class Guitar
    {
        public string SerialNumber { get; private set; }
        public double Price { get; private set; }
        public GuitarSpec GuitarSpec { get; private set; }
        
        public Guitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.GuitarSpec = guitarSpec;
        }
    }
}
