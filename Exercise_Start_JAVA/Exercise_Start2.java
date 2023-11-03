

import java.util.Scanner;

import CommonClass.Shape;
import CommonClass.ShapeFactory;
import CommonClass.Enum.EnmDirection;
import CommonClass.Enum.EnmShape;
import Shape.*;

public class Exercise_Start2 
{	
	static Scanner scan=new Scanner(System.in);

	public static void main(String[] args) 
	{
		 String key = "";
         while (key.toLowerCase() != "E")
         {
        	 StringBuilder sb;
        	 
        	 // What kind of shape would you choose?
        	 sb = new StringBuilder();
             for(EnmShape d: EnmShape.values())
            	 sb.append(String.format("%d:%S ", d.ordinal(), d.toString()));           	        	
        	 int shape = p_EnterNumber_ReadLine("What kind of shape would you choose?(" + sb.toString() + ")", 0, EnmShape.values().length);
        	 
             // Side length of Diamond
             int dlength = p_EnterNumber_ReadLine("Enter the side length of the diamond(between 3 and 10):", 3, 10);

             //direction
             sb = new StringBuilder();
             for(EnmDirection d: EnmDirection.values())
            	 sb.append(String.format("%d:%S ", d.ordinal(), d.toString()));             
             int direction = p_EnterNumber_ReadLine("Enter the connecting direction(" + sb.toString() + "):", 0, EnmDirection.values().length);

             // Side number of Diamond
             int number = p_EnterNumber_ReadLine("Enter the number of the diamond(between 2 and 6):", 2, 6);

             //Print Diamond
             
             Shape shp = new ShapeFactory().CreateShape(EnmShape.values()[shape]);
             shp.setLength(dlength);
             shp.PrintShape(shp.Clone(EnmDirection.values()[direction], number));
             
             

             System.out.println("Press any key to continue! press \"C\" to clear console panel and press \"E\" to Exit!");
             key =scan.nextLine();
             if (key.toLowerCase() == "C")
                 System.console().flush();
         }
	}
	
	private static int p_EnterNumber_ReadLine(String tip, int limitMin, int limitMax)
    {
		
        int number = -1;
        while (number < limitMin)
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
 
            if (number < limitMin || number > limitMax)
                number = -1;
        }
        return number;
    }

    
}
