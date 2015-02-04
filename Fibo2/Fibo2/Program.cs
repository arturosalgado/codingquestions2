using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibo2
{
    class Program
    {
        static void Main(string[] args)
        {

            printFibo(3,3);
            Console.ReadKey();

        }
        static void printFibo(int start, int length)
        {
            for (int i = start; i < start + length;i++ )
                Console.WriteLine("for i={0} fibo is ={1}", i, fibo(i));

        }

        static int fibo(int n)
        {

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return fibo(n-1) + fibo(n - 2);
            
        }
    }
}
