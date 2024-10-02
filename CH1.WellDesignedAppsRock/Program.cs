using CH1.WellDesignedAppsRock.Hepler;

namespace CH1.WellDesignedAppsRock
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, BuilderHelper.ToFriendlyString(Builder.FENDER), "Stratocastor",
                                          TypeHepler.ToFriendlyString(Typee.ELECTRIC), WoodHelper.ToFriendlyString(WoodHelper.Wood.Alder), WoodHelper.ToFriendlyString(WoodHelper.Wood.Alder));
            Guitar guitar = inventory.Search(whatErinLikes);

            if (guitar != null)
            {
                Console.WriteLine("Erin, you might like this " +
                                  guitar.Builder + " " + guitar.Model + " " +
                                  guitar.Type + " guitar:\n" +
                                  guitar.BackWood + " back and sides,\n" +
                                  guitar.TopWood + " top.\nYou can have it for only $" +
                                  guitar.Price + "!");
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
            inventory.AddGuitar("V95693", 1499.95, "Fender", "stratocastor", "electric", "Alder", "Alder");
            inventory.AddGuitar("V9512", 1549.95, "Gibson", "Les Paul", "electric", "Mahogany", "Maple");
            
        }
    }
}
