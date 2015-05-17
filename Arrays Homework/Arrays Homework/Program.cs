using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
           long x = 0;
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 14,23,24,60,23,12,235 };
            for (int i = 1; i <= array.Length-1; i++)
            {
                if(array[i]%2==0)
                {
                    x += array[i];
                    Console.WriteLine(x);
                }
            }

        }
    }
}
