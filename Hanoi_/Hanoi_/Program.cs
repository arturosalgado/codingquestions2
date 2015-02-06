using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(2,"A","B","Temp");
            Console.ReadKey();
        }

        static void Hanoi(int n, string from, string to, string aux)
        {
            if (n == 1) {
                Console.WriteLine("Move disc from {0} to {1}", from, to);
                return;
            }
            Hanoi(n - 1, from, aux, to);
            Console.WriteLine("Move disc from {0} to {1}", from, to);
            Hanoi(n - 1, aux, to, from);

        }
    }
}
