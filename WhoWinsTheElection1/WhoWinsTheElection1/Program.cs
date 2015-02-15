using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWinsTheElection1
{
    class Program
    {
        static void Main(string[] args)
        {
            int []a ={1,3,4,5,5,6,5,5,2,3,1,4,2,1};
            Console.WriteLine("winner {0}", winner(a));
            Console.ReadKey();
        }

        static int winner(int[] a)
        {
            int count=0;
            int max=0;
            int candidate=0;
            for(int p =0; p<a.Length; p++)
            {
                count = 0;
                for(int j = p + 1; j < a.Length; j++) {
                    if (a[p] == a[j])
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    candidate = a[p];//stays with it, until a new max comes
                }
            }

            return candidate;
        }
    }
}
