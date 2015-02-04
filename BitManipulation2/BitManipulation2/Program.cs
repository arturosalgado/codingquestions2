using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine(" 8  is {0} in binary", p(5));
            for (int t = 128; t > 0; t = t / 2)
            {
                //Console.WriteLine(" t is {0} in binary {1}",t, p(t) );
                //Console.WriteLine(" t & 8 {0}", p(t&num));
                if ((t & num)==0) {
                    Console.Write(" [{0}]",0);    
                }
                if ((t & num) != 0)
                {
                    Console.Write(" [{0}]", 1);
                }

            }
            Console.WriteLine();
            for (int n = 1; n <= 128; n = n * 2)
            {
                //Console.WriteLine(" t is {0} in binary {1}",t, p(t) );
                //Console.WriteLine(" t & 8 {0}", p(t&num));
                if ((n & num) == 0)
                {
                    Console.Write(" [{0}]", 0);
                }
                if ((n & num) != 0)
                {
                    Console.Write(" [{0}]", 1);
                }

            }

            Console.ReadKey();

        }
        static string p(int p)
        {
            return Convert.ToString(p, 2).PadLeft(16,'0') ;
        }
    }
}
