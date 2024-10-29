using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5_Analysis
{
    public abstract class Instrument
    {
        internal string serialNumber { get; }
        internal double price { get; set; }
        public InstrumentSpec spec{get; set;}

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

    }
}
