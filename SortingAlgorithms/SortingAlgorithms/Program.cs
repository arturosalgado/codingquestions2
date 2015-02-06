using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {4};
            foreach (var t in a)
            {
                Console.Write("{0} ", t);
            }
            SelectionSort(a);
            foreach (var t in a) {
             Console.Write("{0} ",t);
            }
            Console.ReadKey();

        }

        static void SelectionSort(int []a)
        {
            int min = 0;


            for (int runner = 0; runner < a.Length; runner++ )
            {
                int t = runner;
                while (t < a.Length)
                {
                    if (a[t] < a[min])
                    {
                        min = t;
                    }
                    t++;
                }
                swap(a, runner, min);// temporarily arbitrarily at 0
            }

        }
        static void swap(int []a, int p, int q)
        {
            int temp = a[p];
            a[p] = a[q];
            a[q] = temp;
        }


    }
}
