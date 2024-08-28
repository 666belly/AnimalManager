using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT24Assignment1.Animals
{
    interface IAnimal 
    {
        string Name { get; set; }
        string ID { get; set; }
        GenderType Gender { get; set; }

        FoodSchedule GetFoodSchedule();
        string GetExtraInfo();
    }
}
