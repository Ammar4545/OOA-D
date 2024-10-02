using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1.WellDesignedAppsRock
{
    public class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {

            guitars = new List<Guitar>(); 
        }

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);

            guitars.Add(guitar);
        }

        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }

        public List<Guitar> Search(Guitar searchGuitar)
        {
            var matchingGuitars= new List<Guitar>();
            foreach (var guitar in guitars)
            {
                // Ignore serial number since that’s unique
                // Ignore price since that’s unique
                //U see that these method is mess as It compare each prop to object in the inventory

                
                string builder = searchGuitar.Builder;
                if (!string.IsNullOrEmpty(builder) && !builder.Equals(guitar.Builder))
                    continue;

                string model = searchGuitar.Model.ToLower();
                if (!string.IsNullOrEmpty(model) && !model.Equals(guitar.Model.ToLower()))
                    continue;

                string type = searchGuitar.Type;
                if (!string.IsNullOrEmpty(type) && !type.Equals(guitar.Type))
                    continue;

                string backWood = searchGuitar.BackWood;
                if (!string.IsNullOrEmpty(backWood) && !backWood.Equals(guitar.BackWood))
                    continue;

                string topWood = searchGuitar.TopWood;
                if (!string.IsNullOrEmpty(topWood) && !topWood.Equals(guitar.TopWood))
                    continue;

                matchingGuitars.Add(guitar);

                //return matchingGuitars; // Return the first matching guitar
            }

            return matchingGuitars;

        }
        

    }
}
