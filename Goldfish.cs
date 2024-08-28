using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Marine
{
    class Goldfish : Marine
    {
        public Goldfish(double fishLength, bool isDangerous) : base(fishLength, isDangerous)
        {
            FishLength = fishLength;
            IsDangerous = isDangerous;
            SetFoodSchedule();
        }

        public double FishLength { get; set; }
        public bool IsDangerous { get; set; }

        public override string ToString()
        {
            string strOut = "Goldfish\n\n";

            strOut = base.ToString();

            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Herbivore;
            foodSchedule.Add("Morning: Fish flakes");
            foodSchedule.Add("Evening: Fish flakes");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}