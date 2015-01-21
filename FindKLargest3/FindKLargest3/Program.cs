using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindKLargest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 8,12,6,1,3};

            Console.WriteLine("{0}",Find(a,3));
            Console.ReadKey();
        }
        static int Find(int []a , int k)
        {
            if (k <=0 || k> a.Length-1)
            return -1;
            return Find(a,0, a.Length-1, k);
        }
        static int Find(int[] a, int start, int end, int k)
        {
            int left = start;
            int right = end;
            int pivot = (start + end) / 2;

            while (left <= right)
            {
                while (left <= right && a[left] <= a[pivot])
                    left++;
                while (left <= right && a[right]>= a[pivot])
                    right--;
                if (left < right)
                {
                    Swap(a,left,right);
                }
            }

            Swap(a, right, pivot);
            if (k == right + 1) return a[right];
            else if (k > right + 1) return Find(a, right + 1, end, k);
            else return Find(a, start, right-1,k);
            
        }

        static void Swap(int [] nums , int p, int q)
        {
            int t = nums[p];
            nums[p] = nums[q];
            nums[q] = t;
        }

    }
}
