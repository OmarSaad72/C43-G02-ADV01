using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Advanced_C_
{
    internal class Helper<T>
    {
        #region Swap
        public static void Swap<T>(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }
        //public static void Swap (ref int x , ref int y )
        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion

        #region SearchArray
        public static int SearchArray<T>(T[] Arr, T value)
        {
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(value))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion
    }
}
