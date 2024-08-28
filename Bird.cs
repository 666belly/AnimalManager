using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Birds
{
    /// <summary>
    /// Abstract base class for birds.
    /// </summary>
    abstract class Bird : Animal
    {
        #region FIELDS

        private double wingspan;
        private double lengthOfBeak;

        #endregion

        #region PROPERTIES
        public double Wingspan
        {
            get { return wingspan; }
            set { wingspan = value; }
        }

        public double LengthOfBeak
        {
            get { return lengthOfBeak; }
            set { lengthOfBeak = value; }
        }

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Initializes a new instanse of the Bird class
        /// </summary>

        public Bird() { }

        public Bird(double wingspan, double lengthOfBeak)
        {
            this.wingspan = wingspan;
            this.lengthOfBeak = lengthOfBeak;
        }

        #endregion

        #region METHOD

        public override string ToString()
        {
            string strOut = base.ToString(); 

            strOut += string.Format("\n{0, -20}{1, 10}\n{2, -20}{3, 10}\n", "Wingspan (cm): ",
                wingspan, "Beak Length (cm): ", lengthOfBeak
                );

            return strOut;
        }

        #endregion
    }
}
