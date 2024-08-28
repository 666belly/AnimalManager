using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Mammals;

namespace VT24Assignment1.Reptiles
{
    /// <summary>
    /// Class for creating reptiles.
    /// </summary>
    class ReptileFactory
    {

        /// <summary>
        /// Creates a reptile based on the specified species, weight, and habitat
        /// </summary>
        public static Reptile CreateReptile(ReptileSpecies species, double weight, bool livesInWater)
        {
            Reptile reptile = null;

            switch (species)
            {
                case ReptileSpecies.Frog:
                    reptile = new Frog(weight, livesInWater);
                    break;
                case ReptileSpecies.Lizard:
                    reptile = new Lizard(weight, livesInWater);
                    break;
            }

            return reptile;
        }

    }
}
