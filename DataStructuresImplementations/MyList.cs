using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplementations
{
    public class MyList
    {
        private int[] elements = new int[100];

        private int index = -1;
        private int temp = -1;

        // Add new element to the list
        public void Add(int element)
        {
            elements[++index] = element;
            temp++;
        }

        // Remove specified index from list
        public void RemoveAt(int index)
        {
            try
            {
                elements[index] = -1;
                temp--;
            }
         
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        // Return size of the list
        public int Count()
        {
            return temp + 1;
        }

        // Return true if specified element found in list
        public bool Find(int element)
        {
            foreach (var item in elements)
            {
                if (item == element)
                    return true;
                
                else
                    return false;
            }

            return false;
        }
    }
}
