using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.insertFirst(1);
            l.insertFirst(2);
            l.insertFirst(3);
            l.insertFirst(4);
            l.insertFirst(5);
            l.traverse();
            l.deleteAt(1);
            l.traverse();
 

            Console.ReadKey();
        }
    }

    class LinkedList {
        Node head; 

        public void insertFirst(int value)
        {
            Node n = new Node(value);
            if (head == null)
            {
                head = n;
            }
            else {                                                                           
                n.Next = head;
                head = n;
            }

        }
        public void aheadbyOne()
        {
            Node p = head;
            Node q = head;
            while(p!=null)
            {
                q = p;
                p = p.Next;
            }

        }
        public void insertAt(int value, int position)
        {
            if (position <= 0)
                throw new Exception();


            Node n = new Node(value);
            int index = 1; // index starts at one, if null, we already have our 1. Else if position 1, special case. For all other cases index 1 is adequate. 
            if (head == null) // regardless of position, it will be the first node
            {
                head = n;
                return;
            }
            else {
                if (position == 1 ) // just update the head
                {
                    n.Next = head;
                    head = n;
                    return;
                }


                Node t = head;// we need the front runner
                Node back = t;
                while (t != null && index< position)
                {
                    back = t;
                    t = t.Next;
                    index++;
                }
                n.Next = t;
                back.Next = n;
              



            }


        }
        public void insertLast(int value)
        {
            Node n = new Node(value);
            if (head == null)
            {
                head = n;
            }
            else
            {
                Node t = head;
                while (t.Next != null)
                {
                    t = t.Next;
                }
                t.Next = n;
            }

        }

        public void deleteFirst()
        {
            if (head==null) return; // important. Delete only if it makes sense

            Node t = head;
            head = head.Next;
            t = null;
        }
        public void deleteAt(int position)
        {
            Node t = head;
            Node back = t;
            int index = 1; 
            while(t!=null && index< position)
            {
                back = t;
                t = t.Next;
                index++;
            }
            if (back != null && t!=null)
            {
                back.Next = t.Next;
                t = null;
            }


        }
        public void deleteLast()
        {
            if (head == null) return;

            if (head.Next == null)
            {
                head = null;
                return;
            }

            Node t = head;
            Node back = t;
            while (t.Next != null)
            {
                back = t;
                t = t.Next;    
            }
            //t = null; doesn't work. we need back.next= null;
            back.Next = null;

        }

        public void traverse()
        {
            Node t = head;
            while (t != null)
            {
                Console.Write("{0}-> ",t);
                t = t.Next;
            }
            Console.WriteLine();
        }

    }

    class Node {

        public Node Next;
        public int Value;
        public Node(int val)
        {
            Value = val;
        }
        public override  string ToString()
        {
            return this.Value+"";
        }
    
    }

}
