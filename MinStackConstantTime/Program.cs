using System;

namespace MinStackConstantTime
{
    /*
     * Design a stack with a push, pop, min function which returns the min value in the stack.
     * All of which runs in constant time O(1). 
     */

    public class Node
    {
        public int value;
        public Node next;
        public int min;

        public Node(int x)
        {
            value = x;
            next = null;
            min = x;
        }
    }

    public class MinStack
    {
        Node topNode;

        public void push(int x)
        {

            if (topNode == null)
            {
                topNode = new Node(x);
            }
            else
            {
                Node temp = new Node(x);
                temp.next = topNode;
                temp.min = Math.Min(topNode.min, x);
                topNode = temp;
            }
        }

        public void pop()
        {

            if (topNode == null)
            {
                Console.WriteLine("Stack Empty");
                return;
            }
            topNode = topNode.next;
        }

        public int min()
        {

            if (topNode == null)
            {
                Console.WriteLine("Stack Empty");
                return Int16.MaxValue;
            }
            return topNode.min;
        }

        public int top()
        {
            if (topNode == null)
            {
                Console.WriteLine("Stack Empty");
                return Int16.MaxValue;
            }
            return topNode.value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinStack mStack = new MinStack();
            mStack.push(7);
            mStack.push(8);
            Console.WriteLine(mStack.min());
            mStack.push(5);
            mStack.push(9);
            Console.WriteLine(mStack.min());
            mStack.push(5);
            mStack.push(2);
            Console.WriteLine(mStack.min());
            mStack.pop();
            mStack.pop();
            Console.WriteLine(mStack.min());
            Console.ReadLine();
        }
    }
}