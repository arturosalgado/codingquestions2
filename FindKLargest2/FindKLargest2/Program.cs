using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindKLargest2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8,12,6,1,3,2};
            Console.WriteLine("{0}",Find(nums,3));
            Console.ReadKey();

        }
        static int Find(int []nums, int k)
        {
            if (k > nums.Length - 1 || k <= 0)
                return -1;

            return Find(nums,0, nums.Length-1,k);
        }

        static int Find(int []nums, int start, int end, int k)
        {
            p(nums,start,end);

            int left = start;
            int right = end;
            int pivot = (start+end)/2;
            Console.WriteLine("pivot {0} value {1}",pivot,nums[pivot]);
            Console.ReadKey();
            while (left <= right)
            {

                while (left <= right && nums[left] <= nums[pivot])
                    left++;
                while (left <= right && nums[right] >= nums[pivot])
                    right--;

                if (left < right)
                {
                    Swap(nums,left, right);
                }
            
            }
            Swap(nums,pivot,right);

            if (k == right + 1)
                return nums[right];
            else if (k > right + 1)
                return Find(nums, right + 1, end, k);

            else
                return Find(nums, start, right-1, k);
        }

        static void Swap(int[] nums, int left, int right)
        {
            Console.WriteLine("Before swap");
            p(nums);
            Console.ReadKey();
            int t = nums[left];
            nums[left] = nums[right];
            nums[right] = t;
            Console.WriteLine("After  swap");
            p(nums);
            Console.ReadKey();
        }

        static void p(int []nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ",nums[i]);
            }
            Console.WriteLine("");
        }

        static void p(int[] nums, int start, int end)
        {

            for (int i = start; i <=end; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine("");
        }
    }
}
