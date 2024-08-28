using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Marine
{
    /// <summary>
    /// Base class for marine animals.
    /// </summary>
    abstract class Marine : Animal
    {
        private double fishLength;
        bool isDangerous;

        /// <summary>
        /// Initializes a new instance of the Marine class.
        /// </summary>
        public Marine(double fishLength, bool isDangerous)
        {
            this.fishLength = fishLength;
            this.isDangerous = isDangerous;
        }

        public double FishLenght
        {
            get { return fishLength; }

            set { fishLength = value; }
        }

        public override string ToString()
        {
            string strOut = base.ToString(); 

            strOut += string.Format("\n{0, -20}{1, 10}\n{2, -20}{3, 10}\n", "Fish Length (cm): ",
                fishLength, "Is Dangerous: ", isDangerous);

            return strOut;
        }

    } 
}
