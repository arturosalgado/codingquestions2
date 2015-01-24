using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList l1 = new DoubleLinkedList();
            l1.insertFirst(2);
            l1.insertFirst(3);
            l1.insertLast(4);
            l1.insertLast(5);
            

            l1.traverse();
            l1.insertAt(8,2);
            l1.traverse();
            l1.backwards();
            Console.ReadKey();
        }
    }

    class DoubleLinkedList {
        Node head;
        Node Tail;

        public void insertFirst(int val)
        {
            Node n = new Node(val);
            if (head == null)
            {
                head = n;
                Tail = n;
                return;
            }
            else {
                n.Next = head;
                head.Prev = n;
                head = n;
            }
        }

        public void insertLast(int val)
        {
            Node n = new Node(val);
            if (head == null)
            {
                head = n;
                Tail = n;
                return;
            }
            else
            {
                Tail.Next = n;
                n.Prev = Tail;
                Tail = n;
            }
        }
        public void insertAt(int val, int position)
        {
            Node n = new Node(val);
            if (head == null)
            {
                head = n;
                Tail = n;
               
            }
            else if (position == 1)
            {
                n.Next = head;
                head.Prev = n;
                head = n;

            }
            else
            {
                Node t = head;
                int index = 1;
                while (t != null && index < position)
                {
                    t = t.Next;
                    index++;
                }
               
                if (t != null)
                {
                    n.Next = t;
                    n.Prev = t.Prev;
                    t.Prev = n;
                    n.Prev.Next = n;
                }


            }
            
        }
        public void traverse()
        {
            Node t = head;
            while (t != null)
            {
                Console.Write("<-{0}->",t);
                t = t.Next;
            }
            Console.WriteLine();
        }
        public void backwards()
        {
            Node t = Tail;
            while (t != null)
            {
                Console.Write("<-{0}->", t);
                t = t.Prev;
            }
            Console.WriteLine();
        }
        

    }

    class Node {
        public int Value;
        public Node Next;
        public Node Prev;
        public Node(int val)
        {
            Value = val;
        }
        public override string ToString()
        {
            return "" + this.Value;
        }

    }
}
