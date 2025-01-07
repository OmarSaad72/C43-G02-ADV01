namespace Session01_Advanced_C_
{
    internal class Program
    {
        static void Main()
        {
            #region Generics
            int A = 8, B = 10;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("After Swap: ");
            Helper<int>.Swap(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine("***********************");
            double x = 10.5, y = 20.5;
            //double x = 10.5, y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("After Swap: ");
            Helper<double>.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("***********************");
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine("After Swap: ");
            Helper<Point>.Swap(ref p1, ref p2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            #endregion

        }
    }
}

