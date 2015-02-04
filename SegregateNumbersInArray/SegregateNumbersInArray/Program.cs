using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SegregateNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 45, 9, 8, 90, 3 };
            segregate(a);
            foreach (var t in a)
            {
                Console.Write("{0} ",t);
            }
            Console.ReadKey();

        }

        static void swap(int[] a, int p, int q)
        {
            int t = a[p];
            a[p]=a[q];
            a[q]=t;
        }

        static void segregate(int []a)
        {

            int left = 0;
            int right = a.Length - 1;

            while (left < right)
            {
                while (left < right  )
                {
                    if (a[left] % 2 == 0)
                        left++;
                    else break;
                }
                while (left < right)
                {
                    if (a[right] % 2 == 1)
                        right--;
                    else
                        break;
                }
                if (left < right)
                    swap(a,left,right);
            
            }

            
        }
    }
}
