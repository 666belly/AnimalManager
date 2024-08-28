using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT24Assignment1.Animals
{

    /// <summary>
    /// Base class to be inherited by subclasses, containing base info
    /// </summary>
    abstract class Animal : IAnimal
    {

        #region FIELDS
        private string name;
        private GenderType gender;
        private CategoryType category;
        private double age;
        private bool isDomesticated;
        private string id;

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Setter and getter for properties
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public CategoryType Category
        {
            get { return category; }
            set { category = value; }
        }

        public double Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool IsDomesticated
        {
            get { return isDomesticated; }
            set { isDomesticated = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of Animal class.
        /// </summary>
        public Animal()
        {
            Reset();
        }

        private void Reset()
        {
            Name = "Enter name";
            Gender = GenderType.Unknown;
            Age = 0;
            Category = CategoryType.Mammal;
        }


        #endregion

        #region METHOD

        /// <summary>
        /// Gets additional information about the animal.
        /// </summary>x
        public override string ToString()
        {
            return
                 $"Name: {Name}\n" +
                 $"Age: {Age}\n" +
                 $"Gender: {Gender}\n" +
                 $"Is domesticated: {IsDomesticated}\n" +
                 $"ID: {id}\n";

        }

        public abstract FoodSchedule GetFoodSchedule();

        public virtual string GetExtraInfo()
        {
            string strOut = string.Empty;
            strOut = string.Format("{0, -15} {1,10}\n", "Category: ", category.ToString());


            return strOut;
        }
        #endregion
    }
}
