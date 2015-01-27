using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinekedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Circular list = new Circular();
           // list.insertFirst(8);
            //list.insertFirst(9);
            //list.insertFirst(10);
            list.insertFirst(7);
            list.insertLast(2);
            list.insertLast(1);
            list.insertLast(5);
            list.insertLast(4);
            list.insertLast(7);
            list.insertLast(3);
            list.insertLast(9);
            list.insertLast(1);



            list.traverse();
            Console.ReadKey();

        }
    }

    class Circular {

        Node head;
        Node tail;

        public void insertFirst(int val)
        {
            Node n = new Node(val);
            if (head == null)
                head = n;
            else
            {
                Node t = head;
              
                while (t.Next != head)
                {
                    t = t.Next;
                }
                t.Next = n;
                n.Next = head;
                head = n;

            }


        }
        public void insertLast(int val)
        {
            Node n = new Node(val);
            if (head == null)
                head = n;
            else
            {
                Node t = head;

                while (true)
                {
                    t = t.Next;
                    if (t.Next == head) break;
                }
                t.Next = n;
                n.Next = head;
                head = n;
                
            }


        }
        public void traverse()
        {
          
            Node t = head;
            while (true)
            {
                
                Console.Write("{0}-> ", t);
                t = t.Next;
                if (t == head) break;
              
                
            }
            Console.WriteLine();
        }

        public void findLargestSeq()
        {

            Node t = head;
            Node p = head;
            List<int> list;
            int i = 0;
            int j = 0;
            while (true)
            {
                p = t.Next;


               
                if (t == head)
                {
                    break;
                }
            }
        
        }
        
    
    }
    class Node
    {

        public Node Next;
        public int Value;
        public Node(int val)
        {
            Value = val;
            this.Next = this;
        }
        public override string ToString()
        {
            return this.Value + "";
        }

    }
}
