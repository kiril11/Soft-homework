﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3 // Vidqno ot Diliqn
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers:");

            int biggest = 0;
            int smallest = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number {0}: ", i);
                int number = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    biggest = number;
                    smallest = number;
                }
                else
                {
                    if (number > biggest)
                    {
                        biggest = number;
                    }
                    else if (number < smallest)
                    {
                        smallest = number;
                    }
                }
            }

            Console.WriteLine("Biggest: {0}\nSmallest: {1}", biggest, smallest);
        }
    }
}