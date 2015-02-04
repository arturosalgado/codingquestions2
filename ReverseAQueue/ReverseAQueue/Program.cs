using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseAQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            reverse(q);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.ReadKey();

        }

        static void reverse(Queue<int> q)
        {
            Stack<int> stack = new Stack<int>();
            while (q.Count > 0)
            {
                stack.Push(q.Dequeue());
            }
            while(stack.Count>0)
            {
                q.Enqueue(stack.Pop());
            }
        }

    }
}
