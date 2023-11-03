using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    class Program
    {
        static void Main(string[] args)
        {
            String key = String.Empty;
            while (key.ToUpper() != "E")
            {
                // Choose one kind of shpae
                Int32 i_digram = p_EnterNumber_ReadLine("What kind of shape would you like to paint? \n(0)Diamond \n(1)Rectangle \n(2)Square \n(3)Trapezoid \n Please choose one kind of shape >", 0, 3);

                // Side length of Diamond
                Int32 dlength = p_EnterNumber_ReadLine("Enter the side length of the Shape(between 3 and 10):", 3, 10);

                //direction
                CommonEnum.enmDirection direction = (p_EnterNumber_ReadLine("Enter the connecting direction(0: horizontal, 1:vertical):", 0, 1) == 0 ? CommonEnum.enmDirection.Horizontal : CommonEnum.enmDirection.Vertical);

                // Side number of Diamond
                Int32 number = p_EnterNumber_ReadLine("Enter the number of the shape(between 2 and 6):", 2, 6);

                // Create Shapte 
                Console.WriteLine();
                
                ShapeFactory shpae = new ShapeFactory();
                char[,] array=shpae.CreateShape((CommonEnum.enmShape)i_digram, dlength);

                // Repeat digram & Print Shpate
                 Repeater rpter = new Repeater();
                new Printer().PrintShape(rpter.RepeatShape(array,direction, number));

                Console.WriteLine("\n\nPress any key to continue! press \"C\" to clear console panel and press \"E\" to Exit!");
                key = Convert.ToString(Console.ReadLine());
                if (key.ToUpper() == "C")
                    Console.Clear();
            }
        }

        static private Int32 p_EnterNumber_ReadLine(String tip, Int32 limitMin, Int32 limitMax)
        {
            Int32 number = -1;
            while (number < limitMin)
            {
                Console.Write(tip+"\t");                
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    number = -1;
                }
                if (number < limitMin || number > limitMax)
                    number = -1;
            }
            return number;
        }
    }
}
