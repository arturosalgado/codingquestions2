using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);

            Node n4 = new Node(4);
            Node n5 = new Node(5);

            Node n10 = new Node(10);
            Node n11 = new Node(11);

            Node n7 = new Node(7);
            Node n8 = new Node(8);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            n10.Next = n11;

            n5.Next = n10;

            n7.Next = n8;

            n8.Next = n10;

            n1.print();
            n7.print();

            Node p = intersection(n1, n7);
            Console.WriteLine("Intersection at {0} ",p.Value);
            Console.ReadKey();
        }



        static Node intersection(Node a, Node b)
        {
            int LengthA = 0;
            int LengthB = 0;
            Node c = a;
            while (c != null)
            {
                c = c.Next;
                LengthA++;
            }
            c = b;
            while (c != null)
            {
                c = c.Next;
                LengthB++;
            }

            Console.WriteLine("Length of A {0} , Length of B {1}", LengthA, LengthB);
            if (LengthA > LengthB)
            {
                for (int i = 0; i < LengthA - LengthB; i++)
                {
                    a = a.Next;
                }
            }
            else if (LengthB > LengthA)
            {
                for (int i = 0; i < LengthB - LengthA; i++)
                {
                    b = b.Next;
                }
            }
            Console.WriteLine(b.Value);
            // at this point a and b are equal in sizes

            while (a != b && a != null && b != null)
            {
                a = a.Next;
                b = b.Next;

            }
            return a;



            
        }
    }

    class Node
    {
        public int Value;
        public Node Next;
        public Node(int val)
        {
            this.Value = val;
        }

        public void print()
        {
            Node t = this;
            while (t != null)
            {

                Console.Write("{0}-> ", t.Value);
                t = t.Next;
            }
            Console.Write("NULL"); Console.WriteLine();
        }
    }
}
