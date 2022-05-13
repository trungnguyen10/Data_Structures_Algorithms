namespace TaylorSeries
{
    public class Program
    {
        private static int p, f;

        public static void Reset()
        {
            p = 1; f = 1;
        }
        // Calculate e to the power of x with n degree
        public static double CalculateEx(int x, int n)
        {
            if (n == 0)
                return 1;
            else
            {
                double prev = CalculateEx(x, n - 1);
                p = p * x;
                f = f * n;
                return prev + (double)p / (double)f;
            }
        }


        public static void Main(string[] args)
        {
            Reset();
            double result = CalculateEx(2, 15);
            Console.WriteLine(result);

        }
    }
}