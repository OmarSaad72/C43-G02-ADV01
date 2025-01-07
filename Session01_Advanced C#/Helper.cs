using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01_Advanced_C_
{
    internal class Helper<T>
    {
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
    }
}
