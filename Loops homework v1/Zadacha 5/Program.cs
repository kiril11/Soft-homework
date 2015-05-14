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
            Console.WriteLine("Enter values for n and k");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            long x = 0;
            long y = 0;
            long z=0;
            if (k > n)
            {
                Console.WriteLine("N must be larger than k");
            }
            else if ((k < 1) || (n < 1))
            {
                Console.WriteLine("K and N must be larger than 1");
            }
            else
            {
                long factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    x = (factorial *= i);
                }
                long factorial2 = 1;
                for (int i = 1; i <= k; i++)
                {
                    y = (factorial2 *= i);
                }
                Console.WriteLine(x*y);
                Console.WriteLine();
                long factorial3 = (n - k);
                for (int i = 1; i <= factorial3; i++)
                {
                     z = (factorial3 *= i);
                    Console.WriteLine((x * y) / z);
                    break;
                    }
                }
            }
        }
    }


