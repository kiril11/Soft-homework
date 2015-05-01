using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string and the position");
            Console.WriteLine();
            Console.Write("string:");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.Write("position:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(x[y-1]);
        }
    }
}
