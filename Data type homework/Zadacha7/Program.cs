using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings:");
            Console.WriteLine();
            Console.Write("first string:");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.Write("second string:");
            string y = Console.ReadLine();
            bool z;
            z = x.Contains(y);
            Console.WriteLine(z);
        }
    }
}
