using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Mammals
{
    class Dog : Mammal
    {
        private string breed;
        public Dog(int numOfTeeth, double tailLenght) : base(numOfTeeth, tailLenght)
        {
            breed = "unknown";
            SetFoodSchedule();
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }

        }

        public override string ToString()
        {
            string strOut = "Dog \n\n";
            strOut = base.ToString();

            strOut += $"Breed: {breed}\n";
        
            return strOut;
        }

        private FoodSchedule foodSchedule;

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: Flakes and milk");
            foodSchedule.Add("Lunch: Bones and flakes");
            foodSchedule.Add("Evening: Any meat dish");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }
    }
}
