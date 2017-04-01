using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    


    class LinkedList
    {
        Node head;

       public class Node
       {
            public int data;
            public Node next;

            Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public Node ReverseList(Node node)
        {
            Node next = null;
            Node current = node;
            Node prev = null;


            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            head = prev;

            return node;
        }
    }
}