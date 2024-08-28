using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT24Assignment1.Animals
{
    public class FoodSchedule
    {
        public EaterType EaterType { get; set; }

        private List<string> feedingInfo = new List<string>();

        public void Add(string feeding)
        {
            feedingInfo.Add(feeding);
        }


        public int Count => feedingInfo.Count;

        public bool ChangeAt(int index, string item)
        {
            if (CheckIndex(index))
            {
                feedingInfo[index] = item;
                return true;
            }
            return false;
        }

        public bool CheckIndex(int index)
        {
            return index >= 0 && index < feedingInfo.Count;
        }

        public FoodSchedule()
        {
        }

        public string[] GetFoodListInfo()
        {
            return feedingInfo.ToArray();
        }

        public string Title()
        {
            return "Food Schedule";
        }

        public override string ToString()
        {
            return Title();
        }
    }

}
