namespace Assignment3OOP
{
    internal class Program
    {
        #region overloading
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y,int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }
        public static double Sum(double x,  int y)
        {
            return x + y;
        }
        #endregion
        static void Main(string[] args)
        {
            #region Ploymorphism[Overloading]
            int result = Sum(1, 2);
            Console.WriteLine(result);
            int result2 = Sum(1, 2,3);
            Console.WriteLine(result2);
            double result3 = Sum(1.2, 2.2);
            Console.WriteLine(result3);
            #endregion
        }
    }
}
