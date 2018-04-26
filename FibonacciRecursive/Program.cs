using System;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the Fibonacci Series: ");

            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("{0} ", FibonacciSeries(i));
            }
            Console.ReadKey();
        }

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; 
            if (n == 1) return 1;

            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
