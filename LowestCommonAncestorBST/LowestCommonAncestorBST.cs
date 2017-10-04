using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestorBST
{
    public class Node
    {
        int data;
        Node leftChild;
        Node rightChild;

        public Node()
        {
            data = 0;
            leftChild = null;
            rightChild = null;
        }

        public Node(int d, Node lc, Node rc)
        {
            data = d;
            leftChild = lc;
            rightChild = rc;
        }

        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node LeftChild
        {
            get { return this.leftChild; }
            set { this.leftChild = value; }
        }
        
        public Node RightChild
        {
            get { return this.rightChild; }
            set { this.rightChild = value; }
        }
    }

    public class LowestCommonAncestorBST
    {

        int count = 10;
        public Node BuildTree()
        {

            //Tree Structure
            //             10
            //      -10           30
            //          8      25    60
            //        6   9      28    78 


            Node rrr3 = new Node(78, null, null);
            Node rr3 = new Node(28, null, null);
            Node rr2 = new Node(60, null, rrr3);
            Node rl2 = new Node(25, null, rr3);
            Node r1 = new Node(30, rl2, rr2);
            Node r3 = new Node(9, null, null);
            Node l3 = new Node(6, null, null);
            Node r2 = new Node(8, l3, r3);
            Node l1 = new Node(-10, null, r2);
            Node root = new Node(10, l1, r1);
            return root;
        }

        public Node lowestCommonAncestor(Node root, int a, int b)
        {
            if (root.Data > Math.Max(a, b))
            {
                return lowestCommonAncestor(root.LeftChild, a, b);
            }
            else if (root.Data < Math.Min(a, b))
            {
                return lowestCommonAncestor(root.RightChild, a, b);
            }
            else
            {
                return root;
            }
        }

        public void printUtil(Node root, int space)
        {
            if (root == null)
                return;

            space += count;

            // Process right child first
            printUtil(root.RightChild, space);
            Console.Write("\n");
            for (int i = count; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Data);

            // Process left child
            printUtil(root.LeftChild, space);
        }

        public void Print(Node root)
        {
            printUtil(root, 0);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LowestCommonAncestorBST LCABST = new LowestCommonAncestorBST();
            Node root = LCABST.BuildTree();
            LCABST.Print(root);

            int a = 28;
            int b = 78;

            Node result = LCABST.lowestCommonAncestor(root, a, b);
            if (result != null)
            {
                Console.WriteLine("\n\nThe lowest common ancestor for {0} and {1} is {2}.", a, b, result.Data);
            }
            else
            {
                Console.WriteLine("\n\nThe lowest common ancestor for {0} and {1} in the tree doesn't exists", a, b);
            }
            Console.ReadLine();





            Console.ReadLine();
        }
    }
}