using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = { 6,5,4,3,2,1};
            //int[] a = { 1,2,3,4,5,6 };
           // int[] a = { 1};
            foreach (var t in a)
            {
                Console.Write("{0} ", t);
            }
            insertionSort(a);
            Console.WriteLine();
            //swap(a,0,4);
            foreach (var t in a) {
                Console.Write("{0} ",t);
            }
            Console.ReadKey();
        }
        static void insertionSort(int []a)
        {
            for (int i = 1; i < a.Length; i++)
            { 
                    int j = i;
                    int e = a[i]; 
                    while (j > 0 && a[j-1] >e )
                    {
                        a[j] = a[j - 1];
                        j--;
                    }
                    a[j] = e;
            }
        }
        static void bubbleSort(int []a)
        {
            bool swapped = false;
            for (int j = 0; j < a.Length; j++)
            {
                
                for (int i = 1; i < a.Length-j; i++)
                {

                    if ( a[i - 1] > a[i])
                    {
                        swap(a, i, i - 1);
                        swapped = true;
                    }

                }
                if (swapped == false) {
                    Console.WriteLine("Sorted");
                    break;
                }
            }
        }

      
        static void swap(int[] a, int p, int q)
        {
            int t = a[p];
            a[p] = a[q];
            a[q] = t;
        }

        static void shiftArray()
        {
        
        }

    }
}
