using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Birds
{
    class Dove : Bird
    {

        public Dove(double wingspan, double lengthOfBeak) : base(wingspan, lengthOfBeak)
        {
            SetFoodSchedule();
        }

        public override string ToString()
        {
            string strOut = "Dove\n\n";

            strOut = base.ToString();

            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Grains");
            foodSchedule.Add("Evening: Worms");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
