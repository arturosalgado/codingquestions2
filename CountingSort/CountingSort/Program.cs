using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 1,1,1,0,0};
            p(a);
            CountingSort(a,1);
            p(a);
            Console.ReadKey();

        }

        static void CountingSort(int []a, int k)
        { 
            int [] possible = new int[k+1];
            for (int t = 0; t < a.Length; t++)
            {
                int number = a[t];
                possible[number]++;
            }
            p(possible);
            int index_a = 0;
            for (int q = 0; q <= k; q++) {
                for (int r = 0; r < possible[q]; r++)
                {
                    a[index_a] = q;
                    index_a++;
                }
            }
        }

        static void p(int []a) {

            foreach (int t in a) {
                Console.Write("{0} ",t);
            }
            Console.WriteLine();

        }

    }
}
