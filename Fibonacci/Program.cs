using System;

namespace Fibonacci
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

        static int FibonacciSeries(int n)
        {
            int firstnumber = 0;
            int secondnumber = 1;
            int result = 0;

            if (n == 0)
                return 0; 

            if (n == 1)
                return 1; 

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }

    }
}
