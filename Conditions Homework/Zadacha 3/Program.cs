using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your card");
            Console.WriteLine();
            Console.Write("Your card is: ");
            string x = Console.ReadLine();
            switch (x)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":

                {
                    Console.WriteLine("Your card is valid");
                    break;
                }
                case "J":
                case "K":
                case "Q":
                case "A":
                {
                    Console.WriteLine("Your card is valid");
                    break;
                }
                default: Console.WriteLine("Your card is invalid");
                break;
            }
        }
    }
}