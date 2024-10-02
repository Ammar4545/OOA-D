using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock.Hepler
{
    public class TypeHepler
    {
        public static string ToFriendlyString(Type type)
        {
            switch (type)
            {
                case Type.ACOUSTIC:
                    return "acoustic";
                case Type.ELECTRIC:
                    return "electric";
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
        
    }
    public enum Type
    {
       ACOUSTIC,
       ELECTRIC
    }
}
