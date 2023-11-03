using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    interface IShape
    {

        char[,] PaintShape();

        Int32 ShapeWidth
        {
            get;
            set;
        }
    }
}
