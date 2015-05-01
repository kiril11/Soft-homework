using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two strings:");
            Console.Write("string x=");
            string x = Console.ReadLine();
            Console.Write("string y=");
            string y = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(x+"_"+y);
        }
    }
}
