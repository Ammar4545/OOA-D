using CH5.GoodDesgin.Helper;
using CH5.GoodDesgin.Hepler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5_Analysis
{
    public abstract class InstrumentSpec
    {
        public Builder Builder { get; }
        public string Model { get; }
        public Typee Type { get;  }
        public Wood BackWood { get; }
        public Wood TopWood { get; }
       
            
        public InstrumentSpec(Builder builder, string model, Typee type, Wood backWood, Wood topWood)
        {

            this.Builder = builder;
            this.Model = model;
            this.Type = type;
            this.BackWood = backWood;
            this.TopWood = topWood;
           
        }
        public virtual bool Matches(InstrumentSpec otherSpec)
        {
            //string builder = searchSpec.Builder;
            if (!Builder.Equals(otherSpec.Builder))
            { return false; }

            if (!Model.Equals(otherSpec.Model))
            { return false; }

            if (!Type.Equals(otherSpec.Type))
            { return false; }

            if (!BackWood.Equals(otherSpec.BackWood))
            { return false; }

            if (!TopWood.Equals(otherSpec.TopWood))
            { return false; }

            return true;
        }
    }
}
