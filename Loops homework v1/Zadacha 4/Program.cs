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
                    factorial *= i;
                }
                long factorial2 = 1;
                for (int i = 1; i <= k; i++)
                {
                    factorial2 *= i;
                }
                Console.WriteLine(factorial / factorial2);
            }
        }
    }
}

