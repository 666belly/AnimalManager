using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VT24Assignment1.Animals;

namespace VT24Assignment1.Mammals
{
    /// <summary>
    /// Method to create new object Mammal
    /// </summary>
    class MammalFactory
    {
        public static Mammal CreateMammal(MammalSpecies species, int numOfTeeth, double tailLenght, int cuteness, string breed)
        {
            Mammal mammal = null;

            switch (species)
            {
                case MammalSpecies.Cat:
                    mammal = new Cat(numOfTeeth, tailLenght);
                    SetCatProperties((Cat)mammal, cuteness);
                    break;
                case MammalSpecies.Dog:
                    mammal = new Dog(numOfTeeth, tailLenght);
                    SetDogProperties((Dog)mammal, breed);
                    break;
            }

            return mammal;
        }

        private static void SetCatProperties(Cat cat, int cuteness)
        {
            cat.Cuteness = cuteness;
        }

        private static void SetDogProperties(Dog dog, string breed)
        {
            if (breed != null)
                dog.Breed = breed;
        }
    }
}
