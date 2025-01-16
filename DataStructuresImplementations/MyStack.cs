using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplementations
{
    public class MyStack<T>
    {
        private T[] elements = new T[100];

        private int top = -1;

        // Add new element to the stack
        public void Push(T element)
        {
            elements[++top] = element;
        }

        // Remove the last element from the stack. Print the value of this element.
        public void Pop()
        {
            try
            {
                T element = elements[top];
                top--;
                Console.WriteLine(element);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        //Print the value of the last element, not removing it from the stack.
        public T Back()
        {
            return elements[top];
        }

        // Print the number of elements in the stack.
        public int Size()
        {
            return top + 1;
        }
    }
}
