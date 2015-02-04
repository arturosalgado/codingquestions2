using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 1;
            int c = a ^ b;
            int d = 5;
            d = ~d;
            Console.WriteLine(Pad(a));
            Console.WriteLine(Pad(b));
            Console.WriteLine(Pad(c));
            Console.WriteLine(Pad(d));
            Console.WriteLine(d);

            Console.ReadKey();
            Console.WriteLine("E is  ");
            int t = 0xFFFE;
            Console.WriteLine("E is  {0}",Pad(t));
            Console.ReadKey();
            int num = 9 ;

            for (int i = 0; i < 10; i++ )
            {
                num = i;
                Console.WriteLine("Num is   {0}", Pad(num));
                num = num & t;
                Console.WriteLine("Num new is  {0} which is {1}", Pad(num), num);
            }

           
            Console.ReadKey();
            Console.WriteLine("Is odd");
            uint p = 10;
            uint q = 1;
            Console.WriteLine("Binaray representation of {0} is {1}",p,Pad(p));
            Console.WriteLine("Binaray representation of {0} is {1}",q, Pad(q));

            if ((p & q) == 1)
            {
                Console.WriteLine("p and q {0} odd ", Pad(p & q));
            }
            else {
                Console.WriteLine("p and q {0} even", Pad(p & q));
            }



            Console.ReadKey();

        }

        static string Pad(int b)
        {
            return Convert.ToString(b, 2).PadLeft(32, '0');
        }
        static string Pad(uint b)
        {
            return Convert.ToString(b, 2).PadLeft(32, '0');
        }
    }
}
