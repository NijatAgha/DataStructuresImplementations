using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplementations
{
    public class MyQueue<T>
    {
        private T[] elements = new T[100];

        private int enqueueIndex = -1;
        private int dequeueIndex = 0;

        // Add new element to the queue
        public void Enqueue(T element)
        {
            elements[++enqueueIndex] = element;
        }

        // Return beginning element of the queue and remove it
        public T Dequeue()
        {
            T element = elements[dequeueIndex];
            dequeueIndex++;
            return element;
        }

        // Return the number elements in the queue
        public int Count()
        {
            return enqueueIndex - dequeueIndex + 1;
        }

    }
}
