using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Mammals
{
    class Cat : Mammal
    {
        private int cuteness = 0;

        public Cat(int numOfTeeth, double tailLenght) : base(numOfTeeth, tailLenght)
        {
            Cuteness = 1;
            SetFoodSchedule();

        }

        public int Cuteness
        {
            get { return cuteness; }
            set { cuteness = value; }
        }

        public override string ToString()
        {
            string strOut = "Cat \n\n";
            strOut = base.ToString();

            strOut += $"Cuteness: {cuteness}\n";
    

            return strOut;

        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Flakes and milk");
            foodSchedule.Add("Lunch: Flakes");
            foodSchedule.Add("Evening: Any meat/fish");
        }

        public override FoodSchedule GetFoodSchedule()
        {

            return foodSchedule;
        }

    }
}
