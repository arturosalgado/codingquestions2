using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArraySubSetsOfSizeK
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void PrintSubSets(int[] array, bool[] used, int index, int size, int k)
        {
           if (size == k)
           {
                for(int i=0; i<array.Length;i++)
                {
                    if (used[i])
                        Console.Write(array[i]);
                }
           }
           if (index == array.Length)
           {
               return;
           }
        }
    }
}
