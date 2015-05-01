using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for Delimo and Delitel");
            Console.WriteLine();
            Console.Write("Delimo=");
            float Delimo = float.Parse(Console.ReadLine());
            Console.Write("Delitel=");
            int Delitel = int.Parse(Console.ReadLine());
            Console.WriteLine();
            double y = Delimo / Delitel;
            Console.WriteLine(y);

        }
    }
}
