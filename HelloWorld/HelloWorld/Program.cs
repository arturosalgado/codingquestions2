using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arturo");
            int[] a = {6,5,4,3};
            shift(a,2);
            //InsertionSort2(a);
            foreach (var t in a) {
                Console.Write("{0} ",t);
            }
            Console.ReadKey();

        }

        static void InsertionSort(int []a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int e = a[i];
                int j = i;
                while(j > 0 && a[j-1]>e){
                    a[j]= a[j-1];
                    j--;
                }
                a[j] = e;
            }
        }
        static void InsertionSort2(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            { 
                int e = a[i];
                int j = i;
                while(j>0 && e<a[j-1])
                {
                    a[j]=a[j-1];
                    j--;
                }
                a[j] = e;
                //p(a);
            }
        }

        static void shift(int[] a, int j)
        {
            p(a);
            while(j>0){
                a[j]= a[j-1];
                j--;
                p(a);
                //Console.ReadKey();
            }

        }

        static void p(int []a)
        {
            foreach (var t in a)
            {
                Console.Write("{0} ", t);
            }
            Console.WriteLine();
        }



    }
}
