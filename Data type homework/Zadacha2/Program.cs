using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            Console.Write("Enter your text:");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(x.Contains("Hello"));
        }
    }
}
