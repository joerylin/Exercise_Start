using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    class Printer
    {

        public  void PrintShape(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
