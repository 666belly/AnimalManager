using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace VT24Assignment1.Animals
{
    public class ListManager<T> : IListManager<T>
    {
        #region FIELDS
        private List<T> m_List;


        #endregion

        #region METHODS

        public ListManager()
        {
            m_List = new List<T>();

        }

  

        public void AddItem(T item)
        {
            m_List.Add(item);
        }

        public void RemoveItem(T item)
        {
            m_List.Remove(item);
        }



        // Add method
        public void Add(T item)
        {
            AddItem(item);
        }

        // Method to save as Json
        public bool SaveAsJsonFile(string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(m_List, Formatting.Indented);
                File.WriteAllText(filePath, json);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving JSON file: {ex.Message}");
                return false;
            }
        }

        // Metho to save as text file
        public bool SaveAsTextFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (T item in m_List)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving text file: {ex.Message}");
                return false;
            }
        }
        public void Update(int index, T newItem)
        {
            if (CheckIndex(index))
            {
                m_List[index] = newItem;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }

        // ChangeAt method
        public void ChangeAt(int index, T newItem)
        {
            if (CheckIndex(index))
                m_List[index] = newItem;
            else
                throw new IndexOutOfRangeException("Index is out of range.");
        }

        // CheckIndex method
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < m_List.Count;
        }

        // DeleteAll method
        public void DeleteAll()
        {
            m_List.Clear();
        }

        // DeleteAt method
        public void DeleteAt(int index)
        {
            if (CheckIndex(index))
                m_List.RemoveAt(index);
            else
                throw new IndexOutOfRangeException("Index is out of range.");
        }

        // GetAt method
        public T GetAt(int index)
        {
            if (CheckIndex(index))
                return m_List[index];
            else
                throw new IndexOutOfRangeException("Index is out of range.");
        }

        // ToStringArray method
        public string[] ToStringArray()
        {
            return m_List.Select(item => item.ToString()).ToArray();
        }

        // ToStringList method
        public List<string> ToStringList()
        {
            return m_List.Select(item => item.ToString()).ToList();
        }

        void IListManager<T>.CheckIndex(int index)
        {
            throw new NotImplementedException();
        }

        public bool JsonSerialize(string fileName)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region PROPERTIES
        // Count property
        public int Count => m_List.Count;

        #endregion
    }
}
