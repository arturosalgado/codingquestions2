using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RatesOfGrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 20;

            Console.WriteLine("Exponential");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} 2^{2} = {1}",i,Math.Pow(2,i),i);
            }
            Console.ReadKey();
            Console.WriteLine("Logaritmic");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} log i  = {1}", i, Math.Log(i));
            }
            Console.ReadKey();

            Console.WriteLine("Cubic ");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} i^3 {1}", i, i*i*i);
            }
            Console.ReadKey();

            Console.WriteLine("Cuadratic ");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} i^3 {1}", i, i * i);
            }
            Console.ReadKey();

            Console.WriteLine("Linear ");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} i*1 {1}", i, i * 1);
            }
            Console.ReadKey();

            Console.WriteLine("Linear Logarithmic ");
            for (int i = 0; i < Max; i++)
            {
                Console.WriteLine(" i = {0} nLogn {1}  ", i, i*Math.Log(i));
            }
            Console.ReadKey();

        }


    }
}
