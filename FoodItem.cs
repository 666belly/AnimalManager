using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT24Assignment1.Animals
{
    class FoodItem
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public FoodItem(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
