package CommonClass;

import CommonClass.Enum.*;
import Shape.*;

public class ShapeFactory 
{
	
	public Shape CreateShape(CommonClass.Enum.EnmShape shape) 
	{
		Shape s;
		
		try {
			Class fac = Class.forName("Shape."+ shape.name());
			s = (Shape)fac.newInstance();
		}
		catch(ClassNotFoundException | InstantiationException |IllegalAccessException ex)
		{
			s = new  Diamond();
		}
		
		return s;		
	}
	
	
}
