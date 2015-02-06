using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isArraySorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,3,5,9};
            Console.WriteLine(isSorted(a,a.Length-1));
        }


        static bool isSorted(int [] a, int index)
        {
            Console.WriteLine(a[index]);
            if (index == 0)
                return true;

            if (a[index] < a[index - 1]) return false;

           return isSorted(a,index - 1);
           

        }
    }
}
