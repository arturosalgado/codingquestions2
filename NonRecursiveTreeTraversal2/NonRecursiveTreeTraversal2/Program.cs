using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonRecursiveTreeTraversal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = buidlTree();
            traverseRecursion(n);
            Console.WriteLine("");
            traverseNoRecursion(n);
            Console.WriteLine("");
            traverseRecursionPreOrder(n);
            Console.WriteLine("");
            traverseNoRecursionPreOrder(n);


            Console.ReadKey();
        }

        static void traverseNoRecursion(Node n)
        {

            Node current = n;
            Stack<Node> stack = new Stack<Node>();
            while(current!=null || stack.Count>0)
            {
                if (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                else {

                    current = stack.Pop();
                    Console.Write("{0} ",current.Value);
                    current = current.Right;
                
                }
            }


        }
        static void traverseNoRecursionPreOrder(Node n)
        {

            Node current = n;
            Stack<Node> stack = new Stack<Node>();
            while (current != null || stack.Count > 0)
            {
                if (current != null)
                {
                    Console.Write("{0} ", current.Value);
                    stack.Push(current);
                    current = current.Left;
                }
                else
                {

                    current = stack.Pop();
                    current = current.Right;

                }
            }


        }
        static void traverseRecursion(Node p)
        {
            Node n = p;

            if (n == null)
            {
                return;
            }
            traverseRecursion(n.Left);
            Console.Write("{0} ", n.Value);
            traverseRecursion(n.Right);
        }
        static void traverseRecursionPreOrder(Node p)
        {
            Node n = p;

            if (n == null)
            {
                return;
            }
            Console.Write("{0} ", n.Value);
            traverseRecursionPreOrder(n.Left);
            traverseRecursionPreOrder(n.Right);
        }


        static Node buidlTree()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            //       1
            //    2       3
            // 4
            n1.Left = n2;
            n1.Right = n3;
            n2.Left = n4;
            return n1;
        }

    }
    class Node
    {

        public Node Right;
        public Node Left;
        public int Value;

        public Node(int Value)
        {
            this.Value = Value;
        }



    }
}
