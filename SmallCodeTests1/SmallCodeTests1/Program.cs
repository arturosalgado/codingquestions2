using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallCodeTests1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {0,1};
            traverse(a);        
        }
        static void traverse(int []a )
        {
            for (int t = 0; t < a.Length; t++)
            {
                for (int p =t+1 ; p <a.Length; p++)
                {
                    Console.Write("a [i] {0} a[j] {1} ", a[t],a[p]);
                }
                Console.WriteLine();
            }
        }
    }
}
