using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT24Assignment1.Animals
{
    interface IListManager<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);

        // Add metod
        void Add(T aType);

        // ChangeAt metod
        void ChangeAt(int index, T newItem);

        // CheckIndex metod
        void CheckIndex(int index);

        // DeleteAll metod
        void DeleteAll();

        // DeleteAt metod
        void DeleteAt(int index);

        // GetAt metod
        T GetAt(int index);

        // ToStringArray metod
        string[] ToStringArray();


        // ToStringList metod
        List<string> ToStringList();

        //Update to change the object at selected index
        void Update(int index, T newItem);

        bool JsonSerialize(string fileName);

        // Count property
        int Count { get; }
    }
}
