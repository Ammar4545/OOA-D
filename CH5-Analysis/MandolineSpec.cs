using CH5.GoodDesgin;
using CH5.GoodDesgin.Helper;
using CH5.GoodDesgin.Hepler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CH5_Analysis
{
    public class MandolineSpec:InstrumentSpec
    {
        public Style style { get; }

        public MandolineSpec(Builder builder, string model, Typee type, Wood backWood, Wood topWood, Style style) :
            base(builder, model, type, backWood, topWood)
        {
            this.style = style;
        }
        public override bool Matches(InstrumentSpec otherSpec)
        {
            //string builder = searchSpec.Builder;
            if (!base.Matches(otherSpec))
            { return false; }

            if (!(otherSpec is MandolineSpec))
            { return false; }

            MandolineSpec spec= (MandolineSpec)otherSpec;
            if (!style.Equals(spec.style))
            { return false; }

            return true;
        }
    }
}
