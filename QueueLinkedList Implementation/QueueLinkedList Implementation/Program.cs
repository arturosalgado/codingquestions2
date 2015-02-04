using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueLinkedList_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue q = new Queue();
            q.enqueue(100);
            q.enqueue(200);
            q.enqueue(300);
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
            q.enqueue(400);
            q.enqueue(500);
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q.dequeue());
           
            Console.ReadKey();

        }
    }


    class Queue {

        Node front;
        Node rear;

        public bool Empty()
        {
            if (front == null)
                return true;
            return false;
        }

        public void enqueue(int value)
        {
            Node n = new Node(value);

            if (front == null)
            {
                front = n;
                rear = n;
            }
            else {

                rear.Next = n;
                rear = n;

            }
        }
        public int dequeue()
        {
            int n=-1;
            if (!Empty())
            {
                n = front.Value;
                front = front.Next;
            }
            return n;
        }
        
    
    }

    class Node
    {

        public Node Right;
        public Node Left;
        public Node Next;
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
