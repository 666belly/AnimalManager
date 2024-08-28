using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Mammals
{
    /// <summary>
    /// Base class for mammals.
    /// </summary>
    abstract class Mammal : Animal
    {
        #region FIELDS
        private int numOfTeeth;
        private double tailLength;

        #endregion

        #region CONSTRUCTOR
        public Mammal(int numOfTeeth, double tailLength)
        {
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
        }

        #endregion

        #region PROPERTIES

        public int NumOfTeeth
        {
            get { return numOfTeeth; }

            set { numOfTeeth = value; }
        }

        public double TailLength
        {
            get { return tailLength; }

            set { tailLength = value; }
        }

        #endregion

        #region METHOD

        /// <summary>
        /// Overrides the ToString method to provide custom string representation specific to mammals.
        /// </summary>
        public override string ToString()
        {
            string strOut = base.ToString();

            strOut += string.Format("\n{0, -20}{1, 10}\n{2, -20}{3, 10}\n", "Tail Length (cm): ",
                tailLength, "Number of Teeth: ", numOfTeeth);

            return strOut;
        }

        #endregion
    }
}
