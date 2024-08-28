using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace VT24Assignment1.Animals
{
     class AnimalManager : ListManager<Animal>
    {
        private Random random = new Random();

        // Method to add an animal to the list
        public string AddItem(Animal item)
        {
            string id = GetNewID(); // Generate new ID
            item.ID = id; // Assign ID to an animal
            base.AddItem(item); // Add animal to list
            return id; // Return random ID
        }

        // Method to generate a new ID for an animal
        public string GetNewID()
        {
            int randomNumber = random.Next(100000, 999999);
            return "M" + randomNumber.ToString();
        }

    }

}

