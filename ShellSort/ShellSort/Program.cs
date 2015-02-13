using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 6,5,4,3,2,1};
            p(a);
         //   Console.ReadKey();
            shellSort(a);
            p(a);
            Console.ReadKey();
            
        }
        static void p(int []a) {
            foreach (var k in a) {
                Console.Write("{0} ",k);
            }
            Console.WriteLine();
        }

        static void shellSort(int []a) {

            int[] gaps = { 1,2};
            int gapIndex = gaps.Length - 1; 
            int gap = gaps[gapIndex];

            while (gap>=1) {

                for (int i = gap; i < a.Length; i++) { 
                    
                    int temp = a[i];
                    int j = i; 
                    while(j >= gap && a[j - gap] > temp) {
				            a[j] = a[j - gap];
                            p(a);
				            j -= gap;
			        }
                    a[j] = temp;
                    Console.WriteLine();
                }
                gapIndex--;
                if (gapIndex >= 0)
                    gap = gaps[gapIndex];
                else
                    break;


            }
        }

    }
}
