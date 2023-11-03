package Shape;

import CommonClass.Shape;

public class Line extends Shape {

	@Override
	protected void PaintShape() {	
		char sign = '*';
		
        this.shape = new char[this.dlength][ this.dlength];
        int rowIndex = this.dlength/2;
        for (int i = 1 ; i <= this.dlength; i++)
        {
        	this.shape[rowIndex][ i-1] = sign;
        }    		
	}

}
