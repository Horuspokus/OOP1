using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Gökhan", "Kaan" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);

            List<string> names2 = new List<string> { "Engin", "Gökhan", "Kaan" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Araba");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);

        }
    }
}
