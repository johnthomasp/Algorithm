using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestor
{
    public class Node
    {

        private int data;
        private Node leftChild;
        private Node rightChild;

        public Node()
        {
            data = 0;
            leftChild = null;
            rightChild = null;
        }

        public Node(int value, Node lc, Node rc)
        {
            leftChild = lc;
            data = value;
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

    public class LowestCommonAncestorBS
    {
        int count = 10;
        public Node buildTree()
        {
            //Tree Structure
            //          3
            //      6       8
            //    2   11      13
            //       9  5    7 

            Node rl3 = new Node(7, null, null);
            Node rr2 = new Node(13, rl3, null);
            Node r3 = new Node(5, null, null);
            Node r1 = new Node(8, null, rr2);
            Node l3 = new Node(9, null, null);
            Node r2 = new Node(11, l3, r3);
            Node l2 = new Node(2, null, null);
            Node l1 = new Node(6, l2, r2);
            Node root = new Node(3, l1, r1);
            return root;
        }

        public Node lowestCommonAncestor(Node root, int a, int b)
        {
            if (root == null)
                return null;
            if (root.Data == a || root.Data == b)
                return root;

            Node left = lowestCommonAncestor(root.LeftChild, a, b);
            Node right = lowestCommonAncestor(root.RightChild, a, b);

            if ((left == null) && (right == null)) return null;
            if ((left != null) && (right != null)) return root;
            return (left != null) ? left : right;
        }

        void printUtil(Node root, int space)
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
            LowestCommonAncestorBS LCA = new LowestCommonAncestorBS();
            Node root = LCA.buildTree();
            LCA.Print(root);

            //Tree Structure
            //          3
            //      6       8
            //    2   11      13
            //       9  5    7 

            int a = 2;
            int b = 5;
            //int a = 8;
            //int b = 11;
            //int a = 8;
            //int b = 7;
            //int a = 4;
            //int b = 12;
            Node result = LCA.lowestCommonAncestor(root, a, b);
            if (result != null)
            {
                Console.WriteLine("\n\nThe lowest common ancestor for {0} and {1} is {2}.", a, b, result.Data);
            }
            else
            {
                Console.WriteLine("\n\nThe lowest common ancestor for {0} and {1} in the tree doesn't exists", a, b);
            }
            Console.ReadLine();
        }
    }
}