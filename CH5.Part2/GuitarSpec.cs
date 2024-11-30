using CH5.Part2.Helper;
using CH5.Part2.Hepler;
using CH5_Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.Part2
{
    public class GuitarSpec : InstrumentSpec
    {
      
        public int NumStrings { get; private set; }
  
        public GuitarSpec( Builder builder, string model, Typee type, Wood backWood, Wood topWood, int numStrings):
            base( builder,  model,  type,  backWood, topWood)
        {
            this.NumStrings = numStrings;
        }
        public override bool Matches(InstrumentSpec otherSpec)
        {
            //string builder = searchSpec.Builder;
            if (!base.Matches(otherSpec))
            { return false; }

            if (!(otherSpec is GuitarSpec))
            { return false; }

            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (NumStrings !=spec.NumStrings)
            {
                return false;
            }

            return true;
        }
    }
}
