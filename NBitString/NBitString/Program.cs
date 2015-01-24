using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NBitString
{
    class Program
    {
        static int []a = new int[2];
        static void Main(string[] args)
        {
            Binary(a.Length);
            Console.ReadKey();
        }

        static void Binary(int n)
        {
            if (n == 0) // base case , exit 
                p(a);
            else        // else, other wise it will go under-flow
            {
                a[n - 1] = 0;
                Binary(n - 1);
                a[n - 1] = 1;
                Binary(n - 1);
            }
        }
        static void p(int []a) {

            foreach (var t in a)
            {
                Console.Write(" {0}",t);
            }
            Console.WriteLine();
        }
    }
}
