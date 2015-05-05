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
            Console.WriteLine("Enter a number between 0 and 9");
            Console.WriteLine();
            Console.Write("Your number:");
            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 3)
            {
                Console.Write("Your points are:");
                Console.WriteLine(x * 5);
            }
            else if (x >= 4 && x <= 6)
            {
                Console.Write("Your points are:");
                Console.WriteLine(x * 10);
            }
            else if (x >= 7 && x <= 9)
            {
                Console.Write("Your points are:");
                Console.WriteLine(x * 50);
            }
            else
            {
                Console.WriteLine("Wrong value for your number");

            }
        }
    }
}
