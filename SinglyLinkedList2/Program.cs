using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList2
{

    public class Node
    {

        private object data;
        private Node next;

        public Node()
        {
            data = null;
            next = null;
        }

        public Node(object o)
        {
            data = o;
            next = null;
        }

        public Node(object o, Node n)
        {
            data = o;
            next = n;
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }


        //public void setData(object o)
        //{
        //    data = o;
        //}

        //public object getData()
        //{
        //    return data;
        //}


        //public void setNextNode(Node n)
        //{
        //    next = n;
        //}

        //public Node getNextNode()
        //{
        //    return next;
        //}

    }

    public class SinglyLinkList
    {
        //Add(object)
        //Add(position, object)
        //remove
        //isEmpty
        //isFull
        //replace(position,object)
        //getentry
        //contains
        //clear
        //getLength

        private Node headNode;

        public bool add(int position, object newEntry)
        {
            Node tmp = headNode;
            if (position >= 1)
            {
                Node newNode = new Node(newEntry);
                if (isEmpty())
                {
                    newNode.setNextNode(tmp);
                    headNode = newNode;
                    return true;
                }
                else
                {
                    for (int i = 0; i < position-1 && tmp !=null ; i++)
                    {
                        tmp = tmp.getNextNode();
                    }
                    if (tmp == null)
                    {
                        return false;
                    }

                    newNode.setNextNode(tmp.getNextNode());
                    tmp.setNextNode(newNode);
                    return true;
                }
            }
            else
            {
                return false;

            }
        }
        public bool add(object newEntry)
        {
            return add(getLength() + 1, newEntry);
        }

        public object Remove(int position)
        {
            object tmpObj = null;
            if (isEmpty() || position < 1)
            {
                return null;
            }

            Node currentNode = headNode;

            if (position == 1)
            {
                tmpObj = currentNode.Data;
                headNode = currentNode.Next;
            }
            else
            {
                for (int i = 0; i < (position - 1) && currentNode != null; i++)
                {
                    currentNode = currentNode.Next;
                }
                if (currentNode == null)
                {
                    return null;
                }
                tmpObj = currentNode.Next.Data;
                currentNode.Next = currentNode.Next.Next;
            }
            return tmpObj;
        }

        private int getLength()
        {
            return 0;
        }

        public bool isFull()
        {
            return false;
        }

        public bool isEmpty()
        {
            return (headNode == null);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
