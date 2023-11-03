using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    class Rectangle : BaseShape, IShape
    {
        /// <summary>
        /// ShapeLength is total length of shape
        /// base.ShapeWidth is each width of shape
        /// </summary>
        public Int32 ShapeLength
        {
            get
            {
                return base.ShapeWidth * 2;
            }
        }

        public Int32 ShapeWidth
        {
            get
            {
                return base.ShapeWidth;
            }
            set
            {
                base.ShapeWidth = value;
            }
        }

        public char[,] PaintShape()
        {
            char[,] ShapeArray = new char[this.ShapeLength,this.ShapeWidth];
            for (int i = 1; i <= this.ShapeLength; i++)// i = level (row) count 
            {
                for (int j = 1; j <= this.ShapeWidth; j++)    // j = column count
                {
                    if (i == 1 || i == this.ShapeLength)
                        ShapeArray[i - 1, j - 1] = base.LineSign;                    
                    else 
                    {
                        if (j == 1 || j == this.ShapeWidth)
                            ShapeArray[i - 1, j - 1] = base.LineSign; 
                        else
                            ShapeArray[i - 1, j - 1] = base.SolidSign; 
                    }
                }
            }
            return ShapeArray;
        }

   
    }
}
