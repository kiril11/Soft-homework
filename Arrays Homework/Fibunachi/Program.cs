using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibunachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter the size of the array");
            int j = int.Parse(Console.ReadLine());
            int[] array = new int[j];
            Console.WriteLine("Enter numbers for the array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int k = 0; k <= array.Length-1; k++)
            {
                x += array[k];
                Console.WriteLine(x);

            }
        }
    }
}
