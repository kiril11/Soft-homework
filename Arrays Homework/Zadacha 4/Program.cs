using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter the number you wish to find between 1 and 10: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= array.Length - 1; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine();
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
