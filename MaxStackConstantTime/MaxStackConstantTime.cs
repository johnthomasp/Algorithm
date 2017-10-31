using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxStackConstantTime
{

    /*
     * Design a stack with a push, pop and max function
     * which returns the max value in the stack,
     * all of which runs in constant time O(1). 
     */


    public class Node {
        public int value;
        public Node next;
        public int max;

        public Node(int x)
        {
            value = x;
            next = null;
            max = x;
        }
    }

    public class MaxStack
    {
        Node topNode = null;
        
        public void Push(int val)
        {
            if (topNode == null)
            {
                topNode = new Node(val);
            }
            else
            {
                Node temp = new Node(val);
                temp.next = topNode;
                temp.max = Math.Max(topNode.max, val);
                topNode = temp;
            }
        }

        public void pop()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }

            topNode = topNode.next;
        }

        public int top()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack is Empty");
                return Int16.MinValue;
            }

            return topNode.value;
        }


        public int max()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack is Empty");
                return Int16.MinValue;
            }

            return topNode.max;
        }

        static void Main(string[] args)
        {
            MaxStack ms = new MaxStack();
            ms.Push(10);
            ms.Push(8);
            Console.WriteLine(ms.max());
            ms.Push(6);
            ms.Push(11);
            Console.WriteLine(ms.max());
            ms.Push(13);
            ms.Push(14);
            Console.WriteLine(ms.max());
            ms.pop();
            ms.pop();
            Console.WriteLine(ms.max());
            Console.ReadLine();
        }
    }
}
