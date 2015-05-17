using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_6
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] array = new int[5, 6]{
                { 1,  2,  3,  4,  5, 6},
                { 7,  8,  9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18},
                {19, 20, 21, 22, 23, 24},
                {25, 26, 27, 28, 29, 30},
            };
           for (int redica = 0; redica < array.GetLength(0); redica++)   
           {
               for (int kolona = 0; kolona < array.GetLength(1); kolona++) 
               {
                   Console.Write(array[redica, kolona]);
               }
               Console.WriteLine();
           }
           Console.WriteLine();
           for (int row = array.GetLength(0) - 1; row >= 0; row--)
           {
               for (int col = array.GetLength(1) - 1; col >= 0; col--)
               {
                   Console.Write(array[row, col]);
               }
               Console.WriteLine();
           }
        }
    }
}