using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock
{
    public class GuitarSpec
    {
        
        public string Builder { get; private set; }
        public string Model { get; private set; }
        public string Type { get; private set; }
        public string BackWood { get; private set; }
        public string TopWood { get; private set; }
  
        public GuitarSpec( string builder, string model, string type, string backWood, string topWood)
        {
           
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
        }
    }
}
