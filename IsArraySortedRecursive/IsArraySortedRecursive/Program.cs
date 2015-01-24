using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsArraySortedRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3,4,5};
            traverse(a,a.Length-1);
            Console.WriteLine("ordered? {0}",traverse2(a,a.Length-1));
            Console.ReadKey();
        }
        static void traverse(int []a, int index)
        {
            Console.WriteLine("{0}", a[index]);
            if (index == 0) return;
            traverse(a,index-1);
        }

        static bool traverse2(int[] a, int index)
        {
            if (index == 0) return true;
            if (a[index-1] > a[index]) return false;
            return traverse2(a,index-1);

        }

    }
}
