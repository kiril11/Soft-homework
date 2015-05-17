using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for a and b. B must be larger than A! ");
            Console.WriteLine();
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
         
               for (int i = a; a <= b; a++)
                {
                    if (a % 3 == 0)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
        }
    }

