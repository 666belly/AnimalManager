using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;
using VT24Assignment1.Mammals;

namespace VT24Assignment1.Birds
{
    class BirdFactory
    {
        public static Bird CreateBird(BirdSpecies species, double wingspan, double lengthOfBeak)
        {
            Bird bird = null;

            switch (species)
            {
                case BirdSpecies.Dove:
                    bird = new Dove(wingspan, lengthOfBeak);
                    break;
                case BirdSpecies.Eagle:
                    bird = new Eagle(wingspan, lengthOfBeak);
                    break;
                    // Add cases for other bird species
            }

            return bird;
        }

    }
}
