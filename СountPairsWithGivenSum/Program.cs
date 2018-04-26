using System;
using System.Collections.Generic;

namespace СountPairsWithGivenSum
{
    class Program
    {
        static int[] arr = {11, 1, 3, -2, 7, -1, -5, 5};
        static Dictionary<int, int> dict = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            int sum = 6;

            for (int i = 0; i < arr.Length; i++)
                dict.Add(arr[i], i);

            Console.WriteLine("Count of pairs is " + GetPairsCount(sum));
            Console.ReadKey();
        }

        private static string GetPairsCount(int sum)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var compliment = sum - arr[i];

                if (dict.TryGetValue(compliment, out var v)) //&& i != v
                {
                    return string.Format($"{arr[i]} and {arr[v]}");
                }
            }
            return "nothing was found";
        }
    }


}
