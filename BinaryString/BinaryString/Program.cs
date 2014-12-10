using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryString
{
    class Program
    {
        static  int[] a = { 5,7};
        static void Main(string[] args)
        {
           
            print(a);
            binary(a.Length);
        }

        static void binary(int n)
        {
            if (n < 1)
                print(a);
            else {
                a[n-1]=0;
                binary(n-1);
                a[n - 1] = 1;
                binary(n - 1);
            }
        }

        static void print(int []a)
        {
            foreach (int p in a)
            {
                Console.Write("{0} ",p);
            }
            Console.WriteLine();
        }

    }

}
