using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortTypical
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            foreach (int t in a)
            {
                Console.Write("{0} ", t);
            }
          
            Console.WriteLine();
            foreach (int t in a)
            {
                Console.Write("{0} ", t);
            }
            Console.ReadKey();

        }

        static void merge(int []a, int low, int  mid, int high)
        { 
            int []T = new int[high-low+1];
            int i = 0;
            int j = mid + 1;
            int k = 0;
            while (i < mid || j < high)
            { 
               // if (i>mid)
            }

        }
    }
}
