using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsNlogN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 1 ,6,0,7};
            p(a);
            int []c = mergeSort(a);
            //int[] c = copy(a,0,a.Length);
            p(c);

            { }
            Console.ReadKey();

        }
        static int []  mergeSort(int[] a )
        {
                if (a.Length == 1) return a;

                int start = 0;
                int end = a.Length;
                int mid = (start + end) / 2;
                int[] x = copy(a, start, mid);
                int[] y = copy(a, mid, end);
                int []p = mergeSort(x);
                int []q = mergeSort(y);
                

                int[] w = merge(p, q);
                return w;
           
        }



        static int [] copy(int []a , int p, int q)
        {

               if (a.Length == 1) return a;

            
               int length = q - p;

               int []c = new int[length];
               for (int t = 0; t < length; t++)
               {
                   c[t] = a[p];
                   p++;
               }

                   return c;
        }

        static void p(int[] a)
        {
            foreach (var t in a)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();
        }
        static int [] merge(int []a , int []b)
        { 
            int []c = new int[a.Length+b.Length];
            int indexa = 0;
            int indexb = 0;
            int indexc = 0;
            while (indexa<a.Length && indexb<b.Length)
            {
                if (a[indexa] < b[indexb])
                {
                    c[indexc] = a[indexa];
                    indexc++;
                    indexa++;
                    
                }
                else{ 
                    c[indexc] = b[indexb];
                    indexb++;
                    indexc++;
                }
            }
            while (indexa < a.Length) {

                c[indexc++] = a[indexa++];
                

            }
            while (indexb < b.Length)
            {

                c[indexc++] = b[indexb++];
              

            }

            return c;

        }
    }
}
