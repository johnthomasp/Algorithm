using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthFromLast
{
    /*
        Given a singly link list, find the nth element from last
        Input: 1->2->3->4->5->6
        
        Output:
        n=1, output = 5
        n=2, output = 4
        n=3, output = 3
        n=4, output = 2
        n=5, output = 1
     */

    public class Node
    {
        public int Value;
        public Node Next;
    }

    public class SinglyLinkedList
    {
        public Node head;
        public Node tail;

        public SinglyLinkedList()
        {
            head = new Node();
            tail = head;
        }

        public void InsertNodeAtEnd(int value)
        {
            Node InsertNode = new Node();
            InsertNode.Value = value;
            tail.Next = InsertNode;
            tail = InsertNode;
        }

        public void printAllNodes()
        {
            Node curr = head;
            Console.Write("Head-->");
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("-->");
            }
            Console.Write("NULL");
        }
    }

    class NthFromLast
    {
        public static SinglyLinkedList CreateList()
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.InsertNodeAtEnd(1);
            list.InsertNodeAtEnd(2);
            list.InsertNodeAtEnd(3);
            list.InsertNodeAtEnd(4);
            list.InsertNodeAtEnd(5);
            list.InsertNodeAtEnd(6);
            return list;
        }

        public static int FindNthElement(SinglyLinkedList list, int n)
        {
            Node curr = list.head;
            Node follow = list.head;

            for (int i = 0; i < n; i++)
            {
                if (curr == null) return -1;
                curr = curr.Next;
            }

            while (curr.Next != null)
            {
                curr = curr.Next;
                follow = follow.Next;
            }
            return follow.Value;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the nth element to be determined:");
            int n = int.Parse(Console.ReadLine());
            SinglyLinkedList list = CreateList();
            list.printAllNodes();
            int result = FindNthElement(list, n);
            Console.WriteLine("\nThe nth({0}) from last is {1}", n, result);
            Console.ReadLine();
        }
    }
}
