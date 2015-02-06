using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoveLinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = createList2();
            traverse(n);

            n = remove2(n,2);
            Console.WriteLine("After remove");
            traverse(n);
            Console.ReadKey();

        }

        static Node createList()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n2_1 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);

            n1.Next = n2;
            n2.Next = n2_1;
            n2_1.Next = n3;
            n3.Next = n4;
            return n1;

        }
        static Node createList2()
        {
            Node n1 = new Node(3);
            Node n2 = new Node(4);
            Node n2_1 = new Node(4);
            Node n3 = new Node(5);

            Node n4 = new Node(2);

            n1.Next = n2;
            n2.Next = n2_1;
            n2_1.Next = n3;
            n3.Next = n4;
            return n1;
         }

        static Node remove(Node n, int val)
        { 
            Node p = n;
            Node q = n;

            while (p!=null && p.Value == val) // first element 
            {

                n = n.Next;
                p = n;
             
               
            }

            while (p != null)
            {
                if (p.Value == val)
                {
                    Node t = p;
                    p = t.Next;
                    q.Next = t.Next;
                    continue;

                }


                q = p;
                p = p.Next;
                
            }

           

            return n;
            
        }
        static Node remove2(Node n, int val)
        {
            Node p = n;
            Node q = n;

            q = new Node(0);
        
            q.Next = p;
            n = q;

            while (p != null)
            {
                if (p.Value == val)
                {
                    Node t = p;
                    p = t.Next;
                    q.Next = t.Next;
                    continue;

                }


                q = p;
                p = p.Next;

            }



            return n.Next;

        }

        static void traverse(Node n)
        {
            Node p = n;
            while (p != null)
            {
                Console.Write("{0}->",p.Value);
                p = p.Next;

            }

            
        }

    }
    class Node {

        public int Value;
        public Node Next;
        public Node(int value)
        {
            this.Value = value;
        }

    }
}
