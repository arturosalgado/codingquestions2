using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heaps2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a =  { 1,3,6,5,9,8};

            Console.WriteLine("Parent of {0} is {1} i.e.{2}",5,Parent(3),a[Parent(3)]);
            Console.WriteLine("Left  Child  of {0} is {1} {2}", 3, Left(1),a[Left(1)]);
            Console.WriteLine("Right Child  of {0} is {1} {2}", 1, Right(0),a[Right(0)]);

            Console.ReadKey();






        }

        static int Left(int i)
        {
            return i * 2 + 1;
        }
        static int Right(int i)
        {
            return i * 2 + 2;
        }
        static int Parent(int i)
        {
            return (i - 1) / 2;
        }



    }
    class Heap { 
        

    
    }
}
