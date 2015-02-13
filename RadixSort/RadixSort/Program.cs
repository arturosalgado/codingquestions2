using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a = {143,133,1111,8765,4532,9087,1235,6754,78};
            foreach (var t in a)
            {
                Console.Write(" {0} ", t);
            }
            Console.WriteLine();
            radixSort(a,4);
            foreach (var t in a) {
                Console.Write(" {0} ", t);
            }
            Console.ReadKey();
        }


        static void radixSort(int []a, int maxNumberOfDigits=3)
        {

            LinkedList<int> [] buckets = new LinkedList<int>[10];
            initBuckets(buckets);
            int reference = 1;
            for (int i = 0; i < maxNumberOfDigits; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    int temp = getLeast(a[j], reference);

                    
                    buckets[temp].AddLast(a[j]);
                }
                reference = reference * 10;
               

                // re organize the array
                int index2 = 0;
                for (int r = 0; r < buckets.Length; r++) {

                    LinkedList<int> temp;
                    temp = buckets[r];
                    if (temp.Count>0) { 
                    
                       
                        foreach (var node in temp)
                        {
                            a[index2++] = node;
                            
                        }
                    
                    }

                }
                initBuckets(buckets);
            }
           

            
        }

        static int getLeast(int digit, int reference)
        { 
            //reference 10 actually gets the units

            int t = digit / reference;

            int result = t % 10;


            return result;
        }

        static void initBuckets(LinkedList<int>[] buckets)
        {
            for (int i = 0; i < 10; i++ )
            {
                buckets[i]=new LinkedList<int>();
            }
        }
    }
}
