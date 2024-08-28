using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Mammals;

namespace VT24Assignment1.Insects
{
    class InsectFactory
    {
        public static Insect CreateInsect(InsectSpecies species, bool hasWings)
        {
            Insect insect = null;

            switch (species)
            {
                case InsectSpecies.Bee:
                    insect = new Bee(true);
                    break;
                case InsectSpecies.Ant:
                    insect = new Ant(false);
                    break;
            }

            return insect;
        }
    }
}
