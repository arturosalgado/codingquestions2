using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            List<LinkedList<int>> list = new List<LinkedList<int>>();
            list.Add(new LinkedList<int>());
            list[0].AddLast(1);// read, yes like array
            LinkedList<int> t = list[0];

        }
    }
}
