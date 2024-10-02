using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock.Hepler
{
    
        public class BuilderHelper
        {
            public static string ToFriendlyString(Builder builder)
            {
                switch (builder)
                {
                    case Builder.FENDER:
                        return "Fender";
                    case Builder.MARTIN:
                        return "Mertin";
                    case Builder.GIBSON:
                        return "Giboson";
                    case Builder.COLLINGS:
                        return "Collings";
                    case Builder.OLSON:
                        return "Olson";
                    case Builder.RYAN:
                        return "Ryan";
                    case Builder.PRS:
                        return "Prs";
                    case Builder.ANY:
                        return "Any";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(Builder), builder, null);
                }
            }

        }
        public enum Builder
        {
            FENDER,
            MARTIN,
            GIBSON,
            COLLINGS,
            OLSON,
            RYAN,
            PRS,
            ANY
        }
    
}
