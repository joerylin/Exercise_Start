package CommonClass;

import CommonClass.Enum.*;


public abstract  class Shape 
{
	protected int dlength;
	protected char[][] shape;	
	
	protected abstract void PaintShape();
	
	public void setLength(int len) {this.dlength = len;	this.PaintShape();}
	
	public char[][] Clone(EnmDirection direction, int number)
	{
		
		char[][] Targetarray;

        // set diamond array 
        int ilength, jlength;
        int width = this.shape[0].length;
        if (direction == EnmDirection.Horizantal)
        {
            ilength = width;
            jlength = width * number + number;	// "+number" for each shape has an empty line
        }
        else
        {
            ilength = width * number + number;
            jlength = width;
        }
        Targetarray = new char[ilength][ jlength];

        // repeat shape        
        for (int cnt = 0; cnt < number; cnt++)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (direction == EnmDirection.Horizantal) // Direction : Horizontal
                    {
                        Targetarray[i][ cnt * (width + 1) + j] = this.shape[i][ j];
                    }
                    else // Direction : Vertical
                    {
                        Targetarray[cnt * (width + 1) + i][ j] = this.shape[i][ j];
                    }
                }
            }
        }
        
        return Targetarray;
	}
		
	public void PrintShape() 
	{
		this.PrintShape(this.shape);
	}
	public void PrintShape(char[][] shape) 
    {
        for (int i = 0; i < shape.length; i++)
        {
            for (int j = 0; j < shape[1].length; j++)
            {
            	System.out.print(shape[i][ j]);
            }
            System.out.println();
        }
    }
	
	
	

}
