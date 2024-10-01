using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock
{
    public class Guitar
    {
        public string SerialNumber { get; private set; }
        public string Builder { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string BackWood { get; private set; }
        public string TopWood { get; private set; }
        public double Price { get; private set; }
        public Guitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }
    }
}
