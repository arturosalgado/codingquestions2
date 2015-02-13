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
            int []a = {6,2,5,4,1,0,9};
            int[] b = {1,2,3,4,5,6 };
            p(b);
            bubbleSort(b);
            p(b);
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
                swap(a, runner, min);
            }

        }
        static void swap(int []a, int p, int q)
        {
            int temp = a[p];
            a[p] = a[q];
            a[q] = temp;
        }

        static void insertionSort(int []a)
        {
            for (int i = 1; i < a.Length; i++) {

                int j = i;
                shift(a,j);

            }
        }

        static void bubbleSort(int[] a)
        {
            bool swapped = false;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1-i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }
        }

        static void shift(int []a, int j) {

            int t = a[j];
            while (j > 0 && a[j-1]>t) {

                a[j] = a[j - 1]; 
                j--;
            
            }
            a[j] = t;
        }

        static void p(int []a) {
            foreach (var t in a)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();
        }

    }
}
