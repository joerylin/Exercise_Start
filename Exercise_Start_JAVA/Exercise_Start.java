 import java.util.Scanner;

public class Exercise_Start 
{	static Scanner scan=new Scanner(System.in);
	public static void main(String[] args) 
	{
		 String key = "";
         while (key.toLowerCase() != "E")
         {
             // Side length of Diamond
             int dlength = p_EnterNumber_ReadLine("Enter the side length of the diamond(between 3 and 10):", 3, 10);

             //direction
             int direction = p_EnterNumber_ReadLine("Enter the connecting direction(0: horizontal, 1:vertical):", 0, 1);

             // Side number of Diamond
             int number = p_EnterNumber_ReadLine("Enter the number of the diamond(between 2 and 6):", 2, 6);

             //Print Diamond
             p_PrintDiamond(dlength, direction, number);

             System.out.println("Press any key to continue! press \"C\" to clear console panel and press \"E\" to Exit!");
             key =scan.nextLine();
             if (key.toLowerCase() == "C")
                 System.console();
         }
	}
	private static int p_EnterNumber_ReadLine(String tip, int limitMin, int limitMax)
    {		
        int number = -1;
        while (number < limitMin|| number > limitMax)
        {
            System.out.println(tip);
            try
            {
                number = Integer.parseInt(scan.nextLine());
                
            }
            catch(Exception ex)
            {
                number = -1;
            }
        }
        return number;
    }

    private  static void p_PrintDiamond(int dlength, int direction, int number)
    {
        int width = dlength + (dlength - 1);
        char[][] diamondArray = p_getDiamond(dlength, width);

        char[][] Targetarray;

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
        Targetarray = new char[ilength][ jlength];

        // repeat diamond
        for (int cnt = 0; cnt < number; cnt++)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (direction == 0) // Direction : Horizontal
                    {
                        Targetarray[i][ cnt * (width + 1) + j] = diamondArray[i][ j];
                    }
                    else // Direction : Vertical
                    {
                        Targetarray[cnt * (width + 1) + i][ j] = diamondArray[i][ j];
                    }
                }
            }
        }

        //print Diamond
        p_PrintShape(Targetarray);
    }

    private static  char[][] p_getDiamond(int dlength, int width)
    {
        char sign = ' ';
        int index_top = -1, index_s = -1, index_e = -1;
        index_top = width / 2 + 1;

        char[][] diamondArray = new char[width][ width];
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
                diamondArray[i - 1][ j - 1] = sign;
            }
        }
        return diamondArray;
    }

    private  static void p_PrintShape(char[][] array) 
    {
        for (int i = 0; i < array.length; i++)
        {
            for (int j = 0; j < array[1].length; j++)
            {
            	System.out.print(array[i][ j]);
            }
            System.out.println();
        }
    }
}
