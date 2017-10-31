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

        public Node()
        {
    //        value = 0;
            next = null;
      //      max = 0;
        }

        public Node(int x)
        {
            value = x;
            next = null;
            max = x;
        }
    }




    public class MaxStackConstantTime
    {

        Node stack = new Node();
        Node maxNode = new Node();

        public void Push(int val)
        {
            Node n = new Node();
            n.value = val;

            if (stack == null)
            {
                stack = n;
            }
            else 
            {
                n.next = stack;
                stack = n;
            }

            if ((maxNode == null) || (n.value > maxNode.max))
            {
                n.max = maxNode.value;
                maxNode = n;
            }

        }


        
        static void Main(string[] args)
        {
        }
    }
}
