using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 http://arturodelosangeles.com
 */
namespace LevelOrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = buidlTree();
            levelTraversal(n);
            Console.ReadKey();
        }
        static void levelTraversal(Node n)
        {
            Node p = n;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(p);
            while (queue.Count > 0)
            {
                Node t = queue.Dequeue();
                Console.Write("{0}  ",t.Value);
                if (t.Left != null)
                    queue.Enqueue(t.Left);
                if (t.Right != null)
                    queue.Enqueue(t.Right);
            }

        
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
        public override string ToString()
        {
            return "" + this.Value;
        }


    }
}
