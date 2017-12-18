using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal struct paint
    {
        

        internal int star_X;
        internal int star_Y;
      



    }
    internal struct Student
    {
        internal string name;
    
        internal int num1;
        internal int num2;
        internal int num3;
        internal int tatol;
        internal int max;
        internal int min;
        internal int average;
        


    }
    internal struct StudentTatol
    {
        internal int times;
        internal int num1tatol;
        internal int num1max;
        internal int num1min;
        internal int num2tatol;
        internal int num2max;
        internal int num2min;
        internal int num3tatol;
        internal int num3max;
        internal int num3min;
    }
    class std_generic { 
    static internal int max (int x, int y,int z)
    {
        int max;
        if (x > y)
        {
            max = x;
        }
        else
        {
            max = y;
        }
        if (max < z)
        {
            max = z;

        }
        //三個數字抓最大

        return max;
    }
    static internal int min(int x, int y, int z)
        {
            int min;
            if (x < y)
            {

                min = x;
            }
            else
            {
                min = y;
            }
            if (min > z)
            {

                min = z;
            }
            //三個數字抓最小

            return min;
        }
    
    }

}
