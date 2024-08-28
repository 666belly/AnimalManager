using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Mammals;

namespace VT24Assignment1.Marine
{
    class MarineFactory
    {
        public static Marine CreateMarine(MarineSpecies species, double fishLenght, bool isDangerous)
        {
            Marine marine = null;

            switch (species)
            {
                case MarineSpecies.Shark:
                    marine = new Shark(fishLenght, isDangerous);
                    break;
                case MarineSpecies.Goldfish:
                    marine = new Goldfish(fishLenght, isDangerous);
                    break;
            }

            return marine;
        }

    }
}
