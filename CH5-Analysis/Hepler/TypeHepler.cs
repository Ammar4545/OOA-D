using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.GoodDesgin.Hepler
{
    public  class TypeHepler
    {
        public static string ToFriendlyString(Typee typee)
        {
            switch (typee)
            {
                case Typee.ACOUSTIC:
                    return "acoustic";
                case Typee.ELECTRIC:
                    return "electric";
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(typee), typee, null);
            }
        }
        
    }
    public enum Typee
    {
       ACOUSTIC,
       ELECTRIC
    }
}
