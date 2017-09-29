using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
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

            public Node(int d)
            {
                data = d;
                leftChild = null;
                rightChild = null;
            }
            public Node(Node lc, int d, Node rc)
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

        public class BST
        {
            Node root;

            public BST()
            {
                root = null;
            }

            public void Add(int data)
            {
                root = Add(root, data);
            }

            private Node Add(Node root, int data)
            {

                if (root == null)
                {
                    root = new Node(data);
                }
                else if (root.Data > data)
                {
                    root.LeftChild = Add(root.LeftChild, data);
                }
                else if (root.Data < data)
                {
                    root.RightChild = Add(root.RightChild, data);
                }
                return root;
            }
        }


        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Add(5);
            tree.Add(2);
            tree.Add(34);
            tree.Add(18);
            tree.Add(55);
            tree.Add(-1);
            tree.Add(-2);
        }
    }
}
