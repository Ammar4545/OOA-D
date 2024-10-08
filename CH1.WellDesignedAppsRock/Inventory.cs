﻿using System;
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

        public void AddGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood, int numStrings)
        {
            GuitarSpec guitarSpec = new GuitarSpec(builder, model, type, backWood,topWood, numStrings);

            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);

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

        public List<Guitar> Search(GuitarSpec searchSpec)
        {
            var matchingGuitars= new List<Guitar>();
            foreach (var guitar in guitars)
            {
                // Ignore serial number since that’s unique
                // Ignore price since that’s unique
                //U see that these method is mess as It compare each prop to object in the inventory

                var guitarSpeac = guitar.GuitarSpec;

                if (guitarSpeac.Matches(searchSpec))
                {
                    matchingGuitars.Add(guitar);
                }

            }

            return matchingGuitars;

        }
        

    }
}
