using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {1,2,3};
            foreach (int t in a) {
                Console.Write("{0} ",t);
            }
            quickSort(a,0, a.Length-1);
            Console.WriteLine();
            foreach (int t in a)
            {
                Console.Write("{0} ", t);
            }
            Console.ReadKey();

        }
        static void quickSort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int mypartition = partition(a,start,end);
                quickSort(a,start,mypartition-1);
                quickSort(a,mypartition+1,end);
            }
            
        }
        static int partition(int[] a, int start, int end)
        {
            int left=start;
            int right=end;
            int pivot = start;
            int item = a[start];
            while (left < right)
            {
                while (a[left] <= a[pivot] && (left < right))
                    left++;
                while (a[right] > a[pivot])
                    right--;
                if (left < right)
                {
                    swap(a, left,right);
                }

            }
            a[start] = a[right];
            a[right] = item;
            return right;
        }

        static void swap(int []a,int p, int q) {

            int t = a[p];
            a[p] = a[q];
            a[q] = t;
        }
    }


}
