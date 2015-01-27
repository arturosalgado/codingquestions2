using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] s = new string[]{
            "Hello",
            "World"
            };
            string[] s2 = { "Hello", "World"};
            Dictionary<string, bool> dict1 = s.ToDictionary(item=>item,item=>true); 

            foreach(var v in dict1)
            {
                Console.WriteLine("{0} {1}",v.Key,v.Value);
            }

            Console.WriteLine("Dictionary used as associative array");

            Dictionary<string,int> d = new Dictionary<string,int>();

            d["one"] = 1;
            d["eins"] = 1;
            d["zwei"] = 2;
            d["two"] = 2;

            foreach (KeyValuePair<string,int> p in d)
            {
                Console.WriteLine("key {0} has value {1}",p.Key,p.Value); 
            }
            Console.WriteLine("Lets try to read a key that doesn't exists");
            //rises exeption
            //Console.WriteLine("key five has value {1}", d["five"]); 
            Console.WriteLine("key eins has value {0}", d["eins"]); 
            Console.ReadKey();
        }
    }
}
