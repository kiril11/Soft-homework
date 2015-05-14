using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Console.WriteLine();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            while (number <= n)
            {
                if (number % 7 != 0 && number % 3 != 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
