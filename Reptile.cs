using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Reptiles
{
    /// <summary>
    /// Abstract base class for reptiles.
    /// </summary>
    abstract class Reptile : Animal
    {


        #region FIELDS
        private double weight;
        private bool livesInWater;
        #endregion

        #region CONTRUCTOR

        /// <summary>
        /// Initializes a new instance of the Reptile class.
        /// </summary>
        public Reptile(double weight, bool livesInWater)
        {
            this.weight = weight;
            this.livesInWater = livesInWater;
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Getters/setters
        /// </summary>

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public bool LivesInWater
        {
            get { return livesInWater; }
            set { livesInWater = value; }
        }
        #endregion

        #region METHOD
        public override string ToString()
        {
            string baseInfo = base.ToString();

            string reptileInfo = string.Format("\n{0, -20}{1, 10}\n{2, -20}{3, 10}\n", "Weight (kg): ",
                Weight, "Lives in Water: ", LivesInWater ? "Yes" : "No");

            return baseInfo + reptileInfo;
        }

        #endregion
    }
}
