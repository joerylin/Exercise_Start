using System;
using System.Text;


namespace Exercise_Start
{
    class Exercise_Start
    {
        static void Main(string[] args)
        {
            String key = String.Empty;
            while (key.ToUpper() != "E")
            {
                // Side length of Diamond
                Int32 dlength = p_EnterNumber_ReadLine("Enter the side length of the diamond(between 3 and 10):", 3, 10);

                //direction
                Int32 direction = p_EnterNumber_ReadLine("Enter the connecting direction(0: horizontal, 1:vertical):", 0, 1);

                // Side number of Diamond
                Int32 number = p_EnterNumber_ReadLine("Enter the number of the diamond(between 2 and 6):", 2, 6);

                //Print Diamond
                p_PrintDiamond(dlength, direction, number);

                Console.WriteLine("Press any key to continue! press \"C\" to clear console panel and press \"E\" to Exit!");
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
                Console.WriteLine(tip);
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

        static private void p_PrintDiamond(Int32 dlength, Int32 direction, Int32 number)
        {
            Int32 width = dlength + (dlength - 1);
            char[,] diamondArray = p_getDiamond(dlength, width);

            char[,] Targetarray;

            // set diamond array 
            int ilength, jlength;
            if (direction == 0)
            {
                ilength = width;
                jlength = width * number + number;
            }
            else
            {
                ilength = width * number + number;
                jlength = width;
            }
            Targetarray = new char[ilength, jlength];

            // repeat diamond
            for (int cnt = 0; cnt < number; cnt++)
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (direction == 0) // Direction : Horizontal
                        {
                            Targetarray[i, cnt * (width + 1) + j] = diamondArray[i, j];
                        }
                        else // Direction : Vertical
                        {
                            Targetarray[cnt * (width + 1) + i, j] = diamondArray[i, j];
                        }
                    }
                }
            }

            //print Diamond
            p_PrintDiamond(Targetarray);
        }

        static private char[,] p_getDiamond(Int32 dlength, Int32 width)
        {
            char sign = ' ';
            Int32 index_top = -1, index_s = -1, index_e = -1;
            index_top = width / 2 + 1;

            char[,] diamondArray = new char[width, width];
            for (int i = 1; i <= width; i++)// i = level (row) count 
            {
                // calculate the index of index_s and index_e
                if (i <= dlength)
                {
                    index_s = index_top - (i - 1);
                    index_e = index_top + (i - 1);
                }
                else
                {
                    index_s = i - (index_top - 1);
                    index_e = width - (i - index_top);
                }

                for (int j = 1; j <= width; j++)    // j = column count
                {
                    if (i == 1 || i == width)
                    {
                        if (j < index_top || j > index_top)
                            sign = ' ';
                        else
                            sign = '@';
                    }
                    else
                    {
                        if (j < index_s || j > index_e)
                            sign = ' ';
                        else if (j == index_s || j == index_e)
                            sign = '@';
                        else if (j > index_s && j < index_e)
                            sign = '*';
                        else
                            sign = 'X';
                    }
                    diamondArray[i - 1, j - 1] = sign;
                }
            }
            return diamondArray;
        }

        static private void p_PrintDiamond(char[,] array)
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
