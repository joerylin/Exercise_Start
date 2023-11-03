using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    class Diamond : BaseShape, IShape
    {
        /// <summary>
        /// ShapeLength is total length of shape
        /// base.ShapeWidth is each width of shape
        /// </summary>
        public Int32 ShapeLength
        {
            get
            {
                return base.ShapeWidth + (base.ShapeWidth - 1);
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
            Int32 index_top = -1, index_s = -1, index_e = -1;
            index_top = this.ShapeLength / 2 + 1;

            char[,] diamondArray = new char[this.ShapeLength, this.ShapeLength];
            for (int i = 1; i <= this.ShapeLength; i++)// i = level (row) count 
            {
                // calculate the index of index_s and index_e
                if (i <= this.ShapeWidth)
                {
                    index_s = index_top - (i - 1);
                    index_e = index_top + (i - 1);
                }
                else
                {
                    index_s = i - (index_top - 1);
                    index_e = this.ShapeLength - (i - index_top);
                }

                for (int j = 1; j <= this.ShapeLength; j++)    // j = column count
                { 
                    diamondArray[i - 1, j - 1] = this.GetSign(i, j, index_top, index_s, index_e);
                }
            }
            return diamondArray;
        }

        #region 
  
        /// <summary>
        /// Get paint sign
        /// </summary>
        /// <param name="level">row index</param>
        /// <param name="currentIndex">cloumn index</param>
        /// <param name="index_top">the midle index of the top row</param>
        /// <param name="index_s">start number of row</param>
        /// <param name="index_e">end number of row</param>
        /// <returns></returns>
        protected char GetSign(int level, int currentIndex, int index_top, int index_s, int index_e)
        {
            char sign = 'X';
            if (level == 1 || level == this.ShapeLength)
            {
                if (currentIndex < index_top || currentIndex > index_top)
                    sign = base.EmptySign;
                else
                    sign = base.LineSign;
            }
            else
            {
                if (currentIndex < index_s || currentIndex > index_e)
                    sign = base.EmptySign;
                else if (currentIndex == index_s || currentIndex == index_e)
                    sign = base.LineSign;
                else if (currentIndex > index_s && currentIndex < index_e)
                    sign = base.SolidSign;
                else
                    sign = 'X';
            }
            return sign;
        }

        #endregion
    }
}
