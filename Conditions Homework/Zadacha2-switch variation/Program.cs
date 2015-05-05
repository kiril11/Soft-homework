using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_switch_variation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 9");
            Console.WriteLine();
            Console.Write("Your Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (x)
            {        
                case 1: 
                case 2: 
                case 3:
                    {
                        Console.Write("Your points are:");
                        Console.WriteLine(x * 5);
                        break;
                    }
                case 4: 
                case 5: 
                case 6:
                    {
                        Console.Write("Your points are:");
                        Console.WriteLine(x * 10);
                        break;
                    }
                case 7: 
                case 8: 
                case 9:
                    {
                        Console.Write("Your points are:");
                        Console.WriteLine(x * 50);
                            break;;
                    }
                default: Console.WriteLine("Wrong value for your numver"); break;
            }
        }
    }
}
