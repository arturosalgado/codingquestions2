using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("cat", 2);
            dict.Add("dog", 1);
            dict.Add("duck", 3);
            dict["dog"] = 10;//change the value


            Console.WriteLine("Contains Key");

            if (!dict.ContainsKey("monkey"))
            {
                dict.Add("monkey", 55);
            }

            foreach (var p in dict)
            {

                Console.WriteLine("{0} {1}", p.Key, p.Value);

            }
            Console.ReadKey();
            Console.WriteLine("Contains Value");

            if (dict.ContainsValue(55))
            {
                Console.WriteLine("Already has 55");
            }

            Console.WriteLine("TryGetValue");
            int test;
            if (dict.TryGetValue("cat", out test))
            {
                Console.WriteLine("Value find {0}", test);
            }

            Console.WriteLine("Key Value Pair");

            foreach (KeyValuePair<string, int> p in dict)
            {
                Console.WriteLine("{0} {1}", p.Key, p.Value);
            }

            Console.ReadKey();
            Console.WriteLine("Initialize Key Value Pair");
            {
                Dictionary<string, int> dict2 = new Dictionary<string, int>(){
                
                    {"hello",5},
                    {"worlds",6},
                    {"here",4}
                
                };

                List<string> keys = new List<string>(dict2.Keys);

                foreach (var s in keys)
                {
                    Console.WriteLine("Key is {0} {1}",s,dict2[s]);
                }

                Console.WriteLine("Which means that you can access the elements as if it was an array");

                Console.WriteLine(" for exampple {0}", dict2["hello"]);
                Console.ReadKey();

            }

        }
    }
}
