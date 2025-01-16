using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresImplementations
{
    public class MyCircularQueue<T>
    {
        const int SIZE = 100;
        private T[] elements = new T[SIZE];
        int frontIndex = 0;
        int backIndex = 0;
        int count = 0;

        // Add new element to front of the circular queue;
        public void PushFront(T element)
        {
            frontIndex = (frontIndex - 1 + SIZE) % SIZE;
            elements[frontIndex] = element;
            count++;
        }

        // Add new element to back of the circular queue;
        public void PushBack(T element)
        {
            elements[backIndex] = element;
            backIndex = (backIndex + 1) % SIZE;
            count++;
        }

        // Return front element of circular queue and remove it;
        public void PopFront()
        {
            Console.WriteLine(elements[frontIndex]);
            frontIndex = (frontIndex + 1) % SIZE;
            count--;
        }

        // Return back element of circular queue and remove it;
        public T PopBack()
        {
            backIndex = (backIndex - 1 + SIZE) % SIZE;
            count--;
            return elements[backIndex];
        }

        // Return front element of circular queue. Not removing it;
        public T Front()
        {
            return elements[frontIndex];
        }

        // Return back element of circular queue. Not removing it;
        public T Back()
        {
            return elements[(backIndex - 1 + SIZE) % SIZE];
        }

        // Return count of the circular queue.
        public int Count()
        {
            return count;
        }

        // Remove all elements from the circular queue.
        public void Clear()
        {
            frontIndex = 0;
            backIndex = 0;
            count = 0;
        }
    }
}
