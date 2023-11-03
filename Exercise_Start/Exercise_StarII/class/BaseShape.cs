using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_StarII
{
    abstract  class BaseShape
    {
        protected Char SolidSign
        {
            get
            {
                return '$';
            }
        }
        protected Char EmptySign
        {
            get
            {
                return ' ';
            }
        }
        protected Char LineSign
        {
            get
            {
                return '@';
            }
        }

        protected Int32 ShapeWidth;

   
      
    }
}
