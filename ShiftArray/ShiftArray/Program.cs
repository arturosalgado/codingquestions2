using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShiftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,4,5,6 };
            int[] b = { 1, 2, 3, 4, 5, 6 };
            pa(a);
            shiftLeft(a,1);
            pa(a);
            pa(b);
            shiftRight(b,3);
            pa(b);
            Console.ReadKey();

        }
        static void shiftLeft(int []a ,int k) {
            for (int j = 0; j < k; j++)
            {
                int temp = a[0];

                for (int i = 0; i < a.Length - 1; i++)
                {
                    a[i] = a[i + 1];
                }

                a[a.Length - 1] = temp;
            }

        }
        static void shiftRight(int[] a, int k)
        {
           
            for (int j = 0; j < k; j++)
            {
                int temp = a[a.Length-1];

                for (int i = a.Length-1; i>0; i--)
                {
                    a[i] = a[i - 1];
                }

                a[0] = temp;
            }

        }

        static void pa(int []a)
        {

            foreach (var p in a)
            {
                Console.Write("{0} ",p);
            }
            Console.WriteLine();

        }
        
    }
}
