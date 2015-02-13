using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node l = createList();
            print(l);
            largest(l);
            Console.ReadKey();


        }
        static Node largest(Node t)
        {
            Node p = t;

            Dictionary<int,int> dict = new Dictionary<int,int>();
            int index = 0;
            int best = 0;
            while (true)
            {
                if (!dict.ContainsKey(p.Value))
                {
                    dict.Add(p.Value, index);
                }
                else {
                    int temp = (index-1)-dict[p.Value];
                    if (temp > best)
                        best = temp;
                    Console.Write("Longest {0}",temp);
                }
                p = p.Next;

                if (p == t) break;
                index++;
            }
            Console.Write("Best {0}",best);
            return p; 
        }
        static void print(Node n)
        {
            Node p = n;
            while (true) {

                Console.Write(" {0} ",p.Value);
                p = p.Next;
                if (p == n) break;
            }
        
        }
        static Node createList()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
          

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n1;

            return n1;
        }
    }

    class Node {

        public int Value;
        public Node Next;
        public Node(int v) {
            this.Value = v;
        }
    
    }
}
