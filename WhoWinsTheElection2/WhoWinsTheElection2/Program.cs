using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWinsTheElection2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2,1,1 };
            Console.WriteLine("winner-1 {0}", winner(a));
            Console.WriteLine("winner-2 {0}", winner2(a));

            Console.ReadKey();
        }
        static void pr(int[] a)
        {
            foreach (int t in a) {
                Console.Write(" {0}",t);
            }
        }
        static int winner(int[] a)
        {
            // sort by any means, take into account complexity
            Array.Sort(a);
            pr(a);
            int candidate = a[0];
            int counter =1;
            int max = 1;
            int maxCandidate = a[0];
            for (int p = 1; p < a.Length; p++)
            {
                if (a[p] == candidate)
                {
                    counter++;
                }
                else {
                    candidate = a[p];
                    counter = 1;
                    
                }

                if (counter > max)
                {
                    max = counter;
                    maxCandidate = candidate;
                }
            }

            return maxCandidate;
        }
        static int winner2(int[] a)
        {
            // sort by any means, take into account complexity
            Array.Sort(a);
            pr(a);
            int candidate = a[0];
            int counter = 1;
            int max = 1;
            int maxCandidate = a[0];
            for (int p = 0; p < a.Length; p++)
            {
                if (a[p] == candidate)
                {
                    counter++;
                    
                }
                else
                {
                    candidate = a[p];
                    counter = 1;
                   
                }

                if (counter > max)
                {
                    max = counter;
                    maxCandidate = candidate;
                }
               
            }

            return maxCandidate;
        }
    }
}
