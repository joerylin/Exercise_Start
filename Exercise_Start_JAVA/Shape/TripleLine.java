package Shape;

import CommonClass.Shape;

public class TripleLine extends Shape {

	@Override
	protected void PaintShape() {
		char sign = '*';
		this.shape = new char[this.dlength][ this.dlength];
        int rowIndex = this.dlength/2;
        for (int i = 1 ; i <= this.dlength; i++)
        {
        	this.shape[0][ i-1] = sign;
        	this.shape[1][ i-1] = sign;
        }    	

	}

}
