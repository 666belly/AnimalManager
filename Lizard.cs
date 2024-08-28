using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Reptiles
{
    class Lizard : Reptile
    {
        public Lizard(double weight, bool livesInWater) : base(weight, livesInWater)
        {
            Weight = weight;
            LivesInWater = livesInWater;
            SetFoodSchedule();
        }

        public double Weight { get; set; }
        public bool LivesInWater { get; set; }

        public override string ToString()
        {
            string strOut = "Lizard\n\n";

            strOut = base.ToString();

            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Insects");
            foodSchedule.Add("Evening: Vegetables");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
