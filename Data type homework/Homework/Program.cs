using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for x and y");
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("The sum is:");
            Console.WriteLine(x + y);
        }
        }
    }
