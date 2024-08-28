using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Insects
{
    /// <summary>
    /// Base class for insects.
    /// </summary>
    abstract class Insect : Animal
    {
        bool hasWings;

        public Insect(bool hasWings)
        {
            this.hasWings = hasWings;
        }

        public override string ToString()
        {
            string wingsStatus = hasWings ? "Yes" : "No";

            string strOut = base.ToString();

            strOut += string.Format("\n{0, -20}{1, 10}\n", "Has Wings: ", hasWings);

            return strOut;
        }
    }
}
