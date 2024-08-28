using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Insects
{
    class Bee : Insect
    {
        private bool hasWings;

        public Bee(bool hasWings) : base(hasWings)
        {
            this.hasWings = hasWings;
            SetFoodSchedule();
        }

        public override string ToString()
        {
            string strOut = "Bee\n\n";

            strOut = base.ToString();

            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Nectar");
            foodSchedule.Add("Evening: Nectar");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
