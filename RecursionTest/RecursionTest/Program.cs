using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            recursion(3);
        }

        static void recursion(int i)
        {
            Console.WriteLine("i = {0}",i);
            Console.ReadKey();
            if (i <= 0)
                return;
            recursion(i-1);
            recursion(i-1);
            Console.WriteLine("going back");
          
        }
    }
}
