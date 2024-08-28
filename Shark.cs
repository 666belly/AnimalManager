using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Marine
{
    class Shark : Marine
    {
        public Shark(double fishLength, bool isDangerous) : base(fishLength, isDangerous)
        {
            FishLength = fishLength;
            IsDangerous = isDangerous;
            SetFoodSchedule();
        }

        public double FishLength { get; set; }
        public bool IsDangerous { get; set; }

        public override string ToString()
        {
            string strOut = "Shark\n\n";

            strOut = base.ToString();

            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning: Meat dish");
            foodSchedule.Add("Evening: Meat dish");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
