using CH5.GoodDesgin.Helper;
using CH5.GoodDesgin.Hepler;

namespace CH5.GoodDesgin
{
    internal class Program
    {
           static void Main(string[] args)
            {
                Inventory inventory = new Inventory();
                InitializeInventory(inventory);

                GuitarSpec whatErinLikes = new GuitarSpec(BuilderHelper.ToFriendlyString(Builder.FENDER), "Stratocastor",
                                              TypeHepler.ToFriendlyString(Typee.ELECTRIC), WoodHelper.ToFriendlyString(WoodHelper.Wood.Alder), WoodHelper.ToFriendlyString(WoodHelper.Wood.Alder), 12);
                List<Guitar> matchingGuitars = inventory.Search(whatErinLikes);

                if (matchingGuitars.Any())
                {
                    foreach (var guitar in matchingGuitars)
                    {
                        GuitarSpec spec = guitar.GuitarSpec;
                        Console.WriteLine("Erin, you might like this " +
                            spec.Builder + " " + spec.Model + " " +
                            spec.Type + " guitar:\n" +
                            spec.BackWood + " back and sides,\n" +
                            spec.TopWood + " top.\nYou can have it for only $" +
                            guitar.Price + "!");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, Erin, we have nothing for you.");
                }
            }
            private static void InitializeInventory(Inventory inventory)
            {
                // Add guitars to the inventory...
                // Example:
                //you see all data is ok but we have some different on some prop it may be space in any property
                //or it compares [Fender] to [fender]
                inventory.AddGuitar("V95693", 1499.95, "Fender", "stratocastor", "electric", "Alder", "Alder", 12);
                inventory.AddGuitar("V95693", 1499.95, "Fender", "stratocastor", "electric", "Alder", "Alder", 12);
                inventory.AddGuitar("V9512", 1549.95, "Gibson", "Les Paul", "electric", "Mahogany", "Maple", 8);

            }
 
    }
}
