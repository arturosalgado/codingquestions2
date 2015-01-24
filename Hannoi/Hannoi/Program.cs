using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hannoi
{
    class Program
    {
        static void Main(string[] args)
        {
            hannoi(2,'a','b','x');
            Console.ReadKey();
        }

        static void hannoi(int n, char from, char to, char aux)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disc from {0} to {1}",from,to);
                return;
            }
            hannoi(n-1,from, aux,to);
                Console.WriteLine("Move disc from {0} to {1}", from, to);
            hannoi(n - 1, aux, to, from);




        }
    }
}
