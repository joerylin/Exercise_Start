using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    class ShapeFactory
    {
        public char[,] CreateShape(CommonEnum.enmShape shape, Int32 length)
        {
            IShape creater;
            switch (shape)
            {
                case CommonEnum.enmShape.Diamond:
                    creater = new Diamond();
                    break;
                case CommonEnum.enmShape.Rectangle:
                    creater = new Rectangle();
                    break;
                case CommonEnum.enmShape.Square:
                    creater = new Square();
                    break;
                case CommonEnum.enmShape.Trapezoid:
                    creater = new Trapezoid();
                    break;
                default:
                    creater = null;
                    break;
            }

            creater.ShapeWidth = length;
            return creater.PaintShape();

        }
    }
}
