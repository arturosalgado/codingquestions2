using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListInterweave
{
    class Program
    {
        static void Main(string[] args)
        {

            Node t = createList();
            Node q = createList();
            Node merged= merge(t,q);
            p(merged);
            Console.ReadKey();
        }

        static Node reverse(Node p)
        {
            if (p == null || p.Next == null)
                return p;

            Node t = reverse(p.Next);
            p.Next.Next = p;
            p.Next = null;
            return t;
            
        }
        static Node merge(Node p, Node q)
        {
            int turn = 0; 
            Node current; 
            Node merged = new Node(0);
            current= merged;
            while (p != null && q != null)
            {
                if (turn == 0)
                {
                    current.Next = p;
                    p = p.Next;
                    turn = 1;
                }
                else {
                    current.Next = q;
                    q = q.Next;
                    turn = 0;
                }
                current = current.Next;
            }
            if (p != null)
                current.Next = p;
            if (q != null)
                current.Next = q;


            return merged.Next; 
        }
        static Node findMid(Node p) {
            Node fast = p;
            Node slow = p;

            while (fast != null && fast.Next != null)
            {
               
                fast = fast.Next.Next;
                slow = slow.Next;
                
            }
            //Console.WriteLine("Fast {0} Slow {1} ", fast.Value, slow.Value);
            Console.ReadKey();

            return slow;
        }
        static void p(Node p)
        {

            Node t = p;
            while (t != null)
            {
                Console.Write(" {0} -> ",t.Value);
                t = t.Next;
            }
            Console.WriteLine("");


        }
        static Node createList()
        {
            Node []nodes= new Node[100];
            for (int i = 0; i < 100; i++)
            {
                nodes[i] = new Node(i);
                if (i>0)
                nodes[i - 1].Next = nodes[i];    
            }
            

            return nodes[0];
        
        }

    }

    class Node {

        public Node Next;
        public int Value; 
        public Node(int v)
        {
            this.Value = v;
        }
    
    }

}
