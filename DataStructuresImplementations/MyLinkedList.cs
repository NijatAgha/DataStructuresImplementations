using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresImplementations
{
    public class Node
    {
        public int data;

        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    public class MyLinkedList
    {
        public Node head;

        public void AddFront(MyLinkedList linkedList, int data)
        {
            var newNode = new Node(data);
            newNode.next = linkedList.head;
            linkedList.head = newNode;
        }

        public Node GetLastNode(MyLinkedList linkedList)
        {
            Node temp = linkedList.head;

            while (temp.next != null)
                temp = temp.next;

            return temp;
        }

        public void AddLast(MyLinkedList linkedList, int data)
        {
            Node node = new Node(data);

            if(linkedList.head == null)
            {
                linkedList.head = node;
                return;
            }

            Node lastNode = GetLastNode(linkedList);

            lastNode.next = node;
        }
    }
}
