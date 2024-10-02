using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock.Hepler
{
    public class WoodHelper
    {
        public static string ToFriendlyString(Wood wood)
        {
            switch (wood)
            {
                case Wood.IndianRosewood:
                    return "Indian Rosewood";
                case Wood.BrazilianRosewood:
                    return "Brazilian Rosewood";
                case Wood.Mahogany:
                    return "Mahogany";
                case Wood.Maple:
                    return "Maple";
                case Wood.Cocobolo:
                    return "Cocobolo";
                case Wood.Cedar:
                    return "Cedar";
                case Wood.Adirondack:
                    return "Adirondack";
                case Wood.Alder:
                    return "Alder";
                case Wood.Sitka:
                    return "Sitka";
                default:
                    throw new ArgumentOutOfRangeException(nameof(wood), wood, null);
            }
        }
        public enum Wood
        {
            IndianRosewood,
            BrazilianRosewood,
            Mahogany,
            Maple,
            Cocobolo,
            Cedar,
            Adirondack,
            Alder,
            Sitka
        }
    }
}
