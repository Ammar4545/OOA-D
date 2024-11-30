using CH5_Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH5.Part2
{
    public class Inventory
    {
        private List<Instrument> _inventory;

        public Inventory()
        {

            _inventory = new List<Instrument>(); 
        }

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;

            if (spec is GuitarSpec)
            {
                instrument=new Guitar(serialNumber, price,(GuitarSpec)spec);
            }
            else
            {
                instrument = new Mandoline(serialNumber, price, (MandolineSpec)spec);
            }
           

            _inventory.Add(instrument);
        }

        public Instrument GetInstrument(string serialNumber)
        {
            foreach (var instrument in _inventory)
            {
                if (instrument.serialNumber.Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            var matchingGuitars = new List<Guitar>();
            foreach (var instrument in _inventory)
            {
                if (!(instrument is Guitar))
                {
                    continue;
                }

                Guitar guitar = (Guitar)instrument;
                if (guitar.spec.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }

            }
            return matchingGuitars;

        }

        public List<Mandoline> Search(MandolineSpec searchSpec)
        {
            var matchingMandolines = new List<Mandoline>();
            foreach (var instrument in _inventory)
            {
                if (!(instrument is Mandoline))
                {
                    continue;
                }

                Mandoline mandoline = (Mandoline)instrument;
                if (mandoline.spec.Matches(searchSpec))
                {
                    matchingMandolines.Add(mandoline);
                }
            }
            return matchingMandolines;

        }


    }
}
