namespace Fibonacci
{
    public class Program
    {
        private static int[] memoization = new int[100];

        public static void Reset()
        {
            for (int i = 0; i < memoization.Length; i++)
            {
                memoization[i] = -1;
            }
        }

        public static int Fibonacci(int n)
        {
            if (memoization[n] != -1)
                return memoization[n];
            else
            {
                if (n <= 1)
                {
                    memoization[n] = n;
                    return memoization[n];
                }
                else
                    return Fibonacci(n - 2) + Fibonacci(n - 1);
            }

        }
        public static void Main(string[] args)
        {
            Reset();
            int result = Fibonacci(7);
            Console.WriteLine(result);

        }
    }
}