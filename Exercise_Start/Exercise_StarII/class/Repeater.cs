using System;
using System.Collections.Generic;



namespace Exercise_StarII
{
    class Repeater
    {
        public char[,] RepeatShape(char[,] array, CommonEnum.enmDirection  direction, Int32 number)
        {         
            char[,] Targetarray;  
                    
            int ilength =array.GetLength(0);
            int jlength=array.GetLength(1);
            // set array 
            if (direction ==  CommonEnum.enmDirection.Horizontal)
                Targetarray = new char[ilength, jlength * number + number];   
            else
                Targetarray = new char[ilength * number + number, jlength];                     

            // repeat array
            for (int cnt = 0; cnt < number; cnt++)
            {
                for (int i = 0; i < ilength; i++)
                {
                    for (int j = 0; j < jlength; j++)
                    {
                        if (direction == CommonEnum.enmDirection.Horizontal) 
                        {
                            // Direction : Horizontal
                            Targetarray[i, cnt * (jlength + 1) + j] = array[i, j];
                        }
                        else 
                        {
                            // Direction : Vertical
                            Targetarray[cnt * (ilength + 1) + i, j] = array[i, j];
                        }
                    }
                }
            }
            return Targetarray;
        }
    }
}
