using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock
{
    public class Guitar
    {
        public string serialNumber { get; private set; }
        public string builder { get; private set; }
        public string model { get; private set; }
        public string type { get; private set; }
        public string backWood { get; private set; }
        public string topWood { get; private set; }
        public double price { get; private set; }
        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }
    }
}
