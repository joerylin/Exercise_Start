using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    /// <summary>
    /// 傳入長度 length
    /// 上底       = length
    /// 高         = length
    /// 上底起始點 = length
    /// 下底       = length + (length-1)*2
    /// array area = 下底 *　高
    /// </summary>
    class Trapezoid : BaseShape, IShape
    {
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
            Int32 index_s = -1, index_e = -1;
            Int32 bottom_len = this.ShapeWidth + (this.ShapeWidth - 1) * 2;   //下底

            char[,] ShapeArray = new char[this.ShapeWidth, bottom_len];
            for (int i = 1; i <= this.ShapeWidth; i++)// i = level (row) count 1 to 高=len=(this.ShpeWidth)
            {
                // calculate the index of index_s and index_e
                if (i == 1)
                {
                    index_s = this.ShapeWidth;
                    index_e = (this.ShapeWidth + this.ShapeWidth - 1);
                }
                else
                {
                    index_s--;
                    index_e++;
                }

                for (int j = 1; j <= bottom_len; j++)    // j = column count
                {
                    ShapeArray[i - 1, j - 1] = this.GetSign(i, j, index_s, index_e);
                }
            }
            return ShapeArray;
        }

        #region

        /// <summary>
        /// Get paint sign
        /// </summary>
        /// <param name="level">row level(hight)</param>
        /// <param name="currentIndex">cloumn index</param>
        /// <param name="index_s">start number of row</param>
        /// <param name="index_e">end number of row</param>
        /// <returns></returns>
        protected char GetSign(int level, int currentIndex, int index_s, int index_e)
        {
            char sign = 'X';
            if (level == 1 || level == this.ShapeWidth)
            {
                if (currentIndex < index_s || currentIndex > index_e)
                    sign = base.EmptySign;
                else if (currentIndex >= index_s || currentIndex <= index_e)
                    sign = base.LineSign;
                else
                    sign = 'X';
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
