﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Console.WriteLine();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
