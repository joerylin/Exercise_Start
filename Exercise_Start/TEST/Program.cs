using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] array = new char[3, 7];
            Print("array.Length", array.Length);
            Print("array.LongLength", array.LongLength);
            Print("array.Rank", array.Rank);
            Print("array.GetLength(0)", array.GetLength(0));
            Print("array.GetLength(1)", array.GetLength(1));
            
            
            
        }

        static void Print(String title, object value)
        {
            Console.WriteLine(String.Format("{0} = {1}", title, value));
        }

    }
}
