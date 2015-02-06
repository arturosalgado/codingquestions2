using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsK
{
    class Program
    {
        static string[] a={"a","b"}; 
        static void Main(string[] args)
        {
            k_string(a.Length,3);
            Console.ReadKey();

        }
        static void k_string(int n,int k)
        {
            if (n == 0)
            {
                print_s(a);
            }
            else {

                for (int i = 0; i < k; i++) {
                    a[n - 1] = ""+i+"";
                    k_string(n-1,k);
                }
            }
        }

        static void print_s(string []s) {

            foreach (var c in s) {
                Console.Write("{0} ",c);
            }
            Console.WriteLine("");
        }
    }
}
