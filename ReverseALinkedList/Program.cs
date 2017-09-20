using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseALinkedList
{
    //Add Comment
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll1 = new LinkedList<int>();
            ll1.AddLast(1);
            ll1.AddLast(2);
            ll1.AddLast(3);
            ReverseLinkList rl = new ReverseLinkList();
            //LinkedList<int> ll2 = rl.ReverseList(ll1);
            rl.printList(rl.ReverseList(ll1));
            Console.ReadLine();
        }
    }

    public class ReverseLinkList
    {
        public LinkedList<int> ReverseList(LinkedList<int> list)
        {
            LinkedListNode<int> current = list.First;
            while (current.Next != null)
            {
                //next = current.Next;
                //current.Next = prev;
                //prev = current;
                //current = next;

                var next = current.Next;
                list.Remove(next);
                list.AddFirst(next.Value);
            }

            return list;
            //list.First = prev;

            //return node;
        }


        public void printList(LinkedList<int> ln)
        {
            Console.Write("Head-->");

            foreach (int value in ln)
            {
                Console.Write(value);
                Console.Write("-->");
            }


            Console.Write("NULL");
        }
    }


}

