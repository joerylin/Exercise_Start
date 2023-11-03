package Shape;

import CommonClass.Shape;

public class Diamond extends Shape
{
	@Override
	protected void PaintShape() {	
		char sign = ' ';
		int width = this.dlength * 2 - 1;
        int index_top = -1, index_s = -1, index_e = -1;
        index_top = this.dlength;

        this.shape = new char[width][ width];
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

            for (int j = 1; j <= width; j++) 
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
                this.shape[i - 1][ j - 1] = sign;
            }
        }    		
	}



}
