using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitManipulation3
{
    class Program
    {
        static void Main(string[] args)
        {

            int q = 1;
            p(q);
            q = q << 1;
            p(q);
            q = q << 1;
            p(q);
            q = q >> 2;
            p(q);
            Console.ReadKey();
        }
        static void p(int t)
        {
            Console.WriteLine("{0} is {1}",t,Convert.ToString(t,2).PadLeft(8,'0'));
        }

    }
}
