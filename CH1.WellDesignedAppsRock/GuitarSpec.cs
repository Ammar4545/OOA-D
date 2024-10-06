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
        public int NumStrings { get; private set; }
  
        public GuitarSpec( string builder, string model, string type, string backWood, string topWood, int numStrings)
        {
           
            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
            this.NumStrings = numStrings;
        }
        public Boolean Matches(GuitarSpec otherSpec)
        {
            //string builder = searchSpec.Builder;
            if (!string.IsNullOrEmpty(Builder) && !Builder.Equals(otherSpec.Builder))
            { return false; }

            if (!string.IsNullOrEmpty(Model) && !Model.Equals(otherSpec.Model.ToLower()))
            { return false; }

            if (!string.IsNullOrEmpty(Type) && !Type.Equals(otherSpec.Type))
            { return false; }

            if (!string.IsNullOrEmpty(BackWood) && !BackWood.Equals(otherSpec.BackWood))
            { return false; }

            if (!string.IsNullOrEmpty(TopWood) && !TopWood.Equals(otherSpec.TopWood))
            { return false; }

            return true;
        }
    }
}
