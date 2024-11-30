using CH5.Part2.Helper;
using CH5.Part2.Hepler;
using CH5_Analysis;


namespace CH5.Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatGuitarErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Adirondack, 6);
            findInstrument("Erin", whatGuitarErinLikes, inventory);

            MandolineSpec whatMandolineErinLikes = new MandolineSpec(Builder.MARTIN, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Adirondack, Style.A);
            findInstrument("Erin",whatMandolineErinLikes,inventory);

            
        }


        private static void findInstrument(string name, InstrumentSpec instrumentSpec, Inventory inventory)
        {
            string choiceInstrument = "";
            List<Instrument> instruments = new List<Instrument>();
            if (instrumentSpec is GuitarSpec)
            {
                List<Guitar> guitars = inventory.Search((GuitarSpec)instrumentSpec);
                instruments = new List<Instrument>(guitars);
                choiceInstrument = "guitar";
            }
            else if (instrumentSpec is MandolineSpec)
            {
                List<Mandoline> mandolins = inventory.Search((MandolineSpec)instrumentSpec);
                instruments = new List<Instrument>(mandolins);
                choiceInstrument = "mandolin";
            }

            if (instruments.Count > 0)
            {
                try
                {
                    string msgSuccess = string.Format("{0}, you might like these {1}s: ", name, choiceInstrument);
                    foreach (Instrument instrument in instruments)
                    {
                        InstrumentSpec spec = null;
                        if (instrumentSpec is GuitarSpec)
                        {
                            Guitar guitar = (Guitar)instrument;
                            spec = guitar.spec;
                        }
                        else if (instrumentSpec is MandolineSpec)
                        {
                            Mandoline mandolin = (Mandoline)instrument;
                            spec = mandolin.spec;
                        }
                        if (spec == null) { messageFail(name); }

                        msgSuccess += "\nWe have a " +
                            Enumerations.GetEnumDescription(spec.Builder) + " " + spec.Model + " " +
                            Enumerations.GetEnumDescription(spec.Type) + " " + choiceInstrument + ":\n    " +
                            Enumerations.GetEnumDescription(spec.BackWood) + " back and sides,\n    " +
                            Enumerations.GetEnumDescription(spec.TopWood) + " top.\nYou can have it for only $" +
                            instrument.price + "!\n  ----";
                    }
                    Console.WriteLine(msgSuccess);
                    Console.ReadKey();

                    return;
                }
                catch (Exception)
                {
                    // No action taken. Default fail message will be triggered at end of method.
                }
            }
            messageFail(name);
        }

        private static void messageFail(string name)
        {
            string msgFail = string.Format("Sorry, {0}, we have nothing for you.", name);
            Console.WriteLine(msgFail);
            Console.ReadKey();
        }

        private static void initializeInventory(Inventory inventory)
        {
            initializeGuitarInventory(inventory);
            initializeMandolinInventory(inventory);
        }
        private static void initializeGuitarInventory(Inventory inventory)
        {
            // Add Guitars to the inventory ...
            inventory.AddInstrument("V12345", 1345.55, new GuitarSpec(Builder.FENDER, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Adirondack, 6));
            inventory.AddInstrument("A21457", 900.55, new GuitarSpec(Builder.COLLINGS, "OakTown Goove", Typee.ACOUSTIC, Wood.BrazilianRosewood, Wood.Cedar,9));
            inventory.AddInstrument("V95693", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Alder, 10));
            inventory.AddInstrument("X54321", 430.54, new GuitarSpec(Builder.MARTIN, "Stratocastor Light", Typee.ELECTRIC, Wood.IndianRosewood, Wood.Maple, 7));
            inventory.AddInstrument("X99876", 2000.00, new GuitarSpec(Builder.PRS, "Stratocastor FeatherWeight", Typee.ELECTRIC, Wood.Sitka, Wood.Cocobolo, 6));
            inventory.AddInstrument("V9512", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Alder, 6));
        }

        private static void initializeMandolinInventory(Inventory inventory)
        {
            // Add Mandolins to the inventory ...
            inventory.AddInstrument("X12345", 1745.55, new MandolineSpec(Builder.MARTIN, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Adirondack, Style.A));
            inventory.AddInstrument("Q21457", 1200.55, new MandolineSpec(Builder.FENDER, "OakTown Goove", Typee.ELECTRIC, Wood.BrazilianRosewood, Wood.Cedar, Style.F));
            inventory.AddInstrument("S95693", 1699.95, new MandolineSpec(Builder.PRS, "Stratocastor", Typee.ELECTRIC, Wood.Alder, Wood.Alder, Style.A));
        }

    }
}
